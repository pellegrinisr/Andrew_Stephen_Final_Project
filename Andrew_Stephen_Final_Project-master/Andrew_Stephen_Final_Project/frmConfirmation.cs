using System;
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

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            /*
            double newtotal;
            lstOrderInProgress.Items.Add("Tip:\t\t\t$" + txtTip.Text);
            double.TryParse(txtTip.Text, out double doubleValue);
            if (doubleValue == 0)
                newtotal = frmMain.total;
            else
                newtotal = double.Parse(txtTip.Text) + frmMain.total;
            lstOrderInProgress.Items.Add("New Total:\t\t" + newtotal.ToString("C"));
            */
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //flag values
            bool isValid = true;
            bool tipValid = true;
            string filepath = lblOrderNum.Text + ".txt";
            //check if no payment method selected
            if (radCash.Checked == false && radCredit.Checked == false)
                MessageBox.Show("Please choose a payment method.");
            //user selected a payment method
            else
            {
                //check if user selected credit
                //then check card num, exp. month, 
                //and exp. year
                if (radCredit.Checked == true)
                {
                    if (txtCardNum.Text == "")
                        isValid = false;
                    if (cbxMonth.SelectedIndex == -1)
                        isValid = false;
                    if (cbxYear.SelectedIndex == -1)
                        isValid = false;
                }
                //error checking for tip text box
                //check if tip box can be parsed as double
                //display a message box
                if (!double.TryParse(txtTip.Text, out double isDouble))
                {
                    //isValid = false;
                    MessageBox.Show("Tip value must be a number.\n" +
                        "To leave no tip, enter 0.");
                }
                //check if tip box value is less than 0
                //display a message box 
                else if (double.Parse(txtTip.Text) < 0)
                {
                    //isValid = false;
                    MessageBox.Show("Tip value cannot be negative.");
                }
                //show message box if payment info invalid
                else if (!isValid)
                    MessageBox.Show("Please correct errors in payment info.");
                //all user input is valid
                else
                {
                    frmReceipt receiptForm = new frmReceipt();
                    //Add tip
                    double newtotal;
                    lstOrderInProgress.Items.Add("Tip:\t\t\t$" + txtTip.Text);
                    double.TryParse(txtTip.Text, out double doubleValue);
                    if (doubleValue == 0)
                        newtotal = frmMain.total;
                    else
                        newtotal = double.Parse(txtTip.Text) + frmMain.total;
                    lstOrderInProgress.Items.Add("Grand Total:\t\t" + newtotal.ToString("C"));
                    //add the method of payment
                    if (radCash.Checked == true)
                        lstOrderInProgress.Items.Add("Method of Payment:\t\t" + radCash.Text);
                    else
                        lstOrderInProgress.Items.Add("Method of Payment:\t\t" + radCredit.Text);
                    //write to file
                    //hide the confirmation form
                    outfile = File.CreateText(filepath);

                    foreach (string s in lstOrderInProgress.Items)
                    {
                        receiptForm.lstReceipt.Items.Add(s);
                        outfile.WriteLine(s);
                    }
                    outfile.Close();
                    filepath = "currentOrderNumber.txt";
                    outfile = File.CreateText(filepath);
                    outfile.Write(lblOrderNum.Text);
                    outfile.Close();



                    lstOrderInProgress.Items.Clear();
                    txtTip.Text = "";
                    txtCardNum.Text = "";
                    MessageBox.Show("Thank you for coming. We hope you enjoyed your meal.\nThe waiter will come by shortly with your receipt.");

                    this.Hide();
                    receiptForm.ShowDialog();
                }
            }         
        }

    }
 }

