using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;

namespace Lunch_Order
{
    /*
     * A record type to represent menu items
     */
    internal readonly record struct MenuItem(string Name, decimal Price, decimal AddonPrice, string[] Addons);

    /*
     * This application calculates and displays the total price of a lunch Order based
     * on the menu item selected as well as addons, the subtotal, tax, and total are then
     * displayed to the user
     * 
     * Author:  Grayson Germsheid
     * Date:    16 June 2023
     * 
     */
    public partial class LunchOrderForm : Form
    {
        private readonly Dictionary<Control, MenuItem> _menuItems;
        private static readonly decimal TAX_RATE = 0.05m;

        private MenuItem _selectedItem;

        public LunchOrderForm()
        {
            InitializeComponent();
            /*
             * Create a Dictionary of { Control => MenuItem }, so that the actual details of each item can 
             * be retrieved from the Control itself rather than hardcoding all of the values in separate 
             * arrays or multiple identical Click handlers
             */

            _menuItems = new Dictionary<Control, MenuItem>
            {
                [HamburgerRadio] = new MenuItem(
                    "Hamburger",
                    6.95m,
                    0.75m,
                    new string[]
                    {
                        "Lettuce, Tomato, Onion",
                        "Ketchup, Mustard, Mayo",
                        "French Fries",
                    }),
                [PizzaRadio] = new MenuItem(
                    "Pizza",
                    5.95m,
                    0.50m,
                    new string[]
                    {
                        "Mushrooms",
                        "Pepperoni",
                        "Olives",
                    }),
                [SaladRadio] = new MenuItem(
                    "Salad",
                    4.95m,
                    0.25m,
                    new string[]
                    {
                        "Croutons",
                        "Bacon Bits",
                        "Bread Sticks",
                    }),
            };
        }

        /*
         * This is the Click handler for ALL of the menu radio buttons
         * 
         * Updates the internal tracking of the checked item (_selectedItem)
         * Updates the addon checkboxes to reflect this item's addons
         * Resets the price display
         */
        private void ChangeMenu(object sender, EventArgs e)
        {
            _selectedItem = _menuItems[(Control)sender];
            UpdateAddons((Control)sender);
            ResetPrices();
        }

        /*
         * This function is responsible for updating the addon prices to reflect
         * the selected menu item
         */
        private void UpdateAddons(Control menuRadio)
        {
            MenuItem item = _menuItems[menuRadio];                                      // Get the corresponding menu info from the button
            CheckBox[] addonChecks = AddOnsGroup.Controls                               // Get all CheckBoxes in the AddOnsGroup GroupBox
                                                .OfType<CheckBox>()
                                                .ToArray();

            AddOnsGroup.Text = $"{item.Name} Addons ({item.AddonPrice:C2} each)";       // Update the GroupBox Text to reflect the current item
            for (int i = 0; i < item.Addons.Length && i < addonChecks.Length; i++)      // For max(# addons, # CheckBoxes)...
            {
                addonChecks[i].Checked = false;                                         // Reset the CheckBox
                addonChecks[i].Text = item.Addons[i];                                   // Update the price to the MenuItem's AddonPrice
            }
        }

        /*
         * This is the Click handler for the Order Button
         * 
         * Calculates the order total based on the currently selected MenuItem
         */
        private void Order(object sender, EventArgs e)
        {
            decimal subtotal = CalculateSubtotal(_selectedItem);                        // Calculate subtotal (_selectedItem is updated when RadioButtons change)
            decimal tax = CalculateTax(subtotal);                                       // Calculate tax
            decimal total = subtotal + tax;                                             // Calculate total (subtotal + tax)

            SubtotalText.Text = $"{subtotal:C2}";                                       // Update the appropriate TextBoxes (with currency formatting) ...
            TaxText.Text = $"{tax:C2}";
            OrderTotalText.Text = $"{total:C2}";
        }

        /*
         * This is a helper method to calculate the subtotal based on a MenuItem's price
         */
        private decimal CalculateSubtotal(MenuItem Selection)
        {
            decimal subtotal = Selection.Price;                                         // Get the base price

            foreach (CheckBox check in AddOnsGroup.Controls.OfType<CheckBox>())         // For each CheckBox in the AddOnsGroup GroupBox...
            {
                if (check.Checked)                                                      // If the CheckBox is checked, add the MenuItem's AddonPrice to the subtotal
                    subtotal += Selection.AddonPrice;
            }

            return subtotal;
        }

        /*
         * This is a helper method to calculate the tax based on a subtotal
         */
        private decimal CalculateTax(decimal Subtotal)
        {
            return TAX_RATE * Subtotal;                                                 // Tax is rate * price
        }

        /*
         * This is the Click handler for the Reset Button
         * 
         * Selects the default RadioButton (Hamburger)
         * Updates the addon CheckBoxes to reflect that item
         * Resets the price fields
         */
        private void ResetMenu(object sender, EventArgs e)
        {
            HamburgerRadio.Checked = true;                                              // First box --> default
            UpdateAddons(HamburgerRadio);                                               // Update the addon prices/names

            ResetPrices();                                                              // Reset the price fields
        }

        /*
         * This is a helper method that resets the price fields (subtotal/tax/total)
         * since that gets called in a couple of places
         */
        private void ResetPrices()
        {
            SubtotalText.Text = "";
            TaxText.Text = "";
            OrderTotalText.Text = "";
        }


        /*
         * This is the Click handler for the Quit Button, does what it says on the tin
         */
        private void Quit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}