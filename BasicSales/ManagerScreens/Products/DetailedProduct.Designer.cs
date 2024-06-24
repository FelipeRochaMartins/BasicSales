namespace BasicSales.ManagerScreens.Products
{
    partial class DetailedProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedProduct));
            this.NumberProducts1 = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProfitPercent1 = new System.Windows.Forms.Label();
            this.lblProfitDecimal1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalePrice1 = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice1 = new System.Windows.Forms.TextBox();
            this.radioPerishable1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.ValidityTime1 = new System.Windows.Forms.DateTimePicker();
            this.radioNonPerishable1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ValidityGroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductDescription1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarCode1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName1 = new System.Windows.Forms.TextBox();
            this.ValidityGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberProducts1
            // 
            this.NumberProducts1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberProducts1.Location = new System.Drawing.Point(675, 332);
            this.NumberProducts1.MaxLength = 20;
            this.NumberProducts1.Name = "NumberProducts1";
            this.NumberProducts1.Size = new System.Drawing.Size(443, 40);
            this.NumberProducts1.TabIndex = 51;
            this.NumberProducts1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberProducts1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberProducts1_KeyPress);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinish.FlatAppearance.BorderSize = 2;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(672, 662);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(443, 58);
            this.btnFinish.TabIndex = 40;
            this.btnFinish.Text = "Update the Product";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(667, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 34);
            this.label11.TabIndex = 50;
            this.label11.Text = "Number of Products";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfitPercent1
            // 
            this.lblProfitPercent1.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.lblProfitPercent1.ForeColor = System.Drawing.Color.Black;
            this.lblProfitPercent1.Location = new System.Drawing.Point(963, 458);
            this.lblProfitPercent1.Name = "lblProfitPercent1";
            this.lblProfitPercent1.Size = new System.Drawing.Size(149, 34);
            this.lblProfitPercent1.TabIndex = 49;
            this.lblProfitPercent1.Text = "0%";
            this.lblProfitPercent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitDecimal1
            // 
            this.lblProfitDecimal1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitDecimal1.ForeColor = System.Drawing.Color.Black;
            this.lblProfitDecimal1.Location = new System.Drawing.Point(798, 458);
            this.lblProfitDecimal1.Name = "lblProfitDecimal1";
            this.lblProfitDecimal1.Size = new System.Drawing.Size(149, 34);
            this.lblProfitDecimal1.TabIndex = 47;
            this.lblProfitDecimal1.Text = "0,00";
            this.lblProfitDecimal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(667, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 34);
            this.label10.TabIndex = 46;
            this.label10.Text = "Sale Price";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalePrice1
            // 
            this.txtSalePrice1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice1.Location = new System.Drawing.Point(672, 236);
            this.txtSalePrice1.MaxLength = 10;
            this.txtSalePrice1.Name = "txtSalePrice1";
            this.txtSalePrice1.Size = new System.Drawing.Size(443, 40);
            this.txtSalePrice1.TabIndex = 45;
            this.txtSalePrice1.TextChanged += new System.EventHandler(this.CalculateProfit);
            this.txtSalePrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice1_KeyPress);
            // 
            // txtPurchasePrice1
            // 
            this.txtPurchasePrice1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice1.Location = new System.Drawing.Point(672, 141);
            this.txtPurchasePrice1.MaxLength = 10;
            this.txtPurchasePrice1.Name = "txtPurchasePrice1";
            this.txtPurchasePrice1.Size = new System.Drawing.Size(443, 40);
            this.txtPurchasePrice1.TabIndex = 43;
            this.txtPurchasePrice1.TextChanged += new System.EventHandler(this.CalculateProfit);
            this.txtPurchasePrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice1_KeyPress);
            // 
            // radioPerishable1
            // 
            this.radioPerishable1.Checked = true;
            this.radioPerishable1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPerishable1.ForeColor = System.Drawing.Color.Black;
            this.radioPerishable1.Location = new System.Drawing.Point(17, 36);
            this.radioPerishable1.Name = "radioPerishable1";
            this.radioPerishable1.Size = new System.Drawing.Size(213, 36);
            this.radioPerishable1.TabIndex = 22;
            this.radioPerishable1.TabStop = true;
            this.radioPerishable1.Text = "Perishable";
            this.radioPerishable1.UseVisualStyleBackColor = true;
            this.radioPerishable1.CheckedChanged += new System.EventHandler(this.radioPerishable1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(670, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 34);
            this.label12.TabIndex = 48;
            this.label12.Text = "Profit: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidityTime1
            // 
            this.ValidityTime1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidityTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ValidityTime1.Location = new System.Drawing.Point(238, 34);
            this.ValidityTime1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.ValidityTime1.Name = "ValidityTime1";
            this.ValidityTime1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValidityTime1.Size = new System.Drawing.Size(199, 40);
            this.ValidityTime1.TabIndex = 19;
            // 
            // radioNonPerishable1
            // 
            this.radioNonPerishable1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNonPerishable1.ForeColor = System.Drawing.Color.Black;
            this.radioNonPerishable1.Location = new System.Drawing.Point(17, 78);
            this.radioNonPerishable1.Name = "radioNonPerishable1";
            this.radioNonPerishable1.Size = new System.Drawing.Size(213, 36);
            this.radioNonPerishable1.TabIndex = 21;
            this.radioNonPerishable1.Text = "Non-Perishable";
            this.radioNonPerishable1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(667, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 34);
            this.label9.TabIndex = 44;
            this.label9.Text = "Purchase Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValidityGroupBox1
            // 
            this.ValidityGroupBox1.Controls.Add(this.radioPerishable1);
            this.ValidityGroupBox1.Controls.Add(this.ValidityTime1);
            this.ValidityGroupBox1.Controls.Add(this.radioNonPerishable1);
            this.ValidityGroupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.ValidityGroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ValidityGroupBox1.Location = new System.Drawing.Point(153, 589);
            this.ValidityGroupBox1.Name = "ValidityGroupBox1";
            this.ValidityGroupBox1.Size = new System.Drawing.Size(443, 131);
            this.ValidityGroupBox1.TabIndex = 42;
            this.ValidityGroupBox1.TabStop = false;
            this.ValidityGroupBox1.Text = "Validity";
            // 
            // txtProductDescription1
            // 
            this.txtProductDescription1.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.txtProductDescription1.Location = new System.Drawing.Point(153, 331);
            this.txtProductDescription1.MaxLength = 255;
            this.txtProductDescription1.Name = "txtProductDescription1";
            this.txtProductDescription1.Size = new System.Drawing.Size(443, 232);
            this.txtProductDescription1.TabIndex = 41;
            this.txtProductDescription1.Text = "";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(148, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 34);
            this.label8.TabIndex = 39;
            this.label8.Text = "Product Description (Optional)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(148, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 34);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bar Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarCode1
            // 
            this.txtBarCode1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode1.Location = new System.Drawing.Point(153, 236);
            this.txtBarCode1.MaxLength = 20;
            this.txtBarCode1.Name = "txtBarCode1";
            this.txtBarCode1.Size = new System.Drawing.Size(443, 40);
            this.txtBarCode1.TabIndex = 37;
            this.txtBarCode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode1_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(148, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 34);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProductName.Location = new System.Drawing.Point(146, 41);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(249, 41);
            this.lblProductName.TabIndex = 35;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductName1
            // 
            this.txtProductName1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName1.Location = new System.Drawing.Point(153, 141);
            this.txtProductName1.MaxLength = 50;
            this.txtProductName1.Name = "txtProductName1";
            this.txtProductName1.Size = new System.Drawing.Size(443, 40);
            this.txtProductName1.TabIndex = 34;
            // 
            // DetailedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.NumberProducts1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblProfitPercent1);
            this.Controls.Add(this.lblProfitDecimal1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSalePrice1);
            this.Controls.Add(this.txtPurchasePrice1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValidityGroupBox1);
            this.Controls.Add(this.txtProductDescription1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBarCode1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetailedProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager - ";
            this.Load += new System.EventHandler(this.DetailedProduct_Load);
            this.ValidityGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberProducts1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProfitPercent1;
        private System.Windows.Forms.Label lblProfitDecimal1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalePrice1;
        private System.Windows.Forms.TextBox txtPurchasePrice1;
        private System.Windows.Forms.RadioButton radioPerishable1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ValidityTime1;
        private System.Windows.Forms.RadioButton radioNonPerishable1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox ValidityGroupBox1;
        private System.Windows.Forms.RichTextBox txtProductDescription1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarCode1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName1;
    }
}