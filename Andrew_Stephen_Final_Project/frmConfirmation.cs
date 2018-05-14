using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andrew_Stephen_Final_Project
{
    public partial class frmConfirmation : Form
    {
       

        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            lstOrderInProgress.Items.Clear();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            gbxPaymentInfo.Visible = true;  
        }

        private void radCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (radCredit.Checked == true)
            {
                lblCardNum.Visible = true;
                lblMonth.Visible = true;
                lblYear.Visible = true;
                txtCardNum.Visible = true;
                cbxMonth.Visible = true;
                cbxYear.Visible = true;
            }
            else
            {
                lblCardNum.Visible = false;
                lblMonth.Visible = false;
                lblYear.Visible = false;
                txtCardNum.Visible = false;
                cbxMonth.Visible = false;
                cbxYear.Visible = false;
            }
        }

    }
}
