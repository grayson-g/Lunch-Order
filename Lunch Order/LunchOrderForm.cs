using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Lunch_Order
{
    /*
     * This application calculates and displays the total price of a lunch order based
     * on the menu item selected as well as addons, the subtotal, tax, and total are then
     * displayed to the user
     * 
     * Author:  Grayson Germsheid
     * Date:    16 June 2023
     * 
     */
    public partial class LunchOrderForm : Form
    {
        public LunchOrderForm()
        {
            InitializeComponent();
        }

        // Calculates and displays the total price of the order
        // (menu + addons + tax)
        // This is the Click handler for the order button
        private void order(object sender, EventArgs e)
        {
            // Menu price constants
            const double PRICE_HAMBURGER = 6.95;
            const double PRICE_PIZZA = 5.95;
            const double PRICE_SALAD = 4.95;

            double menuPrice;  // The price of the menu item
            double subtotal;    // The subtotal (menu price + addons)
            double tax;         // The tax
            double total;       // The total (subtotal + tax)

            /* 
             * Get the menu price
             * 
             * Since the form is only updated when the "order" or "reset" buttons are
             * pressed, I just check the state of the radio buttons here
             */
            if (HamburgerRadio.Checked)
            {
                menuPrice = PRICE_HAMBURGER;
            }
            else if (PizzaRadio.Checked)
            {
                menuPrice = PRICE_PIZZA;
            }
            else if (SaladRadio.Checked)
            {
                menuPrice = PRICE_SALAD;
            }
            else
            {
                menuPrice = 0;
            }

            // Perform the calculations
            subtotal        = calculateSubtotal(menuPrice); // Calculate the subtotal
            (tax, total)    = calculateTotal(subtotal);     // Calculate the total

            // Display the calculated prices
            SubtotalText.Text = String.Format("{0:C2}", subtotal);  // Format subtotal as price w/ 2 decimals
            TaxText.Text = String.Format("{0:C2}", tax);            // Format tax as price w/ 2 decimals
            OrderTotalText.Text = String.Format("{0:C2}", total);   // Format total as price w/ 2 decimals
        }

        // Calculates the order total and tax rate based on subtotal
        private (double tax, double total) calculateTotal(double subtotal)
        {
            double tax = calculateTax(subtotal);
            return (tax, tax + subtotal);
        }

        // Calculates the sum price of all addons selected
        private double calculateSubtotal(double menuPrice)
        {
            const double ADD_ON_PRICE = 0.75;   // All addons are $0.75
            double addonTotal = 0;                   // Sum of all addon charges

            // iterate through children of the addon group
            for (int i = 0; i < AddOnsGroup.Controls.Count; i++)
            {
                // if the child is checked, then add the addon price to the total
                if (((CheckBox)AddOnsGroup.Controls[i]).Checked)
                {
                    addonTotal += ADD_ON_PRICE;
                }
            }

            return addonTotal + menuPrice;
        }

        // Calculates the tax applied to subtotal
        private double calculateTax(double subtotal)
        {
            const double TAX_RATE = 0.05;   // Tax Rate (GST)
            return subtotal * TAX_RATE;
        }

        // Resets the fields that display prices
        // This is the Click handler for the Reset button
        private void resetPrice(object sender, EventArgs e)
        {
            SubtotalText.Text = "";
            TaxText.Text = "";
            OrderTotalText.Text = "";
        }

        // Closes the application
        // This is the Click handler for the Exit button
        private void quit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}