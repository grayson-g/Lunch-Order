namespace Lunch_Order
{
    partial class LunchOrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainCourseGroup = new GroupBox();
            SaladPriceLabel = new Label();
            PizzaPriceLabel = new Label();
            HamburgerPriceLabel = new Label();
            SaladRadio = new RadioButton();
            PizzaRadio = new RadioButton();
            HamburgerRadio = new RadioButton();
            AddOnsGroup = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            OrderTotalGroup = new GroupBox();
            SubtotalText = new TextBox();
            TaxText = new TextBox();
            OrderTotalText = new TextBox();
            OrderTotalLabel = new Label();
            TaxLabel = new Label();
            SubtotalLabel = new Label();
            PlaceOrderButton = new Button();
            ResetButton = new Button();
            ExitButton = new Button();
            MainCourseGroup.SuspendLayout();
            AddOnsGroup.SuspendLayout();
            OrderTotalGroup.SuspendLayout();
            SuspendLayout();
            // 
            // MainCourseGroup
            // 
            MainCourseGroup.Controls.Add(SaladPriceLabel);
            MainCourseGroup.Controls.Add(PizzaPriceLabel);
            MainCourseGroup.Controls.Add(HamburgerPriceLabel);
            MainCourseGroup.Controls.Add(SaladRadio);
            MainCourseGroup.Controls.Add(PizzaRadio);
            MainCourseGroup.Controls.Add(HamburgerRadio);
            MainCourseGroup.Location = new Point(12, 12);
            MainCourseGroup.Name = "MainCourseGroup";
            MainCourseGroup.Size = new Size(200, 100);
            MainCourseGroup.TabIndex = 0;
            MainCourseGroup.TabStop = false;
            MainCourseGroup.Text = "Main Course";
            // 
            // SaladPriceLabel
            // 
            SaladPriceLabel.AutoSize = true;
            SaladPriceLabel.Location = new Point(156, 74);
            SaladPriceLabel.Name = "SaladPriceLabel";
            SaladPriceLabel.Size = new Size(34, 15);
            SaladPriceLabel.TabIndex = 3;
            SaladPriceLabel.Text = "$4.95";
            // 
            // PizzaPriceLabel
            // 
            PizzaPriceLabel.AutoSize = true;
            PizzaPriceLabel.Location = new Point(156, 49);
            PizzaPriceLabel.Name = "PizzaPriceLabel";
            PizzaPriceLabel.Size = new Size(34, 15);
            PizzaPriceLabel.TabIndex = 2;
            PizzaPriceLabel.Text = "$5.95";
            // 
            // HamburgerPriceLabel
            // 
            HamburgerPriceLabel.AutoSize = true;
            HamburgerPriceLabel.Location = new Point(156, 24);
            HamburgerPriceLabel.Name = "HamburgerPriceLabel";
            HamburgerPriceLabel.Size = new Size(34, 15);
            HamburgerPriceLabel.TabIndex = 1;
            HamburgerPriceLabel.Text = "$6.95";
            // 
            // SaladRadio
            // 
            SaladRadio.AutoSize = true;
            SaladRadio.Location = new Point(6, 72);
            SaladRadio.Name = "SaladRadio";
            SaladRadio.Size = new Size(53, 19);
            SaladRadio.TabIndex = 1;
            SaladRadio.TabStop = true;
            SaladRadio.Text = "Salad";
            SaladRadio.UseVisualStyleBackColor = true;
            // 
            // PizzaRadio
            // 
            PizzaRadio.AutoSize = true;
            PizzaRadio.Location = new Point(6, 47);
            PizzaRadio.Name = "PizzaRadio";
            PizzaRadio.Size = new Size(51, 19);
            PizzaRadio.TabIndex = 1;
            PizzaRadio.TabStop = true;
            PizzaRadio.Text = "Pizza";
            PizzaRadio.UseVisualStyleBackColor = true;
            // 
            // HamburgerRadio
            // 
            HamburgerRadio.AutoSize = true;
            HamburgerRadio.Location = new Point(6, 22);
            HamburgerRadio.Name = "HamburgerRadio";
            HamburgerRadio.Size = new Size(86, 19);
            HamburgerRadio.TabIndex = 0;
            HamburgerRadio.TabStop = true;
            HamburgerRadio.Text = "Hamburger";
            HamburgerRadio.UseVisualStyleBackColor = true;
            // 
            // AddOnsGroup
            // 
            AddOnsGroup.Controls.Add(checkBox3);
            AddOnsGroup.Controls.Add(checkBox2);
            AddOnsGroup.Controls.Add(checkBox1);
            AddOnsGroup.Location = new Point(218, 12);
            AddOnsGroup.Name = "AddOnsGroup";
            AddOnsGroup.Size = new Size(226, 100);
            AddOnsGroup.TabIndex = 1;
            AddOnsGroup.TabStop = false;
            AddOnsGroup.Text = "Add-Ons ($0.75 each)";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 72);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(89, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "French Fries";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(213, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ketchup, Mustard, and Mayonnaise";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(173, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Lettuce, Tomato, and Onion";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // OrderTotalGroup
            // 
            OrderTotalGroup.Controls.Add(SubtotalText);
            OrderTotalGroup.Controls.Add(TaxText);
            OrderTotalGroup.Controls.Add(OrderTotalText);
            OrderTotalGroup.Controls.Add(OrderTotalLabel);
            OrderTotalGroup.Controls.Add(TaxLabel);
            OrderTotalGroup.Controls.Add(SubtotalLabel);
            OrderTotalGroup.Location = new Point(12, 133);
            OrderTotalGroup.Name = "OrderTotalGroup";
            OrderTotalGroup.Size = new Size(200, 118);
            OrderTotalGroup.TabIndex = 2;
            OrderTotalGroup.TabStop = false;
            OrderTotalGroup.Text = "Order Total";
            // 
            // SubtotalText
            // 
            SubtotalText.Location = new Point(81, 22);
            SubtotalText.Name = "SubtotalText";
            SubtotalText.ReadOnly = true;
            SubtotalText.Size = new Size(100, 23);
            SubtotalText.TabIndex = 5;
            SubtotalText.TextAlign = HorizontalAlignment.Right;
            // 
            // TaxText
            // 
            TaxText.Location = new Point(81, 51);
            TaxText.Name = "TaxText";
            TaxText.ReadOnly = true;
            TaxText.Size = new Size(100, 23);
            TaxText.TabIndex = 4;
            TaxText.TextAlign = HorizontalAlignment.Right;
            // 
            // OrderTotalText
            // 
            OrderTotalText.Location = new Point(81, 80);
            OrderTotalText.Name = "OrderTotalText";
            OrderTotalText.ReadOnly = true;
            OrderTotalText.Size = new Size(100, 23);
            OrderTotalText.TabIndex = 3;
            OrderTotalText.TextAlign = HorizontalAlignment.Right;
            // 
            // OrderTotalLabel
            // 
            OrderTotalLabel.AutoSize = true;
            OrderTotalLabel.Location = new Point(4, 83);
            OrderTotalLabel.Name = "OrderTotalLabel";
            OrderTotalLabel.Size = new Size(71, 15);
            OrderTotalLabel.TabIndex = 2;
            OrderTotalLabel.Text = "Order Total :";
            // 
            // TaxLabel
            // 
            TaxLabel.AutoSize = true;
            TaxLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TaxLabel.Location = new Point(16, 54);
            TaxLabel.Name = "TaxLabel";
            TaxLabel.Size = new Size(59, 15);
            TaxLabel.TabIndex = 1;
            TaxLabel.Text = "Tax (5%) :";
            // 
            // SubtotalLabel
            // 
            SubtotalLabel.AutoSize = true;
            SubtotalLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SubtotalLabel.Location = new Point(17, 25);
            SubtotalLabel.Name = "SubtotalLabel";
            SubtotalLabel.Size = new Size(58, 15);
            SubtotalLabel.TabIndex = 0;
            SubtotalLabel.Text = "Subtotal :";
            // 
            // PlaceOrderButton
            // 
            PlaceOrderButton.Location = new Point(258, 154);
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.Size = new Size(148, 23);
            PlaceOrderButton.TabIndex = 3;
            PlaceOrderButton.Text = "Place &Order";
            PlaceOrderButton.UseVisualStyleBackColor = true;
            PlaceOrderButton.Click += order;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(258, 183);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(148, 23);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "&Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += resetPrice;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(258, 212);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += quit;
            // 
            // LunchOrderForm
            // 
            AcceptButton = PlaceOrderButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ResetButton;
            ClientSize = new Size(459, 271);
            Controls.Add(ExitButton);
            Controls.Add(ResetButton);
            Controls.Add(PlaceOrderButton);
            Controls.Add(OrderTotalGroup);
            Controls.Add(AddOnsGroup);
            Controls.Add(MainCourseGroup);
            Name = "LunchOrderForm";
            Text = "Lunch Order";
            MainCourseGroup.ResumeLayout(false);
            MainCourseGroup.PerformLayout();
            AddOnsGroup.ResumeLayout(false);
            AddOnsGroup.PerformLayout();
            OrderTotalGroup.ResumeLayout(false);
            OrderTotalGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainCourseGroup;
        private RadioButton SaladRadio;
        private RadioButton PizzaRadio;
        private RadioButton HamburgerRadio;
        private Label SaladPriceLabel;
        private Label PizzaPriceLabel;
        private Label HamburgerPriceLabel;
        private GroupBox AddOnsGroup;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox OrderTotalGroup;
        private TextBox OrderTotalText;
        private Label OrderTotalLabel;
        private Label TaxLabel;
        private Label SubtotalLabel;
        private TextBox SubtotalText;
        private TextBox TaxText;
        private Button PlaceOrderButton;
        private Button ResetButton;
        private Button ExitButton;
    }
}