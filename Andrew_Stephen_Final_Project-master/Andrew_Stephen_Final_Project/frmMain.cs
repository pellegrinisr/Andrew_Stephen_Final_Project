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
        //private int orderNum = STARTING_ORDER;
        public double subtotal;
        public double salestax;
        public static double total;
        public Order newOrder = new Order();
        

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
        //beverage prices
        private const double COKE = 1.99;
        private const double SPRITE = 1.99;
        private const double WHITE = 7.99;
        private const double RED = 7.99;
        //for the order #
        private const int STARTING_ORDER = 1000;
        public static int countOrderNum = 0;   
        // for the order number
        private int initialOrderNum = 0;
        //sales tax rate
        private const double TAX_RATE = 0.095;
        public frmMain()
        {
            InitializeComponent();
        }

        //event handler
        //form main load event
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            infile = File.OpenText("currentOrderNumber.txt");
            lblTimer.Text = DateTime.Now.ToString();
            string line = infile.ReadLine();
            int.TryParse(line, out int lineInt);
            if (lineInt == 0)
                lblReceipt.Text = STARTING_ORDER.ToString();
            else
            {
                this.lblReceipt.Text = line;
                initialOrderNum = int.Parse(lblReceipt.Text);
            }
            //close the file
            infile.Close();
            splashWindow.ShowDialog();
            
        }

        //event handler for checkout button
        //opens frmConfirmation
        private void btnPay_Click(object sender, EventArgs e)
        {
            btnOk.Visible = true;
            btnCancel.Visible = true;
            MessageBox.Show("Are you sure you want to pay your bill?\nClick Confirm in the payment box to pay.");         
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
            if (chkLasagna.Checked == true)
                cbxLasagnaQuant.Visible = true;
            else
                cbxLasagnaQuant.Visible = false;
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
        //event handler
        //show/hide coke quantity selector control
        private void chkCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoke.Checked == true)
                nudCokeQuant.Visible = true;
            else
                nudCokeQuant.Visible = false;
        }
        //event handler
        //show/hide sprite quantity selector control
        private void chkSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSprite.Checked == true)
                nudSpriteQuant.Visible = true;
            else
                nudSpriteQuant.Visible = false;
        }
        //event handler
        //show/hide red wine quantity selector
        private void chkRed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRed.Checked == true)
                nudRedQuant.Visible = true;
            else
                nudRedQuant.Visible = false;
        }
        //evengt handler
        //show/hide the white wine quantity selector
        private void chkWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhite.Checked == true)
                nudWhiteQuant.Visible = true;
            else
                nudWhiteQuant.Visible = false;
        }
        //function
        //calculate the total price of each food item (price x quantity)
        // and store the value in an array
        //add items and their respective prices to the list box

        private void btnBuildOrder_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            subtotal = 0.0;
            //reset the array
            int countArrayIndex = 0;
            //newOrder.OrderNumber = STARTING_ORDER + countOrderNum;
            lstMainFormOrderItems.Items.Clear();
           
            if (chkSpaghetti.Checked == true)
            {
                if (cbxSpaghettiQuant.SelectedIndex == -1)
                    isValid = false;
                else
                { //create a new instance of food
                    Food spaghetti = new Food();
                    spaghetti.Name = chkSpaghetti.Text;
                    spaghetti.Quantity = int.Parse(cbxSpaghettiQuant.SelectedItem.ToString());
                    spaghetti.Price = SPAGHETTI;

                    subtotal += SPAGHETTI * spaghetti.Quantity;
                    newOrder.FoodArray[countArrayIndex] = spaghetti;
                    countArrayIndex++;
                    
                }
            }

            if (chkLinguini.Checked == true)
            {
                if (cbxLinguiniQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food linguini = new Food();
                    linguini.Name = chkLinguini.Text;
                    linguini.Quantity = int.Parse(cbxLinguiniQuant.SelectedItem.ToString());
                    linguini.Price = LINGUINI;
                    subtotal += LINGUINI * linguini.Quantity;
                    newOrder.FoodArray[countArrayIndex] = linguini;
                    countArrayIndex++;
                }
            }

            if (chkLasagna.Checked == true)
            {
                if (cbxLasagnaQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food lasagna = new Food();
                    lasagna.Name = chkLasagna.Text;
                    lasagna.Quantity = int.Parse(cbxLasagnaQuant.SelectedItem.ToString());
                    lasagna.Price = LASAGNA;
                    subtotal += LASAGNA * lasagna.Quantity;
                    newOrder.FoodArray[countArrayIndex] = lasagna;
                    countArrayIndex++;
                }
            }

            if (chkRavioli.Checked == true)
            {
                if (cbxRavioliQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food ravioli = new Food();
                    ravioli.Name = chkRavioli.Text;
                    ravioli.Quantity = int.Parse(cbxRavioliQuant.SelectedItem.ToString());
                    ravioli.Price = RAVIOLI;
                    subtotal += RAVIOLI * ravioli.Quantity;
                    newOrder.FoodArray[countArrayIndex] = ravioli;
                    countArrayIndex++;
                }

            }
            if (chkPenne.Checked == true)
            {
                if (cbxPenneQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food penne = new Food();
                    penne.Name = chkPenne.Text;
                    penne.Price = PENNE;
                    penne.Quantity = int.Parse(cbxPenneQuant.SelectedItem.ToString());
                    subtotal += PENNE * penne.Quantity;
                    newOrder.FoodArray[countArrayIndex] = penne;
                    countArrayIndex++;
                }

            }
            if (chkCarbonara.Checked == true)
            {
                if (cbxCarbonaraQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food carbonara = new Food();
                    carbonara.Name = chkCarbonara.Text;
                    carbonara.Price = CARBONARA;
                    carbonara.Quantity = int.Parse(cbxCarbonaraQuant.SelectedItem.ToString());
                    subtotal += carbonara.Quantity * CARBONARA;
                    newOrder.FoodArray[countArrayIndex] = carbonara;
                    countArrayIndex++;
                }
            }
            
            if (chkPicatta.Checked == true)
            {
                if (cbxPicattaQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food picatta = new Food();
                    picatta.Name = chkPicatta.Text;
                    picatta.Price = PICATTA;
                    picatta.Quantity = int.Parse(cbxPicattaQuant.SelectedItem.ToString());
                    subtotal += picatta.Quantity * PICATTA;
                    newOrder.FoodArray[countArrayIndex] = picatta;
                    countArrayIndex++;
                }
            }

            if (chkMarsala.Checked == true)
            {
                if (cbxMarsalaQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food marsala = new Food();
                    marsala.Name = chkMarsala.Text;
                    marsala.Quantity = int.Parse(cbxMarsalaQuant.SelectedItem.ToString());
                    marsala.Price = MARSALA;
                    subtotal += MARSALA * marsala.Quantity;
                    newOrder.FoodArray[countArrayIndex] = marsala;
                    countArrayIndex++;
                }
            }

            if (chkCioppino.Checked == true)
            {
                if (cbxCioppinoQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food cioppino = new Food();
                    cioppino.Name = chkCioppino.Text;
                    cioppino.Quantity = int.Parse(cbxCioppinoQuant.SelectedItem.ToString());
                    cioppino.Price = CIOPPINO;
                    subtotal += CIOPPINO * cioppino.Quantity;
                    newOrder.FoodArray[countArrayIndex] = cioppino;
                    countArrayIndex++;
                }
            }

            if (chkPizza.Checked == true)
            {
                if (cbxPizzaQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food pizza = new Food();
                    pizza.Price = PIZZA;
                    pizza.Quantity = int.Parse(cbxPizzaQuant.SelectedItem.ToString());
                    pizza.Name = chkPizza.Text;
                    subtotal += PIZZA * pizza.Quantity;
                    newOrder.FoodArray[countArrayIndex] = pizza;
                    countArrayIndex++;
                }
            }

            if (chkHouseSalad.Checked == true)
            {
                if (cbxHouseQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food houseSalad = new Food();
                    houseSalad.Name = chkHouseSalad.Text;
                    houseSalad.Quantity = int.Parse(cbxHouseQuant.SelectedItem.ToString());
                    houseSalad.Price = HOUSE;
                    subtotal += HOUSE * houseSalad.Quantity;
                    newOrder.FoodArray[countArrayIndex] = houseSalad;
                    countArrayIndex++;
                }
            }

            if (chkCaesar.Checked == true)
            {
                if (cbxCaesarQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food caesar = new Food();
                    caesar.Name = chkCaesar.Text;
                    caesar.Quantity = int.Parse(cbxCaesarQuant.SelectedItem.ToString());
                    caesar.Price = CAESAR;
                    subtotal += CAESAR * caesar.Quantity;
                    newOrder.FoodArray[countArrayIndex] = caesar;
                    countArrayIndex++;
                }
            }

            if (chkSpringGreens.Checked == true)
            {
                if (cbxSpringQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food springGreens = new Food();
                    springGreens.Name = chkSpringGreens.Text;
                    springGreens.Quantity = int.Parse(cbxSpringQuant.SelectedItem.ToString());
                    springGreens.Price = SPRING;
                    subtotal += SPRING * springGreens.Quantity;
                    newOrder.FoodArray[countArrayIndex] = springGreens;
                    countArrayIndex++;
                }
            }

            if (chkCaprese.Checked == true)
            {
                if (cbxCapreseQuant.SelectedIndex == -1)
                    isValid = false;
                else
                {
                    Food caprese = new Food();
                    caprese.Name = chkCaprese.Text;
                    caprese.Quantity = int.Parse(cbxCapreseQuant.SelectedItem.ToString());
                    caprese.Price = CAPRESE;
                    subtotal += CAPRESE * caprese.Quantity;
                    newOrder.FoodArray[countArrayIndex] = caprese;
                    countArrayIndex++;
                }
            }

            if (chkCoke.Checked == true)
            {
                Food coke = new Food();
                coke.Name = chkCoke.Text;
                coke.Quantity = int.Parse(nudCokeQuant.Value.ToString());
                coke.Price = COKE;
                subtotal += COKE * coke.Quantity;
                newOrder.FoodArray[countArrayIndex] = coke;
                countArrayIndex++;
            }

            if (chkSprite.Checked == true)
            {
                Food sprite = new Food();
                sprite.Name = chkSprite.Text;
                sprite.Quantity = int.Parse(nudSpriteQuant.Value.ToString());
                sprite.Price = SPRITE;
                subtotal += sprite.Quantity * SPRITE;
                newOrder.FoodArray[countArrayIndex] = sprite;
                countArrayIndex++;
            }

            if (chkRed.Checked == true)
            {
                Food redWine = new Food();
                redWine.Name = chkRed.Text;
                redWine.Quantity = int.Parse(nudRedQuant.Value.ToString());
                redWine.Price = RED;
                subtotal += redWine.Quantity * RED;
                newOrder.FoodArray[countArrayIndex] = redWine;
                countArrayIndex++;
            }

            if (chkWhite.Checked == true)
            {
                Food whiteWine = new Food();
                whiteWine.Price = WHITE;
                whiteWine.Quantity = int.Parse(nudWhiteQuant.Value.ToString());
                whiteWine.Name = chkWhite.Text;
                subtotal += WHITE * whiteWine.Quantity;
                newOrder.FoodArray[countArrayIndex] = whiteWine;
                countArrayIndex++;
            }

            if (isValid == false)
                MessageBox.Show("Please select a quantity for each item.");
            else
            {
                //show the frmConfirmation object with the filled in list box             
                for (int i = 0; i < countArrayIndex; i++)
                    lstMainFormOrderItems.Items.Add(newOrder.FoodArray[i].ToString());
                //If an item isn't selected
                if (lstMainFormOrderItems.Items.Count == 0)
                    MessageBox.Show("You must select at least one item to continue.");
                else
                {
                    btnPay.Visible = true;
                    btnReset.Visible = false;
                    MessageBox.Show("Your order has been sent to the kitchen.");
                    btnBuildOrder.Text = "Update Order";
                }          
            }
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
                btnEditOrder.Visible = false;
                gbxEntree.Visible = true;
                gbxSalad.Visible = true;
                gbxDrinks.Visible = true;
                btnBuildOrder.Visible = true;
                btnReset.Visible = true;
                lstMainFormOrderItems.Visible = true;
                gbxPay.Visible = true;
                //figure out the order number
                if (initialOrderNum == 0)
                {
                    lblReceipt.Text = STARTING_ORDER.ToString();
                    initialOrderNum = STARTING_ORDER;
                    newOrder.OrderNumber = initialOrderNum;
                }
                else
                {
                    initialOrderNum++;
                    newOrder.OrderNumber = initialOrderNum;
                    lblReceipt.Text = initialOrderNum.ToString();
                    lblReceipt.Visible = true;
                }
            countOrderNum++;
            }
        }
        //event handler for edit order button
        //will allow the user to edit a previously submitted order
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
                btnNewOrder.Visible = false;
                txtOrderNum.Visible = true;
                lblOrderNum.Visible = true;
                btnSearchOrder.Visible = true;
                btnClose.Visible = true;
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
                        lstMainFormOrderItems.Items.Add(infile.ReadLine());
                    }
                    lstMainFormOrderItems.Visible = true;
                }
                catch
                {
                    MessageBox.Show("File does not exist.");
                }
            }
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radYes.Checked == true)
            {
                pnlAlcohol.Visible = true;
                MessageBox.Show("Be prepared to show ID.");
            }
            else
                pnlAlcohol.Visible = false;
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            initialOrderNum--;
        }

        public void reset()
        {
            //clear the array
            for (int i = 0; i < newOrder.FoodArray.Length; i++)
            {
                newOrder.FoodArray[i] = null;
            }
            //clear the list box
            lstMainFormOrderItems.Items.Clear();
            //hide the list box
            lstMainFormOrderItems.Visible = false;
            //entree section
            chkSpaghetti.Checked = false;
            chkLinguini.Checked = false;
            chkLasagna.Checked = false;
            chkRavioli.Checked = false;
            chkPenne.Checked = false;
            chkCarbonara.Checked = false;
            chkPicatta.Checked = false;
            chkMarsala.Checked = false;
            chkCioppino.Checked = false;
            chkPizza.Checked = false;
            chkHouseSalad.Checked = false;
            chkCaesar.Checked = false;
            chkSpringGreens.Checked = false;
            chkCaprese.Checked = false;
            chkCoke.Checked = false;
            chkSprite.Checked = false;
            chkRed.Checked = false;
            chkWhite.Checked = false;
            cbxSpaghettiQuant.SelectedItem = null;
            cbxLinguiniQuant.SelectedItem = null;
            cbxLasagnaQuant.SelectedItem = null;
            cbxRavioliQuant.SelectedItem = null;
            cbxPenneQuant.SelectedItem = null;
            cbxCarbonaraQuant.SelectedItem = null;
            cbxPicattaQuant.SelectedItem = null;
            cbxMarsalaQuant.SelectedItem = null;
            cbxCioppinoQuant.SelectedItem = null;
            cbxPizzaQuant.SelectedItem = null;
            cbxHouseQuant.SelectedItem = null;
            cbxCaesarQuant.SelectedItem = null;
            cbxSpringQuant.SelectedItem = null;
            cbxCapreseQuant.SelectedItem = null;
            nudCokeQuant.Value = 1;
            nudCokeQuant.Visible = false;
            nudSpriteQuant.Value = 1;
            nudSpriteQuant.Visible = false;
            nudRedQuant.Value = 1;
            nudRedQuant.Visible = false;
            nudWhiteQuant.Value = 1;
            nudWhiteQuant.Visible = false;
            radNo.Checked = true;
            gbxEntree.Visible = false;
            gbxSalad.Visible = false;
            gbxDrinks.Visible = false;
            btnBuildOrder.Visible = false;
            btnReset.Visible = false;
            btnPay.Visible = false;
            btnSearchOrder.Visible = false;
            btnNewOrder.Visible = true;
            btnEditOrder.Visible = true;
            lblReceipt.Text = "";
            lblOrderNum.Visible = false;
            txtOrderNum.Text = "";
            txtOrderNum.Visible = false;
            txtName.Text = "";
            gbxPay.Visible = false;
            btnPay.Visible = false;           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNewOrder.Visible = true;
            lstMainFormOrderItems.Visible = false;
            lstMainFormOrderItems.Items.Clear();
            btnSearchOrder.Visible = false;
            btnClose.Visible = false;
            txtOrderNum.Text = "";
            txtOrderNum.Visible = false;
            lblOrderNum.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnOk.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            confrimForm.lblOrderNum.Text = newOrder.OrderNumber.ToString();
            if (!(lstMainFormOrderItems.Items.Count == 0))
            {
                salestax = 0;
                total = 0;
                foreach (string lineItem in lstMainFormOrderItems.Items)
                {
                    confrimForm.lstOrderInProgress.Items.Add(lineItem);
                }
                //add the subtotal to the list box on frmConfirmation
                confrimForm.lstOrderInProgress.Items.Add("Subtotal:\t\t\t" + subtotal.ToString("C"));
                //calculate the sales tax
                salestax = subtotal * TAX_RATE;
                //add the sales tax to the list box on frmConfirmation
                confrimForm.lstOrderInProgress.Items.Add("Tax:\t\t\t" + salestax.ToString("C"));
                //calculate the total price
                total = subtotal + salestax;
                //add the total to the listbox on frmConfirmation
                confrimForm.lstOrderInProgress.Items.Add("Total:\t\t\t" + total.ToString("C"));

                btnPay.Visible = false;
                int i = 0;
                while (i < newOrder.FoodArray.Length && newOrder.FoodArray[i] != null)
                {
                    newOrder.FoodArray[i] = null;
                }
                gbxEntree.Visible = false;
                gbxSalad.Visible = false;
                gbxDrinks.Visible = false;
                btnPay.Visible = false;
                btnOk.Visible = false;
                btnCancel.Visible = false;
                lblReceipt.Visible = false;
                btnBuildOrder.Text = "Place Order";
                reset();
                confrimForm.ShowDialog();
            }
        }
    }
}