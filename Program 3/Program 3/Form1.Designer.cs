namespace Program_3
{
    partial class Form1
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
            this.calculateBut = new System.Windows.Forms.Button();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.contractLengthBox = new System.Windows.Forms.TextBox();
            this.tittle = new System.Windows.Forms.Label();
            this.BusinessLabel = new System.Windows.Forms.Label();
            this.contractLengthLable = new System.Windows.Forms.Label();
            this.shippingProviderLabel = new System.Windows.Forms.Label();
            this.initialContractPriceLabel = new System.Windows.Forms.Label();
            this.companyDiscountLabel = new System.Windows.Forms.Label();
            this.lengthDiscountLabel = new System.Windows.Forms.Label();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.shippingProviderBox = new System.Windows.Forms.TextBox();
            this.initialContractPriceBox = new System.Windows.Forms.TextBox();
            this.companyDiscountBox = new System.Windows.Forms.TextBox();
            this.lengthDiscountBox = new System.Windows.Forms.TextBox();
            this.finalPriceBox = new System.Windows.Forms.TextBox();
            this.businessBox = new System.Windows.Forms.ComboBox();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calculateBut
            // 
            this.calculateBut.Location = new System.Drawing.Point(82, 148);
            this.calculateBut.Name = "calculateBut";
            this.calculateBut.Size = new System.Drawing.Size(75, 23);
            this.calculateBut.TabIndex = 0;
            this.calculateBut.Text = "Calculate";
            this.calculateBut.UseVisualStyleBackColor = true;
            this.calculateBut.Click += new System.EventHandler(this.calculateBut_Click);
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Location = new System.Drawing.Point(58, 52);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(49, 13);
            this.ProviderLabel.TabIndex = 1;
            this.ProviderLabel.Text = "Provider:";
            // 
            // contractLengthBox
            // 
            this.contractLengthBox.Location = new System.Drawing.Point(113, 119);
            this.contractLengthBox.Name = "contractLengthBox";
            this.contractLengthBox.Size = new System.Drawing.Size(100, 20);
            this.contractLengthBox.TabIndex = 2;
            this.contractLengthBox.TextChanged += new System.EventHandler(this.contractLengthBox_TextChanged);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Location = new System.Drawing.Point(89, 19);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(141, 13);
            this.tittle.TabIndex = 3;
            this.tittle.Text = "Shipping Contract Calculator";
            this.tittle.Click += new System.EventHandler(this.tittle_Click);
            // 
            // BusinessLabel
            // 
            this.BusinessLabel.AutoSize = true;
            this.BusinessLabel.Location = new System.Drawing.Point(52, 87);
            this.BusinessLabel.Name = "BusinessLabel";
            this.BusinessLabel.Size = new System.Drawing.Size(55, 13);
            this.BusinessLabel.TabIndex = 4;
            this.BusinessLabel.Text = "Business: ";
            this.BusinessLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // contractLengthLable
            // 
            this.contractLengthLable.AutoSize = true;
            this.contractLengthLable.Location = new System.Drawing.Point(24, 122);
            this.contractLengthLable.Name = "contractLengthLable";
            this.contractLengthLable.Size = new System.Drawing.Size(83, 13);
            this.contractLengthLable.TabIndex = 5;
            this.contractLengthLable.Text = "Contract Length";
            // 
            // shippingProviderLabel
            // 
            this.shippingProviderLabel.AutoSize = true;
            this.shippingProviderLabel.Location = new System.Drawing.Point(14, 187);
            this.shippingProviderLabel.Name = "shippingProviderLabel";
            this.shippingProviderLabel.Size = new System.Drawing.Size(93, 13);
            this.shippingProviderLabel.TabIndex = 6;
            this.shippingProviderLabel.Text = "Shipping Provider:";
            // 
            // initialContractPriceLabel
            // 
            this.initialContractPriceLabel.AutoSize = true;
            this.initialContractPriceLabel.Location = new System.Drawing.Point(3, 215);
            this.initialContractPriceLabel.Name = "initialContractPriceLabel";
            this.initialContractPriceLabel.Size = new System.Drawing.Size(104, 13);
            this.initialContractPriceLabel.TabIndex = 7;
            this.initialContractPriceLabel.Text = "Initial Contract Price:";
            // 
            // companyDiscountLabel
            // 
            this.companyDiscountLabel.AutoSize = true;
            this.companyDiscountLabel.Location = new System.Drawing.Point(8, 243);
            this.companyDiscountLabel.Name = "companyDiscountLabel";
            this.companyDiscountLabel.Size = new System.Drawing.Size(99, 13);
            this.companyDiscountLabel.TabIndex = 8;
            this.companyDiscountLabel.Text = "Company Discount:";
            // 
            // lengthDiscountLabel
            // 
            this.lengthDiscountLabel.AutoSize = true;
            this.lengthDiscountLabel.Location = new System.Drawing.Point(16, 271);
            this.lengthDiscountLabel.Name = "lengthDiscountLabel";
            this.lengthDiscountLabel.Size = new System.Drawing.Size(91, 13);
            this.lengthDiscountLabel.TabIndex = 9;
            this.lengthDiscountLabel.Text = "Length Discount: ";
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Location = new System.Drawing.Point(45, 299);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(62, 13);
            this.finalPriceLabel.TabIndex = 10;
            this.finalPriceLabel.Text = "Final Price: ";
            // 
            // shippingProviderBox
            // 
            this.shippingProviderBox.Location = new System.Drawing.Point(113, 184);
            this.shippingProviderBox.Name = "shippingProviderBox";
            this.shippingProviderBox.Size = new System.Drawing.Size(100, 20);
            this.shippingProviderBox.TabIndex = 11;
            // 
            // initialContractPriceBox
            // 
            this.initialContractPriceBox.Location = new System.Drawing.Point(113, 211);
            this.initialContractPriceBox.Name = "initialContractPriceBox";
            this.initialContractPriceBox.Size = new System.Drawing.Size(100, 20);
            this.initialContractPriceBox.TabIndex = 12;
            // 
            // companyDiscountBox
            // 
            this.companyDiscountBox.Location = new System.Drawing.Point(113, 238);
            this.companyDiscountBox.Name = "companyDiscountBox";
            this.companyDiscountBox.Size = new System.Drawing.Size(100, 20);
            this.companyDiscountBox.TabIndex = 13;
            // 
            // lengthDiscountBox
            // 
            this.lengthDiscountBox.Location = new System.Drawing.Point(113, 265);
            this.lengthDiscountBox.Name = "lengthDiscountBox";
            this.lengthDiscountBox.Size = new System.Drawing.Size(100, 20);
            this.lengthDiscountBox.TabIndex = 14;
            // 
            // finalPriceBox
            // 
            this.finalPriceBox.Location = new System.Drawing.Point(113, 292);
            this.finalPriceBox.Name = "finalPriceBox";
            this.finalPriceBox.Size = new System.Drawing.Size(100, 20);
            this.finalPriceBox.TabIndex = 15;
            // 
            // businessBox
            // 
            this.businessBox.FormattingEnabled = true;
            this.businessBox.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.businessBox.Location = new System.Drawing.Point(113, 84);
            this.businessBox.Name = "businessBox";
            this.businessBox.Size = new System.Drawing.Size(121, 21);
            this.businessBox.TabIndex = 16;
            this.businessBox.SelectedIndexChanged += new System.EventHandler(this.businessBox_SelectedIndexChanged);
            // 
            // providerBox
            // 
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.providerBox.Location = new System.Drawing.Point(113, 49);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(121, 21);
            this.providerBox.TabIndex = 17;
            this.providerBox.TabStop = false;
            this.providerBox.SelectedIndexChanged += new System.EventHandler(this.providerBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 336);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.businessBox);
            this.Controls.Add(this.finalPriceBox);
            this.Controls.Add(this.lengthDiscountBox);
            this.Controls.Add(this.companyDiscountBox);
            this.Controls.Add(this.initialContractPriceBox);
            this.Controls.Add(this.shippingProviderBox);
            this.Controls.Add(this.finalPriceLabel);
            this.Controls.Add(this.lengthDiscountLabel);
            this.Controls.Add(this.companyDiscountLabel);
            this.Controls.Add(this.initialContractPriceLabel);
            this.Controls.Add(this.shippingProviderLabel);
            this.Controls.Add(this.contractLengthLable);
            this.Controls.Add(this.BusinessLabel);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.contractLengthBox);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.calculateBut);
            this.Name = "Form1";
            this.Text = "Contract Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBut;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.TextBox contractLengthBox;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label BusinessLabel;
        private System.Windows.Forms.Label contractLengthLable;
        private System.Windows.Forms.Label shippingProviderLabel;
        private System.Windows.Forms.Label initialContractPriceLabel;
        private System.Windows.Forms.Label companyDiscountLabel;
        private System.Windows.Forms.Label lengthDiscountLabel;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.TextBox shippingProviderBox;
        private System.Windows.Forms.TextBox initialContractPriceBox;
        private System.Windows.Forms.TextBox companyDiscountBox;
        private System.Windows.Forms.TextBox lengthDiscountBox;
        private System.Windows.Forms.TextBox finalPriceBox;
        private System.Windows.Forms.ComboBox businessBox;
        private System.Windows.Forms.ComboBox providerBox;
    }
}

