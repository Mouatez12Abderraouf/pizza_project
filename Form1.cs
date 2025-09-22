using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // adapt Size Label by user input

        private void upDateSizeResult(object sender, EventArgs e)
        {
            updateTotalPrice(sender, e);

            if (rbSmallPizza.Checked)
            {
                labSizeResult.Text = "Small";
            }
            else if (rbLargePizza.Checked)
            {
                labSizeResult.Text = "Large";
            }
            else if (rbMediumPizza.Checked)
            {
                labSizeResult.Text = "Medium";
            }

            labSizeResult.Visible = true;
        }

        private void rbSmallPizza_CheckedChanged(object sender, EventArgs e)
        {
            upDateSizeResult(sender, e);
        }

        private void rbMediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            upDateSizeResult(sender, e);

        }

        private void rbLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            upDateSizeResult(sender, e);


        }

        // adapt crust type by user input 

        private void updateCrustType(object sender, EventArgs e)
        {
            updateTotalPrice(sender, e);

            if (rbThinPizza.Checked)
            {
                labCrustTypeResult.Text = "Thin";
            }
            else if(rbTuckPizza.Checked)
            {
                labCrustTypeResult.Text = "Tuck";
            }

            labCrustTypeResult.Visible = true;
        }

        private void rbThinPizza_CheckedChanged(object sender, EventArgs e)
        {
            updateCrustType(sender, e);

        }

        private void rbTuckPizza_CheckedChanged(object sender, EventArgs e)
        {
            updateCrustType(sender, e);



        }

        // adapt Answer of user in label (where to eat?)

        private void updateWhereToEat(object sender, EventArgs e)
        {
            if(rbEatIn.Checked)
            {
                labWhereToEatResult.Text = "Eat In";
            }
            else if(rbTakeOut.Checked)
            {
                labWhereToEatResult.Text = "Take Out";
            }

            labWhereToEatResult.Visible = true;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat(sender, e);
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat(sender, e);

        }

        // adapt Answer of user in label toppings

        private void upDateToppings(object sender, EventArgs e)
        {
            updateTotalPrice(sender, e);

            labToppingResult.Text = "";

            if (chbExtraCheese.Checked)
            {
                labToppingResult.Text += " Cheese,";
            }
            if(chbMushrooms.Checked)
            {
                labToppingResult.Text += " Mushroom,";
            }
            if(chbTomatoes.Checked)
            {
                labToppingResult.Text += " Tomatoes,";
            }
            if(chbOnion.Checked)
            {
                labToppingResult.Text += " Onion,";
            }
            if(chbOlives.Checked)
            {
                labToppingResult.Text += " Olives,";
            }
            if(chbGreenPepper.Checked)
            {
                labToppingResult.Text += " Green Pepper,";
            }

            labToppingResult.Visible = true;
        }

        private void chbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);


        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);
            


        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);
            

        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);
            

        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);
            

        }

        private void chbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            upDateToppings(sender, e);
            

        }

        // adapt the total price of order 

        int GetSelectedSizePrice()
        {
            if (rbSmallPizza.Checked)
            {
                return Convert.ToInt32(rbSmallPizza.Tag);

            }
            else if (rbLargePizza.Checked)
            {
                return Convert.ToInt32(rbLargePizza.Tag);
            }
            else if (rbMediumPizza.Checked)
            {
                return Convert.ToInt32(rbMediumPizza.Tag);
            }

            return 0;
        }

        int GetSelectedToppingsPrice()
        {
            int totalPrice = 0;

            if (chbExtraCheese.Checked)
            {
                totalPrice += Convert.ToInt32(chbExtraCheese.Tag);
            }
            if (chbMushrooms.Checked)
            {
                totalPrice += Convert.ToInt32(chbMushrooms.Tag);

            }
            if (chbTomatoes.Checked)
            {
                totalPrice += Convert.ToInt32(chbTomatoes.Tag);

            }
            if (chbOnion.Checked)
            {
                totalPrice += Convert.ToInt32(chbOnion.Tag);

            }
            if (chbOlives.Checked)
            {
                totalPrice += Convert.ToInt32(chbOlives.Tag);

            }
            if (chbGreenPepper.Checked)
            {
                totalPrice += Convert.ToInt32(chbGreenPepper.Tag);

            }

            return totalPrice;
        }

        int GetSelectedCrustTypePrice()
        {
            if (rbThinPizza.Checked)
            {
                return  Convert.ToInt32(rbThinPizza.Tag);
            }
            else if (rbTuckPizza.Checked)
            {
                return Convert.ToInt32(rbTuckPizza.Tag);
            }

            return 0;
        }

        int GetTotalPrice()
        {
            return GetSelectedCrustTypePrice() + GetSelectedSizePrice() + GetSelectedToppingsPrice();
        }

        private void updateTotalPrice(object sender, EventArgs e)
        {      
            labPriceResult.Text = '$' + GetTotalPrice().ToString() ;
            labPriceResult.Visible = true ;

        }

        void ResetForm()
        {
            rbSmallPizza.Checked = false;
            rbMediumPizza.Checked = false;
            rbLargePizza.Checked = false;

            rbThinPizza.Checked = false;
            rbTuckPizza.Checked = false;

            rbTakeOut.Checked = false;
            rbEatIn.Checked = false;

            chbExtraCheese.Checked = false;
            chbMushrooms.Checked = false;
            chbTomatoes.Checked = false;
            chbOnion.Checked = false;
            chbOlives.Checked = false;
            chbGreenPepper.Checked = false;

            labSizeResult.Text = "";
            labCrustTypeResult.Text = "";
            labCrustTypeResult.Text = "";
            labWhereToEatResult.Text = "";

            gbSizeOfPizza.Enabled = true;
            gbToppingsOfPizza.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbCrustTypeOfPizza.Enabled = true;
            btnOrderPizza.Enabled = true;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successful Order");
                gbSizeOfPizza.Enabled = false;
                gbToppingsOfPizza.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbCrustTypeOfPizza.Enabled = false;
                btnOrderPizza.Enabled = false;
            }

        }
    }
}
