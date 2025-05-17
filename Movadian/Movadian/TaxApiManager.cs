using TaxCollectData.Library.Abstraction.Clients;
using TaxCollectData.Library.Abstraction.Cryptography;
using TaxCollectData.Library.Factories;
using TaxCollectData.Library.Properties;

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
    }
}
