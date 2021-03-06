﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Andrew_Stephen_Final_Project
{
    public partial class frmConfirmation : Form
    {
        StreamWriter outfile;

        public frmConfirmation()
        {
            InitializeComponent();
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

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            double newtotal;
            lstOrderInProgress.Items.Add("Tip:\t\t\t$" + txtTip.Text);
            double.TryParse(txtTip.Text, out double doubleValue);
            if (doubleValue == 0)
                newtotal = frmMain.total;
            else
                newtotal = double.Parse(txtTip.Text) + frmMain.total;
            lstOrderInProgress.Items.Add("New Total:\t\t" + newtotal.ToString("C"));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string filepath = lblOrderNum.Text + ".txt";
            if (radCredit.Checked == true)
            {
                if (txtCardNum.Text == "")
                    isValid = false;
                if (cbxMonth.SelectedIndex == -1)
                    isValid = false;
                if (cbxYear.SelectedIndex == -1)
                    isValid = false;
            }
            if (!isValid)
                MessageBox.Show("Please correct errors in payment info.");
            else
            {
                //write to file
                //hide the confirmation form
                
                outfile = File.CreateText(filepath);

                foreach (string s in lstOrderInProgress.Items)
                {
                    outfile.WriteLine(s);
                }

                outfile.Close();
                filepath = "currentOrderNumber.txt";
                outfile = File.CreateText(filepath);
                outfile.Write(lblOrderNum.Text);
                outfile.Close();
                lstOrderInProgress.Items.Clear();
                this.Hide();
            }

            
        }
     }
 }

