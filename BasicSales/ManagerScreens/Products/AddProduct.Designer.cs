namespace BasicSales.ManagerScreens.Products
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.label3 = new System.Windows.Forms.Label();
            this.ListProduct_1 = new System.Windows.Forms.Button();
            this.AddProduct_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesExtract_1 = new System.Windows.Forms.Button();
            this.StockExtract_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeMode_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberProducts = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProfitPercent = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProfitDecimal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.ValidityGroupBox = new System.Windows.Forms.GroupBox();
            this.radioPerishable = new System.Windows.Forms.RadioButton();
            this.ValidityTime = new System.Windows.Forms.DateTimePicker();
            this.radioNonPerishable = new System.Windows.Forms.RadioButton();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ValidityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Extracts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListProduct_1
            // 
            this.ListProduct_1.BackColor = System.Drawing.Color.White;
            this.ListProduct_1.FlatAppearance.BorderSize = 0;
            this.ListProduct_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ListProduct_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListProduct_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProduct_1.ForeColor = System.Drawing.Color.Black;
            this.ListProduct_1.Location = new System.Drawing.Point(10, 104);
            this.ListProduct_1.Name = "ListProduct_1";
            this.ListProduct_1.Size = new System.Drawing.Size(180, 34);
            this.ListProduct_1.TabIndex = 5;
            this.ListProduct_1.Text = "List";
            this.ListProduct_1.UseVisualStyleBackColor = false;
            this.ListProduct_1.Click += new System.EventHandler(this.ListProduct_1_Click);
            // 
            // AddProduct_1
            // 
            this.AddProduct_1.BackColor = System.Drawing.Color.White;
            this.AddProduct_1.Enabled = false;
            this.AddProduct_1.FlatAppearance.BorderSize = 0;
            this.AddProduct_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddProduct_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct_1.ForeColor = System.Drawing.Color.Black;
            this.AddProduct_1.Location = new System.Drawing.Point(10, 144);
            this.AddProduct_1.Name = "AddProduct_1";
            this.AddProduct_1.Size = new System.Drawing.Size(180, 34);
            this.AddProduct_1.TabIndex = 2;
            this.AddProduct_1.Text = "Add";
            this.AddProduct_1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "BSales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.SalesExtract_1);
            this.panel1.Controls.Add(this.StockExtract_1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListProduct_1);
            this.panel1.Controls.Add(this.AddProduct_1);
            this.panel1.Controls.Add(this.ChangeMode_1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 2;
            // 
            // SalesExtract_1
            // 
            this.SalesExtract_1.BackColor = System.Drawing.Color.White;
            this.SalesExtract_1.FlatAppearance.BorderSize = 0;
            this.SalesExtract_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SalesExtract_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesExtract_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesExtract_1.ForeColor = System.Drawing.Color.Black;
            this.SalesExtract_1.Location = new System.Drawing.Point(10, 283);
            this.SalesExtract_1.Name = "SalesExtract_1";
            this.SalesExtract_1.Size = new System.Drawing.Size(180, 34);
            this.SalesExtract_1.TabIndex = 9;
            this.SalesExtract_1.Text = "Sales";
            this.SalesExtract_1.UseVisualStyleBackColor = false;
            this.SalesExtract_1.Click += new System.EventHandler(this.SalesExtract_1_Click);
            // 
            // StockExtract_1
            // 
            this.StockExtract_1.BackColor = System.Drawing.Color.White;
            this.StockExtract_1.FlatAppearance.BorderSize = 0;
            this.StockExtract_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.StockExtract_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockExtract_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockExtract_1.ForeColor = System.Drawing.Color.Black;
            this.StockExtract_1.Location = new System.Drawing.Point(10, 245);
            this.StockExtract_1.Name = "StockExtract_1";
            this.StockExtract_1.Size = new System.Drawing.Size(180, 34);
            this.StockExtract_1.TabIndex = 8;
            this.StockExtract_1.Text = "Stock";
            this.StockExtract_1.UseVisualStyleBackColor = false;
            this.StockExtract_1.Click += new System.EventHandler(this.StockExtract_1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeMode_1
            // 
            this.ChangeMode_1.BackColor = System.Drawing.Color.White;
            this.ChangeMode_1.FlatAppearance.BorderSize = 0;
            this.ChangeMode_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ChangeMode_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMode_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeMode_1.ForeColor = System.Drawing.Color.Black;
            this.ChangeMode_1.Location = new System.Drawing.Point(10, 715);
            this.ChangeMode_1.Name = "ChangeMode_1";
            this.ChangeMode_1.Size = new System.Drawing.Size(180, 34);
            this.ChangeMode_1.TabIndex = 1;
            this.ChangeMode_1.Text = "Change Mode";
            this.ChangeMode_1.UseVisualStyleBackColor = false;
            this.ChangeMode_1.Click += new System.EventHandler(this.ChangeMode_1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumberProducts);
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblProfitPercent);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblProfitDecimal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSalePrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPurchasePrice);
            this.panel2.Controls.Add(this.ValidityGroupBox);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBarCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 761);
            this.panel2.TabIndex = 3;
            // 
            // NumberProducts
            // 
            this.NumberProducts.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberProducts.Location = new System.Drawing.Point(578, 333);
            this.NumberProducts.MaxLength = 20;
            this.NumberProducts.Name = "NumberProducts";
            this.NumberProducts.Size = new System.Drawing.Size(443, 40);
            this.NumberProducts.TabIndex = 33;
            this.NumberProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberProducts_KeyPress);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClean.FlatAppearance.BorderSize = 2;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(575, 590);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(443, 58);
            this.btnClean.TabIndex = 32;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinish.FlatAppearance.BorderSize = 2;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(575, 663);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(443, 58);
            this.btnFinish.TabIndex = 18;
            this.btnFinish.Text = "Add the Product";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(570, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 34);
            this.label11.TabIndex = 31;
            this.label11.Text = "Number of Products";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfitPercent
            // 
            this.lblProfitPercent.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.lblProfitPercent.ForeColor = System.Drawing.Color.Black;
            this.lblProfitPercent.Location = new System.Drawing.Point(866, 459);
            this.lblProfitPercent.Name = "lblProfitPercent";
            this.lblProfitPercent.Size = new System.Drawing.Size(149, 34);
            this.lblProfitPercent.TabIndex = 29;
            this.lblProfitPercent.Text = "0%";
            this.lblProfitPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(573, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 34);
            this.label12.TabIndex = 28;
            this.label12.Text = "Profit: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitDecimal
            // 
            this.lblProfitDecimal.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitDecimal.ForeColor = System.Drawing.Color.Black;
            this.lblProfitDecimal.Location = new System.Drawing.Point(701, 459);
            this.lblProfitDecimal.Name = "lblProfitDecimal";
            this.lblProfitDecimal.Size = new System.Drawing.Size(149, 34);
            this.lblProfitDecimal.TabIndex = 27;
            this.lblProfitDecimal.Text = "0,00";
            this.lblProfitDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(570, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 34);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sale Price";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(575, 237);
            this.txtSalePrice.MaxLength = 10;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(443, 40);
            this.txtSalePrice.TabIndex = 25;
            this.txtSalePrice.TextChanged += new System.EventHandler(this.CalculateProfit);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(570, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 34);
            this.label9.TabIndex = 24;
            this.label9.Text = "Purchase Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(575, 142);
            this.txtPurchasePrice.MaxLength = 10;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(443, 40);
            this.txtPurchasePrice.TabIndex = 23;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.CalculateProfit);
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            // 
            // ValidityGroupBox
            // 
            this.ValidityGroupBox.Controls.Add(this.radioPerishable);
            this.ValidityGroupBox.Controls.Add(this.ValidityTime);
            this.ValidityGroupBox.Controls.Add(this.radioNonPerishable);
            this.ValidityGroupBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.ValidityGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ValidityGroupBox.Location = new System.Drawing.Point(56, 590);
            this.ValidityGroupBox.Name = "ValidityGroupBox";
            this.ValidityGroupBox.Size = new System.Drawing.Size(443, 131);
            this.ValidityGroupBox.TabIndex = 22;
            this.ValidityGroupBox.TabStop = false;
            this.ValidityGroupBox.Text = "Validity";
            // 
            // radioPerishable
            // 
            this.radioPerishable.Checked = true;
            this.radioPerishable.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPerishable.ForeColor = System.Drawing.Color.Black;
            this.radioPerishable.Location = new System.Drawing.Point(17, 36);
            this.radioPerishable.Name = "radioPerishable";
            this.radioPerishable.Size = new System.Drawing.Size(213, 36);
            this.radioPerishable.TabIndex = 22;
            this.radioPerishable.TabStop = true;
            this.radioPerishable.Text = "Perishable";
            this.radioPerishable.UseVisualStyleBackColor = true;
            this.radioPerishable.CheckedChanged += new System.EventHandler(this.radioPerishable_CheckedChanged);
            // 
            // ValidityTime
            // 
            this.ValidityTime.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidityTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ValidityTime.Location = new System.Drawing.Point(238, 34);
            this.ValidityTime.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.ValidityTime.Name = "ValidityTime";
            this.ValidityTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValidityTime.Size = new System.Drawing.Size(199, 40);
            this.ValidityTime.TabIndex = 19;
            // 
            // radioNonPerishable
            // 
            this.radioNonPerishable.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNonPerishable.ForeColor = System.Drawing.Color.Black;
            this.radioNonPerishable.Location = new System.Drawing.Point(17, 78);
            this.radioNonPerishable.Name = "radioNonPerishable";
            this.radioNonPerishable.Size = new System.Drawing.Size(213, 36);
            this.radioNonPerishable.TabIndex = 21;
            this.radioNonPerishable.Text = "Non-Perishable";
            this.radioNonPerishable.UseVisualStyleBackColor = true;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.txtProductDescription.Location = new System.Drawing.Point(56, 332);
            this.txtProductDescription.MaxLength = 255;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(443, 232);
            this.txtProductDescription.TabIndex = 18;
            this.txtProductDescription.Text = "";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(51, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "Product Description (Optional)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(51, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bar Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(56, 237);
            this.txtBarCode.MaxLength = 20;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(443, 40);
            this.txtBarCode.TabIndex = 14;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(49, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add New Product";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(56, 142);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(443, 40);
            this.txtProductName.TabIndex = 0;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager - Add Product";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ValidityGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ListProduct_1;
        private System.Windows.Forms.Button AddProduct_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SalesExtract_1;
        private System.Windows.Forms.Button StockExtract_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeMode_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ValidityTime;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioNonPerishable;
        private System.Windows.Forms.GroupBox ValidityGroupBox;
        private System.Windows.Forms.RadioButton radioPerishable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProfitPercent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProfitDecimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox NumberProducts;
    }
}