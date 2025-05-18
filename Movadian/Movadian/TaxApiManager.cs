using System;
using System.Collections.Generic;
using TaxCollectData.Library.Abstraction.Clients;
using TaxCollectData.Library.Abstraction.Cryptography;
using TaxCollectData.Library.Algorithms;
using TaxCollectData.Library.Dto;
using TaxCollectData.Library.Factories;
using TaxCollectData.Library.Properties;
using TaxCollectData.Library.Providers;

namespace Movadian
{
    public class TaxApiManager
    {
        private const string ApiUrl = "https://tp.tax.gov.ir/requestsmanager";
        public ITaxApi TaxApi { get; private set; }

        public void Initialize(string memoryId, string privateKeyPath, string certPath)
        {
            var properties = new TaxProperties(memoryId);
            var taxApiFactory = new TaxApiFactory(ApiUrl, properties);

            var signatoryFactory = new Pkcs8SignatoryFactory();
            ISignatory signatory = signatoryFactory.Create(privateKeyPath, certPath);

            var publicApi = taxApiFactory.CreatePublicApi(signatory);
            IEncryptor encryptor = new EncryptorFactory().Create(publicApi);

            TaxApi = taxApiFactory.CreateApi(signatory, encryptor);
        }
        public bool TestConnection(string memoryId)
        {
            try
            {
                var taxIdProvider = new TaxIdProvider(new VerhoeffAlgorithm());
                long serial = new Random().Next(100000000, 999999999);
                DateTime now = DateTime.Now;
                string taxId = taxIdProvider.GenerateTaxId(memoryId, serial, now);
                string inno = serial.ToString("X").PadLeft(10, '0');
                long indatim = new DateTimeOffset(now).ToUnixTimeMilliseconds();

                var invoice = new InvoiceDto
                {
                    Header = new HeaderDto
                    {
                        taxid = taxId,
                        inno = inno,
                        indatim = indatim,
                        inty = 1,
                        inp = 1,
                        ins = 1,
                        tins = "000000000000",
                        tinb = "000000000000",
                        tdis = 0,
                        tvam = 0,
                        tbill = 1,
                        setm = 1
                    },
                    Body = new List<BodyItemDto>
            {
                new BodyItemDto
                {
                    sstid = "TEST00000001",
                    sstt = "کالای تستی",
                    mu = "عدد",
                    am = 1,
                    fee = 1,
                    vam = 0,
                    tsstam = 1
                }
            }
                };

                var result = TaxApi.SendInvoices(new List<InvoiceDto> { invoice });

                return result.Count > 0 && !string.IsNullOrEmpty(result[0].ReferenceNumber);
            }
            catch
            {
                return false;
            }
        }

    }
}
