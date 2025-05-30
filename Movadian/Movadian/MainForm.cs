﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxCollectData.Library.Dto;

namespace Movadian
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var settings = SettingsManager.Load();
            txtMemoryId.Text = settings.MemoryId;
            txtCertPath.Text = settings.CertificatePath;
            txtKeyPath.Text = settings.PrivateKeyPath;

            apiManager = new TaxApiManager();
        }
        private TaxApiManager apiManager;

        private void btnBrowseCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Certificate Files (*.cer;*.crt)|*.cer;*.crt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtCertPath.Text = dlg.FileName;
            }
        }

        private void btnBrowseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Private Key Files (*.pem)|*.pem|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtKeyPath.Text = dlg.FileName;
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string certPath = txtCertPath.Text.Trim();
                string keyPath = txtKeyPath.Text.Trim();
                string memoryId = txtMemoryId.Text.Trim();

                if (string.IsNullOrWhiteSpace(certPath) ||
                    string.IsNullOrWhiteSpace(keyPath) ||
                    string.IsNullOrWhiteSpace(memoryId))
                {
                    txtLog.Text = " لطفاً همه فیلدها را وارد کنید.";
                    return;
                }

                if (!File.Exists(certPath))
                {
                    txtLog.Text = " فایل گواهی وجود ندارد.";
                    return;
                }
                if (!File.Exists(keyPath))
                {
                    txtLog.Text = " فایل کلید خصوصی وجود ندارد.";
                    return;
                }

                apiManager.Initialize(memoryId, keyPath, certPath);

                bool connectionOk = apiManager.TestConnection(memoryId);
                if (connectionOk)
                {
                    txtLog.Text = " اتصال با سامانه برقرار شد (صورتحساب تستی ارسال شد)";
                }
                else
                {
                    txtLog.Text = " اتصال برقرار نشد! لطفاً فایل‌ها و اطلاعات را بررسی کنید.";
                }


                var settings = new UserSettings
                {
                    MemoryId = memoryId,
                    CertificatePath = certPath,
                    PrivateKeyPath = keyPath
                };
                SettingsManager.Save(settings);
            }
            catch (Exception ex)
            {
                txtLog.Text = " خطا در اتصال:\r\n" + ex.Message;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private string lastReferenceNumber = null;

        private void btnSendInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (apiManager?.TaxApi == null)
                {
                    txtLog.Text = " لطفاً ابتدا اتصال را برقرار کنید.";
                    return;
                }

                string memoryId = txtMemoryId.Text.Trim();
                string tins = txtTins.Text.Trim();
                string tinb = txtTinb.Text.Trim();
                string tdis = txtTdis.Text.Trim();
                string tvam = txtTvam.Text.Trim();
                string tbill = txtTbill.Text.Trim();
                string setm = txtSetm.Text.Trim();

                var invoice = InvoiceBuilder.BuildInvoice(memoryId, tins, tinb, tdis, tvam, tbill, setm, dgvItems);

                var result = apiManager.TaxApi.SendInvoices(new List<InvoiceDto> { invoice });

                if (result.Count > 0)
                {
                    var response = result[0];
                    lastReferenceNumber = response.ReferenceNumber;

                    txtLog.Text = $" ارسال موفق:\r\n" +
                                  $"Reference Number: {response.ReferenceNumber}\r\n" +
                                  $"Tax ID: {response.TaxId}\r\n" +
                                  $"UID: {response.Uid}";
                }
                else
                {
                    txtLog.Text = " پاسخ دریافت نشد.";
                }
            }
            catch (Exception ex)
            {
                txtLog.Text = " خطا در ارسال صورتحساب:\r\n" + ex.Message;
            }
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lastReferenceNumber))
                {
                    txtLog.Text = " هیچ شماره پیگیری ذخیره نشده است.";
                    return;
                }

                txtLog.Text = " در حال بررسی وضعیت...";
                await Task.Delay(10000);

                var memoryId = txtMemoryId.Text.Trim();
                var start = DateTime.Now.AddMinutes(-10);
                var end = DateTime.Now;

                var dto = new InquiryByReferenceNumberDto(
                    new List<string> { lastReferenceNumber },
                    start,
                    end
                );

                var results = apiManager.TaxApi.InquiryByReferenceId(dto);
                if (results.Count > 0)
                {
                    var result = results[0];
                    txtLog.Text = $" نتیجه استعلام:\r\n" +
                                  $"Status: {result.Status}\r\n" +
                                  $"Reference: {result.ReferenceNumber}\r\n";

                    if (result.Data?.Error != null)
                    {
                        foreach (var error in result.Data.Error)
                        {
                            txtLog.AppendText($"\r\n Error: {error.Code} - {error.Message}");
                        }
                    }

                    if (result.Data?.Warning != null)
                    {
                        foreach (var warning in result.Data.Warning)
                        {
                            txtLog.AppendText($"\r\n Warning: {warning.Code} - {warning.Message}");
                        }
                    }
                }
                else
                {
                    txtLog.Text = " نتیجه‌ای برای استعلام یافت نشد.";
                }
            }
            catch (Exception ex)
            {
                txtLog.Text = " خطا در استعلام وضعیت:\r\n" + ex.Message;
            }
        }
    }
}
