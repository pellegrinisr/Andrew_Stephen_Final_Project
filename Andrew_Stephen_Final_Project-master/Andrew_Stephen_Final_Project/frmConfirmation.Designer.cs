namespace Andrew_Stephen_Final_Project
{
    partial class frmConfirmation
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
            this.lstOrderInProgress = new System.Windows.Forms.ListBox();
            this.gbxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblReceiptNum = new System.Windows.Forms.Label();
            this.gbxPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrderInProgress
            // 
            this.lstOrderInProgress.FormattingEnabled = true;
            this.lstOrderInProgress.ItemHeight = 16;
            this.lstOrderInProgress.Location = new System.Drawing.Point(35, 40);
            this.lstOrderInProgress.Name = "lstOrderInProgress";
            this.lstOrderInProgress.Size = new System.Drawing.Size(469, 628);
            this.lstOrderInProgress.TabIndex = 0;
            // 
            // gbxPaymentInfo
            // 
            this.gbxPaymentInfo.Controls.Add(this.txtTip);
            this.gbxPaymentInfo.Controls.Add(this.lblTip);
            this.gbxPaymentInfo.Controls.Add(this.btnConfirm);
            this.gbxPaymentInfo.Controls.Add(this.txtCardNum);
            this.gbxPaymentInfo.Controls.Add(this.lblCardNum);
            this.gbxPaymentInfo.Controls.Add(this.lblYear);
            this.gbxPaymentInfo.Controls.Add(this.lblMonth);
            this.gbxPaymentInfo.Controls.Add(this.cbxYear);
            this.gbxPaymentInfo.Controls.Add(this.cbxMonth);
            this.gbxPaymentInfo.Controls.Add(this.radCredit);
            this.gbxPaymentInfo.Controls.Add(this.radCash);
            this.gbxPaymentInfo.Location = new System.Drawing.Point(570, 108);
            this.gbxPaymentInfo.Name = "gbxPaymentInfo";
            this.gbxPaymentInfo.Size = new System.Drawing.Size(414, 308);
            this.gbxPaymentInfo.TabIndex = 3;
            this.gbxPaymentInfo.TabStop = false;
            this.gbxPaymentInfo.Text = "Payment Info";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(101, 56);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(112, 22);
            this.txtTip.TabIndex = 5;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(48, 59);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(36, 17);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Tip:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(264, 236);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(128, 36);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Make Payment";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(172, 164);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(220, 22);
            this.txtCardNum.TabIndex = 8;
            this.txtCardNum.Visible = false;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(48, 164);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(108, 17);
            this.lblCardNum.TabIndex = 7;
            this.lblCardNum.Text = "Card Number:";
            this.lblCardNum.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(147, 208);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(48, 208);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 17);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month";
            this.lblMonth.Visible = false;
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2025",
            "2026"});
            this.cbxYear.Location = new System.Drawing.Point(145, 248);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(73, 24);
            this.cbxYear.TabIndex = 3;
            this.cbxYear.Visible = false;
            // 
            // cbxMonth
            // 
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cbxMonth.Location = new System.Drawing.Point(51, 248);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(73, 24);
            this.cbxMonth.TabIndex = 2;
            this.cbxMonth.Visible = false;
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(51, 123);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(115, 21);
            this.radCredit.TabIndex = 1;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit/Debit";
            this.radCredit.UseVisualStyleBackColor = true;
            this.radCredit.CheckedChanged += new System.EventHandler(this.radCredit_CheckedChanged);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(51, 97);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(65, 21);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderNum.Location = new System.Drawing.Point(650, 62);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(2, 19);
            this.lblOrderNum.TabIndex = 4;
            // 
            // lblReceiptNum
            // 
            this.lblReceiptNum.AutoSize = true;
            this.lblReceiptNum.Location = new System.Drawing.Point(567, 62);
            this.lblReceiptNum.Name = "lblReceiptNum";
            this.lblReceiptNum.Size = new System.Drawing.Size(77, 17);
            this.lblReceiptNum.TabIndex = 5;
            this.lblReceiptNum.Text = "Receipt #";
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 680);
            this.ControlBox = false;
            this.Controls.Add(this.lblReceiptNum);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.gbxPaymentInfo);
            this.Controls.Add(this.lstOrderInProgress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.Load += new System.EventHandler(this.frmConfirmation_Load);
            this.gbxPaymentInfo.ResumeLayout(false);
            this.gbxPaymentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstOrderInProgress;
        private System.Windows.Forms.GroupBox gbxPaymentInfo;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTip;
        public System.Windows.Forms.TextBox txtTip;
        public System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblReceiptNum;
    }
}