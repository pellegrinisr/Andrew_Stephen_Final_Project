namespace Andrew_Stephen_Final_Project
{
    partial class frmReceipt
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
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReceipt
            // 
            this.lstReceipt.BackColor = System.Drawing.Color.Ivory;
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.ItemHeight = 16;
            this.lstReceipt.Location = new System.Drawing.Point(196, 12);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(370, 596);
            this.lstReceipt.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Olive;
            this.btnHide.ForeColor = System.Drawing.Color.Ivory;
            this.btnHide.Location = new System.Drawing.Point(329, 641);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(95, 42);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Close";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(806, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lstReceipt);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstReceipt;
        private System.Windows.Forms.Button btnHide;
    }
}