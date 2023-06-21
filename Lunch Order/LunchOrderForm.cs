using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;

namespace Lunch_Order
{
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

            _selectedItem = _menuItems[HamburgerRadio];
        }

        private void ChangeMenu(object sender, EventArgs e)
        {
            _selectedItem = _menuItems[(Control)sender];
            UpdateAddons((Control)sender);
            ResetPrices();
        }

        private void UpdateAddons(Control menuRadio)
        {
            MenuItem item = _menuItems[menuRadio];
            CheckBox[] addonChecks = AddOnsGroup.Controls
                                                .OfType<CheckBox>()
                                                .ToArray();

            AddOnsGroup.Text = $"{item.Name} Addons ({item.AddonPrice:C2} each)";
            for (int i = 0; i < item.Addons.Length && i < addonChecks.Length; i++)
            {
                addonChecks[i].Checked = false;
                addonChecks[i].Text = item.Addons[i];
            }
        }

        // Calculates and displays the total price of the order
        // (menu + addons + tax)
        // This is the Click handler for the Order button
        private void Order(object sender, EventArgs e)
        {
            decimal subtotal = CalculateSubtotal(_selectedItem);
            decimal tax = CalculateTax(subtotal);
            decimal total = subtotal + tax;

            SubtotalText.Text = $"{subtotal:C2}";
            TaxText.Text = $"{tax:C2}";
            OrderTotalText.Text = $"{total:C2}";
        }

        private decimal CalculateSubtotal(MenuItem Selection)
        {
            decimal subtotal = Selection.Price;

            foreach (CheckBox check in AddOnsGroup.Controls.OfType<CheckBox>())
            {
                if (check.Checked)
                    subtotal += Selection.AddonPrice;
            }

            return subtotal;
        }

        private decimal CalculateTax(decimal Subtotal)
        {
            return TAX_RATE * Subtotal;
        }

        // Resets the fields that display prices
        // This is the Click handler for the Reset button
        private void ResetMenu(object sender, EventArgs e)
        {
            HamburgerRadio.Checked = true;
            UpdateAddons(HamburgerRadio);

            ResetPrices();
        }

        private void ResetPrices()
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