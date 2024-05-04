namespace WindowsFormsApp1
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.UserInputGroupBox = new System.Windows.Forms.GroupBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalOutputLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceInputLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectVariationLabel = new System.Windows.Forms.Label();
            this.InputListBox2 = new System.Windows.Forms.ListBox();
            this.InputListBox1 = new System.Windows.Forms.ListBox();
            this.SelectItemLabel = new System.Windows.Forms.Label();
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockReport = new System.Windows.Forms.Button();
            this.SalesReportButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.CartGroupBox = new System.Windows.Forms.GroupBox();
            this.CartOutputListBox = new System.Windows.Forms.ListBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalOutputLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearButtonSearch = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.Search2Button = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionIDRadioButton = new System.Windows.Forms.RadioButton();
            this.CartTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.PlaceOrderTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SalesTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.StockTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.UserInputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ButtonsGroupBox.SuspendLayout();
            this.CartGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputGroupBox
            // 
            this.UserInputGroupBox.Controls.Add(this.SubTotalLabel);
            this.UserInputGroupBox.Controls.Add(this.SubTotalOutputLabel);
            this.UserInputGroupBox.Controls.Add(this.UnitPriceLabel);
            this.UserInputGroupBox.Controls.Add(this.UnitPriceInputLabel);
            this.UserInputGroupBox.Controls.Add(this.QuantityLabel);
            this.UserInputGroupBox.Controls.Add(this.QuantityInput);
            this.UserInputGroupBox.Controls.Add(this.pictureBox1);
            this.UserInputGroupBox.Controls.Add(this.SelectVariationLabel);
            this.UserInputGroupBox.Controls.Add(this.InputListBox2);
            this.UserInputGroupBox.Controls.Add(this.InputListBox1);
            this.UserInputGroupBox.Controls.Add(this.SelectItemLabel);
            this.UserInputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputGroupBox.ForeColor = System.Drawing.Color.Black;
            this.UserInputGroupBox.Location = new System.Drawing.Point(27, 43);
            this.UserInputGroupBox.Name = "UserInputGroupBox";
            this.UserInputGroupBox.Size = new System.Drawing.Size(615, 323);
            this.UserInputGroupBox.TabIndex = 0;
            this.UserInputGroupBox.TabStop = false;
            this.UserInputGroupBox.Text = "Order Information";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubTotalLabel.Location = new System.Drawing.Point(491, 193);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(105, 23);
            this.SubTotalLabel.TabIndex = 10;
            // 
            // SubTotalOutputLabel
            // 
            this.SubTotalOutputLabel.AutoSize = true;
            this.SubTotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalOutputLabel.ForeColor = System.Drawing.Color.Black;
            this.SubTotalOutputLabel.Location = new System.Drawing.Point(488, 177);
            this.SubTotalOutputLabel.Name = "SubTotalOutputLabel";
            this.SubTotalOutputLabel.Size = new System.Drawing.Size(62, 13);
            this.SubTotalOutputLabel.TabIndex = 9;
            this.SubTotalOutputLabel.Text = "Sub Total";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitPriceLabel.Location = new System.Drawing.Point(491, 138);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(105, 23);
            this.UnitPriceLabel.TabIndex = 8;
            // 
            // UnitPriceInputLabel
            // 
            this.UnitPriceInputLabel.AutoSize = true;
            this.UnitPriceInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceInputLabel.ForeColor = System.Drawing.Color.Black;
            this.UnitPriceInputLabel.Location = new System.Drawing.Point(488, 121);
            this.UnitPriceInputLabel.Name = "UnitPriceInputLabel";
            this.UnitPriceInputLabel.Size = new System.Drawing.Size(63, 13);
            this.UnitPriceInputLabel.TabIndex = 7;
            this.UnitPriceInputLabel.Text = "Unit Price";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(488, 30);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(94, 13);
            this.QuantityLabel.TabIndex = 6;
            this.QuantityLabel.Text = "Select Quantity";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(491, 44);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(91, 21);
            this.QuantityInput.TabIndex = 5;
            this.QuantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityInput.ValueChanged += new System.EventHandler(this.InputListBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SelectVariationLabel
            // 
            this.SelectVariationLabel.AutoSize = true;
            this.SelectVariationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVariationLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectVariationLabel.Location = new System.Drawing.Point(287, 30);
            this.SelectVariationLabel.Name = "SelectVariationLabel";
            this.SelectVariationLabel.Size = new System.Drawing.Size(129, 13);
            this.SelectVariationLabel.TabIndex = 3;
            this.SelectVariationLabel.Text = "Select Variation Type";
            // 
            // InputListBox2
            // 
            this.InputListBox2.FormattingEnabled = true;
            this.InputListBox2.ItemHeight = 15;
            this.InputListBox2.Items.AddRange(new object[] {
            "Classic",
            "Deluxe",
            "Organic",
            "Mini",
            "Gift Pack",
            "Sampler"});
            this.InputListBox2.Location = new System.Drawing.Point(285, 46);
            this.InputListBox2.Name = "InputListBox2";
            this.InputListBox2.Size = new System.Drawing.Size(163, 94);
            this.InputListBox2.TabIndex = 2;
            this.InputListBox2.SelectedIndexChanged += new System.EventHandler(this.InputListBox1_SelectedIndexChanged);
            // 
            // InputListBox1
            // 
            this.InputListBox1.FormattingEnabled = true;
            this.InputListBox1.ItemHeight = 15;
            this.InputListBox1.Items.AddRange(new object[] {
            "Cheese",
            "Chocolate",
            "Tea",
            "Coffee",
            "Olive Oil",
            "Vinegar",
            "Jams and Preserves",
            "Pasta",
            "Spices",
            "Biscuits and Crackers",
            "Nuts and Dried Fruits",
            "Sauces and Condiments",
            "Wines"});
            this.InputListBox1.Location = new System.Drawing.Point(30, 46);
            this.InputListBox1.Name = "InputListBox1";
            this.InputListBox1.Size = new System.Drawing.Size(221, 244);
            this.InputListBox1.TabIndex = 1;
            this.InputListBox1.SelectedIndexChanged += new System.EventHandler(this.InputListBox1_SelectedIndexChanged);
            // 
            // SelectItemLabel
            // 
            this.SelectItemLabel.AutoSize = true;
            this.SelectItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectItemLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectItemLabel.Location = new System.Drawing.Point(27, 30);
            this.SelectItemLabel.Name = "SelectItemLabel";
            this.SelectItemLabel.Size = new System.Drawing.Size(158, 13);
            this.SelectItemLabel.TabIndex = 0;
            this.SelectItemLabel.Text = "Select Gourmet Food Type";
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Controls.Add(this.SearchButton);
            this.ButtonsGroupBox.Controls.Add(this.StockReport);
            this.ButtonsGroupBox.Controls.Add(this.SalesReportButton);
            this.ButtonsGroupBox.Controls.Add(this.ClearButton);
            this.ButtonsGroupBox.Controls.Add(this.PlaceOrderButton);
            this.ButtonsGroupBox.Controls.Add(this.CartButton);
            this.ButtonsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsGroupBox.Location = new System.Drawing.Point(660, 46);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(231, 320);
            this.ButtonsGroupBox.TabIndex = 1;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Text = "Options Available";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(62, 169);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 30);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "&Search";
            this.SearchTooltip.SetToolTip(this.SearchButton, "Find a gourmet product by name, category, or other details");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockReport
            // 
            this.StockReport.Location = new System.Drawing.Point(61, 250);
            this.StockReport.Name = "StockReport";
            this.StockReport.Size = new System.Drawing.Size(107, 30);
            this.StockReport.TabIndex = 4;
            this.StockReport.Text = "St&ock Report";
            this.StockTooltip.SetToolTip(this.StockReport, "Check the current stock levels of all our gourmet offerings.");
            this.StockReport.UseVisualStyleBackColor = true;
            this.StockReport.Click += new System.EventHandler(this.StockReport_Click);
            // 
            // SalesReportButton
            // 
            this.SalesReportButton.Location = new System.Drawing.Point(61, 210);
            this.SalesReportButton.Name = "SalesReportButton";
            this.SalesReportButton.Size = new System.Drawing.Size(107, 30);
            this.SalesReportButton.TabIndex = 3;
            this.SalesReportButton.Text = "Sal&es Report";
            this.SalesTooltip.SetToolTip(this.SalesReportButton, "View a summary of today\'s sales and itemized transactions.");
            this.SalesReportButton.UseVisualStyleBackColor = true;
            this.SalesReportButton.Click += new System.EventHandler(this.SalesReportButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(61, 130);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 30);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "&Clear";
            this.ClearTooltip.SetToolTip(this.ClearButton, "Clear the current selections or search results");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Enabled = false;
            this.PlaceOrderButton.Location = new System.Drawing.Point(61, 90);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(107, 30);
            this.PlaceOrderButton.TabIndex = 1;
            this.PlaceOrderButton.Text = "&Place Order";
            this.PlaceOrderTooltip.SetToolTip(this.PlaceOrderButton, "Review your cart and click here to confirm and place your order");
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(61, 50);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(107, 30);
            this.CartButton.TabIndex = 0;
            this.CartButton.Text = "&Add to Cart";
            this.CartTooltip.SetToolTip(this.CartButton, "Click to add your selected gourmet items to your shopping cart.");
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // CartGroupBox
            // 
            this.CartGroupBox.Controls.Add(this.CartOutputListBox);
            this.CartGroupBox.Controls.Add(this.TotalLabel);
            this.CartGroupBox.Controls.Add(this.TotalOutputLabel);
            this.CartGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGroupBox.Location = new System.Drawing.Point(27, 375);
            this.CartGroupBox.Name = "CartGroupBox";
            this.CartGroupBox.Size = new System.Drawing.Size(615, 320);
            this.CartGroupBox.TabIndex = 2;
            this.CartGroupBox.TabStop = false;
            this.CartGroupBox.Text = "Cart Information";
            // 
            // CartOutputListBox
            // 
            this.CartOutputListBox.FormattingEnabled = true;
            this.CartOutputListBox.HorizontalScrollbar = true;
            this.CartOutputListBox.ItemHeight = 15;
            this.CartOutputListBox.Location = new System.Drawing.Point(42, 54);
            this.CartOutputListBox.Name = "CartOutputListBox";
            this.CartOutputListBox.Size = new System.Drawing.Size(406, 244);
            this.CartOutputListBox.TabIndex = 15;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(491, 70);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(105, 23);
            this.TotalLabel.TabIndex = 14;
            // 
            // TotalOutputLabel
            // 
            this.TotalOutputLabel.AutoSize = true;
            this.TotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutputLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalOutputLabel.Location = new System.Drawing.Point(488, 54);
            this.TotalOutputLabel.Name = "TotalOutputLabel";
            this.TotalOutputLabel.Size = new System.Drawing.Size(74, 13);
            this.TotalOutputLabel.TabIndex = 13;
            this.TotalOutputLabel.Text = "Grand Total";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.ClearButtonSearch);
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Controls.Add(this.SearchListBox);
            this.SearchGroupBox.Controls.Add(this.Search2Button);
            this.SearchGroupBox.Controls.Add(this.SearchInput);
            this.SearchGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchGroupBox.Controls.Add(this.TransactionIDRadioButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(69, 46);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(573, 320);
            this.SearchGroupBox.TabIndex = 3;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Orders";
            this.SearchGroupBox.Visible = false;
            // 
            // ClearButtonSearch
            // 
            this.ClearButtonSearch.Location = new System.Drawing.Point(60, 191);
            this.ClearButtonSearch.Name = "ClearButtonSearch";
            this.ClearButtonSearch.Size = new System.Drawing.Size(107, 30);
            this.ClearButtonSearch.TabIndex = 18;
            this.ClearButtonSearch.Text = "C&lear";
            this.ClearButtonSearch.UseVisualStyleBackColor = true;
            this.ClearButtonSearch.Click += new System.EventHandler(this.ClearButtonSearch_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(20, 100);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(0, 15);
            this.SearchLabel.TabIndex = 17;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.HorizontalScrollbar = true;
            this.SearchListBox.Items.AddRange(new object[] {
            " "});
            this.SearchListBox.Location = new System.Drawing.Point(228, 28);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(320, 264);
            this.SearchListBox.TabIndex = 16;
            // 
            // Search2Button
            // 
            this.Search2Button.Location = new System.Drawing.Point(60, 155);
            this.Search2Button.Name = "Search2Button";
            this.Search2Button.Size = new System.Drawing.Size(107, 30);
            this.Search2Button.TabIndex = 6;
            this.Search2Button.Text = "Searc&h";
            this.Search2Button.UseVisualStyleBackColor = true;
            this.Search2Button.Click += new System.EventHandler(this.Search2Button_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Enabled = false;
            this.SearchInput.Location = new System.Drawing.Point(20, 120);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(189, 20);
            this.SearchInput.TabIndex = 2;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(20, 70);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(48, 17);
            this.DateRadioButton.TabIndex = 1;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            this.DateRadioButton.CheckedChanged += new System.EventHandler(this.TransactionIDRadioButton_CheckedChanged);
            // 
            // TransactionIDRadioButton
            // 
            this.TransactionIDRadioButton.AutoSize = true;
            this.TransactionIDRadioButton.Location = new System.Drawing.Point(20, 41);
            this.TransactionIDRadioButton.Name = "TransactionIDRadioButton";
            this.TransactionIDRadioButton.Size = new System.Drawing.Size(95, 17);
            this.TransactionIDRadioButton.TabIndex = 0;
            this.TransactionIDRadioButton.TabStop = true;
            this.TransactionIDRadioButton.Text = "Transaction ID";
            this.TransactionIDRadioButton.UseVisualStyleBackColor = true;
            this.TransactionIDRadioButton.CheckedChanged += new System.EventHandler(this.TransactionIDRadioButton_CheckedChanged);
            // 
            // CartTooltip
            // 
            this.CartTooltip.IsBalloon = true;
            this.CartTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CartTooltip.ToolTipTitle = "Info";
            // 
            // PlaceOrderTooltip
            // 
            this.PlaceOrderTooltip.IsBalloon = true;
            this.PlaceOrderTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.PlaceOrderTooltip.ToolTipTitle = "Info";
            // 
            // ClearTooltip
            // 
            this.ClearTooltip.IsBalloon = true;
            this.ClearTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearTooltip.ToolTipTitle = "Info";
            // 
            // SearchTooltip
            // 
            this.SearchTooltip.IsBalloon = true;
            this.SearchTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SearchTooltip.ToolTipTitle = "Info";
            // 
            // SalesTooltip
            // 
            this.SalesTooltip.IsBalloon = true;
            this.SalesTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SalesTooltip.ToolTipTitle = "Info";
            // 
            // StockTooltip
            // 
            this.StockTooltip.IsBalloon = true;
            this.StockTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StockTooltip.ToolTipTitle = "Info";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 749);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.CartGroupBox);
            this.Controls.Add(this.ButtonsGroupBox);
            this.Controls.Add(this.UserInputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageForm";
            this.Text = "Savorique Gourmet Food";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UserInputGroupBox.ResumeLayout(false);
            this.UserInputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ButtonsGroupBox.ResumeLayout(false);
            this.CartGroupBox.ResumeLayout(false);
            this.CartGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInputGroupBox;
        private System.Windows.Forms.Label SelectItemLabel;
        private System.Windows.Forms.Label SelectVariationLabel;
        private System.Windows.Forms.ListBox InputListBox2;
        private System.Windows.Forms.ListBox InputListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.Label UnitPriceInputLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SubTotalOutputLabel;
        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button StockReport;
        private System.Windows.Forms.Button SalesReportButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox CartGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalOutputLabel;
        private System.Windows.Forms.ListBox CartOutputListBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.RadioButton TransactionIDRadioButton;
        private System.Windows.Forms.Button Search2Button;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button ClearButtonSearch;
        private System.Windows.Forms.ToolTip CartTooltip;
        private System.Windows.Forms.ToolTip PlaceOrderTooltip;
        private System.Windows.Forms.ToolTip ClearTooltip;
        private System.Windows.Forms.ToolTip SearchTooltip;
        private System.Windows.Forms.ToolTip SalesTooltip;
        private System.Windows.Forms.ToolTip StockTooltip;
    }
}

