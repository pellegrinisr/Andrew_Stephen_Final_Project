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
    public partial class frmMain : Form
    {
        //global variables
        private frmConfirmation confrimForm = new frmConfirmation();
        private frmSplash splashWindow = new frmSplash();
        private StreamReader infile;
        private StreamWriter outfile;
        private int orderNum = STARTING_ORDER;
        

        //global constants
        //Entree prices
        private const double SPAGHETTI = 9.99;
        private const double LINGUINI = 10.99;
        private const double LASAGNA = 11.99;
        private const double RAVIOLI = 13.45;
        private const double PENNE = 15.95;
        private const double CARBONARA = 16.99;
        private const double PICATTA = 18.99;
        private const double MARSALA = 24.75;
        private const double CIOPPINO = 29.99;
        private const double PIZZA = 17.55;
        //salad prices
        private const double HOUSE = 5.99;
        private const double CAESAR = 7.95;
        private const double SPRING = 8.45;
        private const double CAPRESE = 9.95;

        //for the order #
        private const int STARTING_ORDER = 1000;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
            splashWindow.ShowDialog();
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
        }

        //event handler for Spaghetti check box
        //show/hide the spaghetti quantity text box
        private void chkSpaghetti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpaghetti.Checked == true)
                cbxSpaghettiQuant.Visible = true;
            else
                cbxSpaghettiQuant.Visible = false;
            
        }

        //event handler for linguini check box
        //show/hide the linguini quantity text box
        private void chkLinguini_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLinguini.Checked == true)
                cbxLinguiniQuant.Visible = true;
            else
                cbxLinguiniQuant.Visible = false;
        }

        //event handler for lasangna check box
        //show/hide the lasagna quantity text box
        private void chkLasagna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLinguini.Checked == true)
                cbxLasagnaQuant.Visible = true;
            else
                cbxLasagnaQuant.Visible = true;
        }

        //event handler for ravioli check box
        //show/hide the ravioli quantity text box
        private void chkRavioli_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRavioli.Checked == true)
                cbxRavioliQuant.Visible = true;
            else
                cbxRavioliQuant.Visible = false;

        }

        //event handler for the penne check box
        //show/hide the penne quantity text box
        private void chkPenne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenne.Checked == true)
                cbxPenneQuant.Visible = true;
            else
                cbxPenneQuant.Visible = false;
        }

        //event handler for the carbonara check box
        //show/hide the carbonara quantity text box
        private void chkCarbonara_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarbonara.Checked == true)
                cbxCarbonaraQuant.Visible = true;
            else
                cbxCarbonaraQuant.Visible = false;
        }

        //event handler for the picatta check box
        //show/hide the picatta quantity text box
        private void chkPicatta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPicatta.Checked == true)
                cbxPicattaQuant.Visible = true;
            else
                cbxPicattaQuant.Visible = false;
        }

        //event handler for the marsala check box
        //show/hide the marsala quantity text box
        private void chkMarsala_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarsala.Checked == true)
                cbxMarsalaQuant.Visible = true;
            else
                cbxMarsalaQuant.Visible = false;
        }

        //event handler for the cioppino check box
        //show/hide the cioppino quantity text box
        private void chkCioppino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCioppino.Checked == true)
                cbxCioppinoQuant.Visible = true;
            else
                cbxCioppinoQuant.Visible = false;
        }

        //event handler for the pizza check box
        //show/hide the pizza quantity text box
        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPizza.Checked == true)
                cbxPizzaQuant.Visible = true;
            else
                cbxPizzaQuant.Visible = false;
        }
        //event handler
        //show/hide house salad quantity
        private void chkHouseSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHouseSalad.Checked == true)
                cbxHouseQuant.Visible = true;
            else
                cbxHouseQuant.Visible = false;
        }
        //event handler
        //show/hide caesar salad quantity
        private void chkCaesar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaesar.Checked == true)
                cbxCaesarQuant.Visible = true;
            else
                cbxCaesarQuant.Visible = false;
        }

        //event handler
        //show/hide spring greens quantity
        private void chkSpringGreens_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpringGreens.Checked == true)
                cbxSpringQuant.Visible = true;
            else
                cbxSpringQuant.Visible = false;
        }

        //event handler
        //show/hide caprese quantity
        private void chkCaprese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaprese.Checked == true)
                cbxCapreseQuant.Visible = true;
            else
                cbxCapreseQuant.Visible = false;
        }

        //function
        //make sure each selected check box has a quantity
        //SO FAR ONLY WORKS FOR ENTREES AND SALADS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        /*
        private bool validation()
        {
            bool isValid = true;
            foreach (Control c in this.gbxEntree.Controls)
            {
                if (c is TextBox && c.Visible == true)
                {
                    //if (c.Name == "txtName");

                     if (c.Text == "")
                    {
                        MessageBox.Show("Please enter quantity for each selected item.");
                        isValid = false;
                    }
                    else if (!int.TryParse(c.Text, out int quantity))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        isValid = false;
                    }
                    else if (quantity < 0)
                    {
                        MessageBox.Show("Quantity must be greater than 0.");
                        isValid = false;
                    }
                }
            }
            foreach (Control c in this.gbxSalad.Controls)
            {
                if (c is TextBox && c.Visible == true)
                {
                    if ()
                    {
                        MessageBox.Show("Please enter quantity for each selected item.");
                        isValid = false;
                    }
                    else if (!int.TryParse(c.Text, out int quantity))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        isValid = false;
                    }
                    else if (quantity < 0)
                    {
                        MessageBox.Show("Quantity must be greater than 0.");
                        isValid = false;
                    }
                }
            }
            
            return isValid;
        }

    */

        //function
        //calculate the total price of each food item (price x quantity)
        // and store the value in an array
        //add items and their respective prices to the list box
        private void btnBuildOrder_Click(object sender, EventArgs e)
        {

            //bool isValid;
            //isValid = validation();
            //MessageBox.Show(isValid.ToString("c"));
            // if (isValid == true)
            //     {
            if (chkSpaghetti.Checked == true)
            {
                //confirmForm.lstOrderInProgress.Items.Add("Spaghetti, Quantity=" + this.txtSpaghettiQuant.Text + ", Price=" + (int.Parse(this.txtSpaghettiQuant.Text) * this.SPAGHETTI));
                lstOrderInProgress.Items.Add("(" + cbxSpaghettiQuant.SelectedItem + ")  " + chkSpaghetti.Text + "   " + SPAGHETTI);
                lstOrderInProgress.Items.Add(int.Parse(cbxSpaghettiQuant.SelectedItem.ToString()) * SPAGHETTI);
                //lstOrderInProgress.Items.Add("Spaghetti, Quantity=" + this.cbxSpaghettiQuant.SelectedItem + ", Price=" + (int.Parse(cbxSpaghettiQuant.SelectedItem.ToString()) * SPAGHETTI));
            }
            if (chkLinguini.Checked == true)
                //lstOrderInProgress.Items.Add("Linguini, Quantity=" + txtLinguiniQuant.Text + ", Price=" + (int.Parse(txtLinguiniQuant.Text) * LINGUINI));
                confrimForm.lstOrderInProgress.Items.Add("Linguini, Quantity=" + cbxLinguiniQuant.SelectedItem + ", Price=" + (int.Parse(cbxLinguiniQuant.SelectedItem.ToString()) * LINGUINI));
            if (chkLasagna.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Lasagna, Quantithy=" + cbxLasagnaQuant.SelectedItem + ", Price=" + (int.Parse(cbxLasagnaQuant.SelectedItem.ToString()) * LASAGNA));
                //lstOrderInProgress.Items.Add("Lasagna, Quantity=" + txtLasagnaQuant.Text + ", Price=" + (int.Parse(txtLasagnaQuant.Text) * LASAGNA));
            if (chkRavioli.Checked == true)  
                confrimForm.lstOrderInProgress.Items.Add("Ravioli, Quantity=" + cbxRavioliQuant.SelectedItem + ", Price=" + (int.Parse(cbxRavioliQuant.SelectedItem.ToString()) * RAVIOLI));
            if (chkPenne.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Penne, Quantity=" + cbxPenneQuant.SelectedItem + ", Price=" + (int.Parse(cbxPenneQuant.SelectedItem.ToString()) * PENNE));
            if (chkCarbonara.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Carbonara, Quantity=" + cbxCarbonaraQuant.SelectedItem + ", Price=" + (int.Parse(cbxCarbonaraQuant.SelectedItem.ToString()) * PENNE));
                //lstOrderInProgress.Items.Add("Carbonara, Quantity=" + txtCarbonaraQuant.Text + ", Price=" + (int.Parse(txtPenneQuant.Text)* PENNE));
            if (chkPicatta.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Picatta, Quantity=" + cbxPicattaQuant.Text + ", Price=" + (int.Parse(cbxPicattaQuant.SelectedItem.ToString()) * PICATTA));
                //lstOrderInProgress.Items.Add("Picatta, Quantity=" + txtPicattaQuant.Text + ", Price=" + (int.Parse(txtPicattaQuant.Text) * PICATTA));
            if (chkMarsala.Checked == true) 
                confrimForm.lstOrderInProgress.Items.Add("Marsala, Quantity=" + cbxMarsalaQuant.Text + ", Price=" + (int.Parse(cbxMarsalaQuant.SelectedItem.ToString()) * MARSALA));
            //lstOrderInProgress.Items.Add("Marsala, Quantity=" + txtMarsalaQuant.Text + ", Price=" + (int.Parse(txtMarsalaQuant.Text)* MARSALA));
            if (chkCioppino.Checked == true)  
                confrimForm.lstOrderInProgress.Items.Add("Cioppino, Quantity=" + cbxCioppinoQuant.SelectedItem + ", Price=" + (int.Parse(cbxCioppinoQuant.SelectedItem.ToString()) * CIOPPINO));
            // lstOrderInProgress.Items.Add("Cioppino, Quantity=" + txtCioppinoQuant.Text + ", Price=" + (int.Parse(txtCarbonaraQuant.Text) * CIOPPINO));
            if (chkPizza.Checked == true) 
                confrimForm.lstOrderInProgress.Items.Add("Pizza, Quantity=" + cbxPizzaQuant.SelectedItem + ", Price=" + (int.Parse(cbxPizzaQuant.SelectedItem.ToString()) * PIZZA));
            // lstOrderInProgress.Items.Add("Pizza, Quantity=" + txtPizzaQuant.Text + ", Price=" + (int.Parse(txtPizzaQuant.Text) * PIZZA));
            if (chkHouseSalad.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("House Salad, Quantity=" + cbxHouseQuant.SelectedItem + ", Price=" + (int.Parse(cbxHouseQuant.SelectedItem.ToString()) * HOUSE));
            //lstOrderInProgress.Items.Add("House Salad, Quantity=" + txtHouseQuant.Text + ", Price=" + (int.Parse(txtHouseQuant.Text) * HOUSE));
            if (chkCaesar.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Caesar Salad, Quantity=" + cbxCaesarQuant.SelectedItem + ", Price= " + (int.Parse(cbxCaesarQuant.SelectedItem.ToString()) * CAESAR));
            // lstOrderInProgress.Items.Add("Caesar Salad, Quantity=" + txtCaesarQuant.Text + ", Price= " + (int.Parse(txtCaesarQuant.Text) * CAESAR));
            if (chkSpringGreens.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Spring Greens, Quantity=" + cbxSpringQuant.SelectedItem + ", Price=" + (int.Parse(cbxSpringQuant.SelectedItem.ToString()) * SPRING));
            // lstOrderInProgress.Items.Add("Spring Greens, Quantity=" + txtSpringQuant.Text + ", Price=" + (int.Parse(txtSpringQuant.Text) * SPRING));
            if (chkCaprese.Checked == true)
                confrimForm.lstOrderInProgress.Items.Add("Caprese, Quantity=" + cbxCapreseQuant.SelectedItem + ", Price=" + (int.Parse(cbxCapreseQuant.SelectedItem.ToString()) * CAPRESE));
            //lstOrderInProgress.Items.Add("Caprese, Quantity=" + txtCapreseQuant.Text + ", Price=" + (int.Parse(txtCapreseQuant.Text) * CAPRESE));

                //show the frmConfirmation object with the filled in list box
                confrimForm.Show();
            //}
            //else
              //  MessageBox.Show("Please fix the errors before continuing.");
        }

        //event handler
        //button to be clicked after entering name
        //will make the rest of the controls on the form visible
        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {
                if (txtName.Text == "")
                    MessageBox.Show("Please enter your name.");
                else
                {
                    gbxEntree.Visible = true;
                    gbxSalad.Visible = true;
                    gbxDrinks.Visible = true;
                    btnBuildOrder.Visible = true;
                    btnPay.Visible = true;
                    btnReset.Visible = true;
                    lstOrderInProgress.Visible = true;
                }
            }

        //event handler for edit order button
        //will allow the user to edit a previously submitted order
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("Please enter your name.");
            else
            {
                txtOrderNum.Visible = true;
                lblOrderNum.Visible = true;
                btnSearchOrder.Visible = true;
            }
        }

        //event handler for search button
        //will search for receipt of previous order
        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderNum.Text == "")
                MessageBox.Show("Please enter an order number.");
            else if (!int.TryParse(txtOrderNum.Text, out int userInput))
                MessageBox.Show("Please enter a valid order number.");
            else
            {
                string filename = txtOrderNum.Text + ".txt";

                try
                {
                    infile = File.OpenText(filename);

                    while (!infile.EndOfStream)
                    {
                        lstOrderInProgress.Items.Add(infile.ReadLine());
                    }
                    lstOrderInProgress.Visible = true;
                }
                catch
                {
                    MessageBox.Show("File does not exist.");
                }
            }
        }

        
    }
}

