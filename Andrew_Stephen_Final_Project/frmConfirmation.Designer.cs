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
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.gbxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.gbxPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrderInProgress
            // 
            this.lstOrderInProgress.FormattingEnabled = true;
            this.lstOrderInProgress.ItemHeight = 16;
            this.lstOrderInProgress.Location = new System.Drawing.Point(31, 40);
            this.lstOrderInProgress.Name = "lstOrderInProgress";
            this.lstOrderInProgress.Size = new System.Drawing.Size(417, 628);
            this.lstOrderInProgress.TabIndex = 0;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(534, 83);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(106, 54);
            this.btnEditOrder.TabIndex = 1;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(686, 82);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(106, 57);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Enter Payment";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
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
            this.gbxPaymentInfo.Location = new System.Drawing.Point(521, 241);
            this.gbxPaymentInfo.Name = "gbxPaymentInfo";
            this.gbxPaymentInfo.Size = new System.Drawing.Size(400, 411);
            this.gbxPaymentInfo.TabIndex = 3;
            this.gbxPaymentInfo.TabStop = false;
            this.gbxPaymentInfo.Text = "Payment Info";
            this.gbxPaymentInfo.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(247, 40);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(92, 37);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(152, 195);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(196, 22);
            this.txtCardNum.TabIndex = 8;
            this.txtCardNum.Visible = false;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(31, 193);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(96, 17);
            this.lblCardNum.TabIndex = 7;
            this.lblCardNum.Text = "Card Number:";
            this.lblCardNum.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(220, 245);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(41, 245);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(47, 17);
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
            this.cbxYear.Location = new System.Drawing.Point(218, 285);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 24);
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
            this.cbxMonth.Location = new System.Drawing.Point(44, 285);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(121, 24);
            this.cbxMonth.TabIndex = 2;
            this.cbxMonth.Visible = false;
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(62, 141);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(103, 21);
            this.radCredit.TabIndex = 1;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit/Debit";
            this.radCredit.UseVisualStyleBackColor = true;
            this.radCredit.CheckedChanged += new System.EventHandler(this.radCredit_CheckedChanged);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(62, 103);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(61, 21);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(56, 50);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 17);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Tip:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(103, 47);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 22);
            this.txtTip.TabIndex = 5;
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 680);
            this.Controls.Add(this.gbxPaymentInfo);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.lstOrderInProgress);
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.gbxPaymentInfo.ResumeLayout(false);
            this.gbxPaymentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstOrderInProgress;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnCheckOut;
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
    }
}