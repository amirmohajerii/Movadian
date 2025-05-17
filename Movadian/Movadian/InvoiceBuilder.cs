using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaxCollectData.Library.Algorithms;
using TaxCollectData.Library.Dto;
using TaxCollectData.Library.Providers;

namespace Movadian
{
    public static class InvoiceBuilder
    {
        public static InvoiceDto BuildInvoice(string memoryId, string tins, string tinb,
                                              string tdis, string tvam, string tbill, string setm,
                                              DataGridView itemsGrid)
        {
            var random = new Random();
            long serial = (long)(random.Next(100000000, 999999999));
            DateTime now = DateTime.Now;
            long indatim = new DateTimeOffset(now).ToUnixTimeMilliseconds();

            var taxIdProvider = new TaxIdProvider(new VerhoeffAlgorithm());
            string taxId = taxIdProvider.GenerateTaxId(memoryId, serial, now);
            string inno = serial.ToString("X").PadLeft(10, '0');

            var bodyItems = new List<BodyItemDto>();
            foreach (DataGridViewRow row in itemsGrid.Rows)
            {
                if (row.IsNewRow) continue;

                var item = new BodyItemDto
                {
                    sstid = row.Cells["sstid"].Value?.ToString() ?? "",
                    sstt = row.Cells["sstt"].Value?.ToString() ?? "",
                    mu = row.Cells["mu"].Value?.ToString() ?? "",
                    am = (decimal?)Convert.ToDecimal(row.Cells["am"].Value),
                    fee = (decimal?)Convert.ToDecimal(row.Cells["fee"].Value),
                    vam = (long?)Convert.ToDecimal(row.Cells["vam"].Value),
                    tsstam = (long?)Convert.ToDecimal(row.Cells["tsstam"].Value)
                };

                bodyItems.Add(item);
            }

            return new InvoiceDto
            {
                Header = new HeaderDto
                {
                    taxid = taxId,
                    inno = inno,
                    indatim = indatim,
                    inty = 1,
                    inp = 1,
                    ins = 1,
                    tins = tins,
                    tinb = tinb,
                    tdis = (long?)Convert.ToDecimal(tdis),
                    tvam = (long?)Convert.ToDecimal(tvam),
                    tbill = (long?)Convert.ToDecimal(tbill),
                    setm = Convert.ToInt32(setm)
                },
                Body = bodyItems
            };
        }
    }
}
