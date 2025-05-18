namespace Movadian
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCertPath = new System.Windows.Forms.TextBox();
            this.txtKeyPath = new System.Windows.Forms.TextBox();
            this.txtMemoryId = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtTins = new System.Windows.Forms.TextBox();
            this.txtTinb = new System.Windows.Forms.TextBox();
            this.txtTdis = new System.Windows.Forms.TextBox();
            this.txtTvam = new System.Windows.Forms.TextBox();
            this.txtTbill = new System.Windows.Forms.TextBox();
            this.txtSetm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.sstid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsstam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendInvoice = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnBrowseCert = new System.Windows.Forms.Button();
            this.btnBrowseKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1195, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسیر گواهینامه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1187, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "مسیر کلید خصوصی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1166, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شناسه یکتای حافظه مالیاتی";
            // 
            // txtCertPath
            // 
            this.txtCertPath.Location = new System.Drawing.Point(1183, 90);
            this.txtCertPath.Name = "txtCertPath";
            this.txtCertPath.Size = new System.Drawing.Size(100, 20);
            this.txtCertPath.TabIndex = 3;
            // 
            // txtKeyPath
            // 
            this.txtKeyPath.Location = new System.Drawing.Point(1183, 129);
            this.txtKeyPath.Name = "txtKeyPath";
            this.txtKeyPath.Size = new System.Drawing.Size(100, 20);
            this.txtKeyPath.TabIndex = 4;
            // 
            // txtMemoryId
            // 
            this.txtMemoryId.Location = new System.Drawing.Point(1183, 168);
            this.txtMemoryId.Name = "txtMemoryId";
            this.txtMemoryId.Size = new System.Drawing.Size(100, 20);
            this.txtMemoryId.TabIndex = 5;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(95, 435);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1215, 172);
            this.txtLog.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1198, 244);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "اتصال";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtTins
            // 
            this.txtTins.Location = new System.Drawing.Point(146, 43);
            this.txtTins.Name = "txtTins";
            this.txtTins.Size = new System.Drawing.Size(100, 20);
            this.txtTins.TabIndex = 8;
            // 
            // txtTinb
            // 
            this.txtTinb.Location = new System.Drawing.Point(146, 86);
            this.txtTinb.Name = "txtTinb";
            this.txtTinb.Size = new System.Drawing.Size(100, 20);
            this.txtTinb.TabIndex = 9;
            // 
            // txtTdis
            // 
            this.txtTdis.Location = new System.Drawing.Point(146, 129);
            this.txtTdis.Name = "txtTdis";
            this.txtTdis.Size = new System.Drawing.Size(100, 20);
            this.txtTdis.TabIndex = 10;
            // 
            // txtTvam
            // 
            this.txtTvam.Location = new System.Drawing.Point(146, 175);
            this.txtTvam.Name = "txtTvam";
            this.txtTvam.Size = new System.Drawing.Size(100, 20);
            this.txtTvam.TabIndex = 11;
            // 
            // txtTbill
            // 
            this.txtTbill.Location = new System.Drawing.Point(146, 219);
            this.txtTbill.Name = "txtTbill";
            this.txtTbill.Size = new System.Drawing.Size(100, 20);
            this.txtTbill.TabIndex = 12;
            // 
            // txtSetm
            // 
            this.txtSetm.Location = new System.Drawing.Point(146, 265);
            this.txtSetm.Name = "txtSetm";
            this.txtSetm.Size = new System.Drawing.Size(100, 20);
            this.txtSetm.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "کد اقتصادی فروشنده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "کد اقتصادی خریدار";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "جمع کل تخفیف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "مالیات بر ارزش افزوده";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "مبلغ کل فاکتور";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "نوع پرداخت";
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sstid,
            this.sstt,
            this.mu,
            this.am,
            this.fee,
            this.vam,
            this.tsstam});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.Location = new System.Drawing.Point(358, 27);
            this.dgvItems.Name = "dgvItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.Size = new System.Drawing.Size(745, 258);
            this.dgvItems.TabIndex = 20;
            // 
            // sstid
            // 
            this.sstid.HeaderText = "شناسه کالا/خدمت";
            this.sstid.Name = "sstid";
            // 
            // sstt
            // 
            this.sstt.HeaderText = "عنوان کالا/خدمت";
            this.sstt.Name = "sstt";
            // 
            // mu
            // 
            this.mu.HeaderText = "واحد اندازه‌گیری";
            this.mu.Name = "mu";
            // 
            // am
            // 
            this.am.HeaderText = "تعداد";
            this.am.Name = "am";
            // 
            // fee
            // 
            this.fee.HeaderText = "مبلغ واحد";
            this.fee.Name = "fee";
            // 
            // vam
            // 
            this.vam.HeaderText = "مالیات این ردیف";
            this.vam.Name = "vam";
            // 
            // tsstam
            // 
            this.tsstam.HeaderText = "مبلغ کل این ردیف";
            this.tsstam.Name = "tsstam";
            // 
            // btnSendInvoice
            // 
            this.btnSendInvoice.Location = new System.Drawing.Point(617, 343);
            this.btnSendInvoice.Name = "btnSendInvoice";
            this.btnSendInvoice.Size = new System.Drawing.Size(133, 23);
            this.btnSendInvoice.TabIndex = 21;
            this.btnSendInvoice.Text = "ارسال صورتحساب";
            this.btnSendInvoice.UseVisualStyleBackColor = true;
            this.btnSendInvoice.Click += new System.EventHandler(this.btnSendInvoice_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(862, 342);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(151, 23);
            this.btnCheckStatus.TabIndex = 22;
            this.btnCheckStatus.Text = "بررسی وضعیت صورتحساب";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // btnBrowseCert
            // 
            this.btnBrowseCert.Location = new System.Drawing.Point(1289, 88);
            this.btnBrowseCert.Name = "btnBrowseCert";
            this.btnBrowseCert.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCert.TabIndex = 23;
            this.btnBrowseCert.Text = "انتخاب";
            this.btnBrowseCert.UseVisualStyleBackColor = true;
            this.btnBrowseCert.Click += new System.EventHandler(this.btnBrowseCert_Click);
            // 
            // btnBrowseKey
            // 
            this.btnBrowseKey.Location = new System.Drawing.Point(1289, 126);
            this.btnBrowseKey.Name = "btnBrowseKey";
            this.btnBrowseKey.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseKey.TabIndex = 24;
            this.btnBrowseKey.Text = "انتخاب";
            this.btnBrowseKey.UseVisualStyleBackColor = true;
            this.btnBrowseKey.Click += new System.EventHandler(this.btnBrowseKey_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1451, 790);
            this.Controls.Add(this.btnBrowseKey);
            this.Controls.Add(this.btnBrowseCert);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.btnSendInvoice);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSetm);
            this.Controls.Add(this.txtTbill);
            this.Controls.Add(this.txtTvam);
            this.Controls.Add(this.txtTdis);
            this.Controls.Add(this.txtTinb);
            this.Controls.Add(this.txtTins);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtMemoryId);
            this.Controls.Add(this.txtKeyPath);
            this.Controls.Add(this.txtCertPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "سامانه مودیان";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCertPath;
        private System.Windows.Forms.TextBox txtKeyPath;
        private System.Windows.Forms.TextBox txtMemoryId;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtTins;
        private System.Windows.Forms.TextBox txtTinb;
        private System.Windows.Forms.TextBox txtTdis;
        private System.Windows.Forms.TextBox txtTvam;
        private System.Windows.Forms.TextBox txtTbill;
        private System.Windows.Forms.TextBox txtSetm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn am;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn vam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsstam;
        private System.Windows.Forms.Button btnSendInvoice;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnBrowseCert;
        private System.Windows.Forms.Button btnBrowseKey;
    }
}

