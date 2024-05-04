namespace WindowsFormsApp1
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SalesListBox = new System.Windows.Forms.ListBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.SalesListBox);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.ProductLabel);
            this.panel1.Controls.Add(this.TotalValueLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 292);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(234, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 24);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SalesListBox
            // 
            this.SalesListBox.FormattingEnabled = true;
            this.SalesListBox.HorizontalScrollbar = true;
            this.SalesListBox.Location = new System.Drawing.Point(82, 42);
            this.SalesListBox.Name = "SalesListBox";
            this.SalesListBox.Size = new System.Drawing.Size(419, 186);
            this.SalesListBox.TabIndex = 3;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(198, 23);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(63, 16);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(289, 23);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(60, 16);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "Product";
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValueLabel.Location = new System.Drawing.Point(79, 23);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(87, 16);
            this.TotalValueLabel.TabIndex = 0;
            this.TotalValueLabel.Text = "Total Value";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.Text = "Savorique Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.ListBox SalesListBox;
        private System.Windows.Forms.Button ExitButton;
    }
}