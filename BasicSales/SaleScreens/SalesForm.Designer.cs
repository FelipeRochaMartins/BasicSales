namespace BasicSales.SaleScreens
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.btnRemove = new System.Windows.Forms.Button();
            this.FinalPrice = new System.Windows.Forms.Label();
            this.ProductSaleGrid = new System.Windows.Forms.DataGridView();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQtd = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBarChangeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSurcharge = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnConclude = new System.Windows.Forms.Button();
            this.LabelDayMonth = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductsViewGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentGroupBox = new System.Windows.Forms.GroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioVoucher = new System.Windows.Forms.RadioButton();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioPix = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSaleGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsViewGrid)).BeginInit();
            this.PaymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(1052, 262);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(205, 68);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FinalPrice
            // 
            this.FinalPrice.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPrice.Location = new System.Drawing.Point(766, 659);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(279, 96);
            this.FinalPrice.TabIndex = 15;
            this.FinalPrice.Text = "0,00";
            this.FinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductSaleGrid
            // 
            this.ProductSaleGrid.AllowUserToAddRows = false;
            this.ProductSaleGrid.AllowUserToDeleteRows = false;
            this.ProductSaleGrid.AllowUserToResizeRows = false;
            this.ProductSaleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductSaleGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductSaleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductSaleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSaleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductSaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product,
            this.product_name_sale,
            this.price,
            this.quantity,
            this.total_price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSaleGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductSaleGrid.EnableHeadersVisualStyles = false;
            this.ProductSaleGrid.GridColor = System.Drawing.Color.MidnightBlue;
            this.ProductSaleGrid.Location = new System.Drawing.Point(555, 89);
            this.ProductSaleGrid.MultiSelect = false;
            this.ProductSaleGrid.Name = "ProductSaleGrid";
            this.ProductSaleGrid.ReadOnly = true;
            this.ProductSaleGrid.RowHeadersVisible = false;
            this.ProductSaleGrid.RowTemplate.Height = 35;
            this.ProductSaleGrid.RowTemplate.ReadOnly = true;
            this.ProductSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductSaleGrid.Size = new System.Drawing.Size(491, 556);
            this.ProductSaleGrid.TabIndex = 13;
            this.ProductSaleGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ProductSaleGrid_RowsRemoved);
            // 
            // id_product
            // 
            this.id_product.HeaderText = "ID";
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            this.id_product.Visible = false;
            // 
            // product_name_sale
            // 
            this.product_name_sale.FillWeight = 200F;
            this.product_name_sale.HeaderText = "Product";
            this.product_name_sale.Name = "product_name_sale";
            this.product_name_sale.ReadOnly = true;
            // 
            // price
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.FillWeight = 75F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // total_price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.total_price.FillWeight = 105F;
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // ProductQtd
            // 
            this.ProductQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductQtd.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.ProductQtd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductQtd.Location = new System.Drawing.Point(7, 36);
            this.ProductQtd.Name = "ProductQtd";
            this.ProductQtd.Size = new System.Drawing.Size(60, 47);
            this.ProductQtd.TabIndex = 11;
            this.ProductQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductQtd_KeyPress);
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Search.Location = new System.Drawing.Point(73, 36);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1184, 47);
            this.Search.TabIndex = 10;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Search_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarChangeMode,
            this.viewSalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBarChangeMode
            // 
            this.menuBarChangeMode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBarChangeMode.ForeColor = System.Drawing.Color.White;
            this.menuBarChangeMode.Name = "menuBarChangeMode";
            this.menuBarChangeMode.Size = new System.Drawing.Size(120, 25);
            this.menuBarChangeMode.Text = "Change Mode";
            this.menuBarChangeMode.Click += new System.EventHandler(this.menuBarChangeMode_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.viewSalesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.viewSalesToolStripMenuItem.Text = "View Sales";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // btnSurcharge
            // 
            this.btnSurcharge.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSurcharge.Enabled = false;
            this.btnSurcharge.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSurcharge.FlatAppearance.BorderSize = 2;
            this.btnSurcharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurcharge.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurcharge.ForeColor = System.Drawing.Color.White;
            this.btnSurcharge.Location = new System.Drawing.Point(1052, 337);
            this.btnSurcharge.Name = "btnSurcharge";
            this.btnSurcharge.Size = new System.Drawing.Size(205, 68);
            this.btnSurcharge.TabIndex = 17;
            this.btnSurcharge.Text = "Surcharge";
            this.btnSurcharge.UseVisualStyleBackColor = false;
            this.btnSurcharge.Click += new System.EventHandler(this.btnSurcharge_Click);
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateQuantity.Enabled = false;
            this.btnUpdateQuantity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuantity.FlatAppearance.BorderSize = 2;
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateQuantity.Location = new System.Drawing.Point(1052, 485);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(205, 68);
            this.btnUpdateQuantity.TabIndex = 18;
            this.btnUpdateQuantity.Text = "Update Quantity";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDiscount.FlatAppearance.BorderSize = 2;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(1052, 411);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(205, 68);
            this.btnDiscount.TabIndex = 19;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnConclude
            // 
            this.btnConclude.BackColor = System.Drawing.Color.White;
            this.btnConclude.Enabled = false;
            this.btnConclude.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnConclude.FlatAppearance.BorderSize = 2;
            this.btnConclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConclude.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConclude.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConclude.Location = new System.Drawing.Point(1052, 559);
            this.btnConclude.Name = "btnConclude";
            this.btnConclude.Size = new System.Drawing.Size(205, 68);
            this.btnConclude.TabIndex = 21;
            this.btnConclude.Text = "Conclude";
            this.btnConclude.UseVisualStyleBackColor = false;
            this.btnConclude.Click += new System.EventHandler(this.btnConclude_Click);
            // 
            // LabelDayMonth
            // 
            this.LabelDayMonth.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.LabelDayMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelDayMonth.Location = new System.Drawing.Point(1052, 91);
            this.LabelDayMonth.Name = "LabelDayMonth";
            this.LabelDayMonth.Size = new System.Drawing.Size(205, 47);
            this.LabelDayMonth.TabIndex = 22;
            this.LabelDayMonth.Text = "00/00";
            this.LabelDayMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime
            // 
            this.LabelTime.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.LabelTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelTime.Location = new System.Drawing.Point(1052, 138);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(205, 47);
            this.LabelTime.TabIndex = 23;
            this.LabelTime.Text = "00:00:00";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(578, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 47);
            this.label5.TabIndex = 14;
            this.label5.Text = "Purchase Value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductsViewGrid
            // 
            this.ProductsViewGrid.AllowUserToAddRows = false;
            this.ProductsViewGrid.AllowUserToDeleteRows = false;
            this.ProductsViewGrid.AllowUserToResizeRows = false;
            this.ProductsViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsViewGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductsViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProductsViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsViewGrid.ColumnHeadersVisible = false;
            this.ProductsViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product_name,
            this.bar_code,
            this.sale_price,
            this.stock});
            this.ProductsViewGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsViewGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.ProductsViewGrid.GridColor = System.Drawing.Color.RoyalBlue;
            this.ProductsViewGrid.Location = new System.Drawing.Point(7, 91);
            this.ProductsViewGrid.MultiSelect = false;
            this.ProductsViewGrid.Name = "ProductsViewGrid";
            this.ProductsViewGrid.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProductsViewGrid.RowHeadersVisible = false;
            this.ProductsViewGrid.RowTemplate.Height = 80;
            this.ProductsViewGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductsViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsViewGrid.Size = new System.Drawing.Size(542, 664);
            this.ProductsViewGrid.TabIndex = 24;
            this.ProductsViewGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsViewGrid_CellDoubleClick);
            this.ProductsViewGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductsViewGrid_KeyDown);
            // 
            // id
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle7;
            this.id.FillWeight = 30F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // product_name
            // 
            this.product_name.FillWeight = 120F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // bar_code
            // 
            this.bar_code.FillWeight = 125F;
            this.bar_code.HeaderText = "Bar Code";
            this.bar_code.Name = "bar_code";
            this.bar_code.ReadOnly = true;
            this.bar_code.Visible = false;
            // 
            // sale_price
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sale_price.DefaultCellStyle = dataGridViewCellStyle8;
            this.sale_price.FillWeight = 95F;
            this.sale_price.HeaderText = "Sale Price";
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            // 
            // stock
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle9;
            this.stock.FillWeight = 50F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            // 
            // PaymentGroupBox
            // 
            this.PaymentGroupBox.Controls.Add(this.radioOther);
            this.PaymentGroupBox.Controls.Add(this.radioVoucher);
            this.PaymentGroupBox.Controls.Add(this.radioCredit);
            this.PaymentGroupBox.Controls.Add(this.radioPix);
            this.PaymentGroupBox.Controls.Add(this.radioDebit);
            this.PaymentGroupBox.Controls.Add(this.radioCash);
            this.PaymentGroupBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.PaymentGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PaymentGroupBox.Location = new System.Drawing.Point(1052, 633);
            this.PaymentGroupBox.Name = "PaymentGroupBox";
            this.PaymentGroupBox.Size = new System.Drawing.Size(205, 122);
            this.PaymentGroupBox.TabIndex = 26;
            this.PaymentGroupBox.TabStop = false;
            this.PaymentGroupBox.Text = "Payment";
            // 
            // radioOther
            // 
            this.radioOther.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioOther.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioOther.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioOther.Location = new System.Drawing.Point(116, 86);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(83, 30);
            this.radioOther.TabIndex = 5;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            // 
            // radioVoucher
            // 
            this.radioVoucher.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioVoucher.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioVoucher.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioVoucher.Location = new System.Drawing.Point(7, 86);
            this.radioVoucher.Name = "radioVoucher";
            this.radioVoucher.Size = new System.Drawing.Size(103, 30);
            this.radioVoucher.TabIndex = 4;
            this.radioVoucher.Text = "Voucher";
            this.radioVoucher.UseVisualStyleBackColor = true;
            // 
            // radioCredit
            // 
            this.radioCredit.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioCredit.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioCredit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioCredit.Location = new System.Drawing.Point(116, 56);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(83, 30);
            this.radioCredit.TabIndex = 3;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioPix
            // 
            this.radioPix.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioPix.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioPix.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioPix.Location = new System.Drawing.Point(116, 26);
            this.radioPix.Name = "radioPix";
            this.radioPix.Size = new System.Drawing.Size(69, 30);
            this.radioPix.TabIndex = 2;
            this.radioPix.Text = "Pix";
            this.radioPix.UseVisualStyleBackColor = true;
            // 
            // radioDebit
            // 
            this.radioDebit.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioDebit.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioDebit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDebit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioDebit.Location = new System.Drawing.Point(7, 56);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(89, 30);
            this.radioDebit.TabIndex = 1;
            this.radioDebit.Text = "Debit";
            this.radioDebit.UseVisualStyleBackColor = true;
            // 
            // radioCash
            // 
            this.radioCash.Checked = true;
            this.radioCash.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioCash.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioCash.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioCash.Location = new System.Drawing.Point(7, 26);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(89, 30);
            this.radioCash.TabIndex = 0;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1052, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 68);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.PaymentGroupBox);
            this.Controls.Add(this.ProductsViewGrid);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDayMonth);
            this.Controls.Add(this.btnConclude);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnUpdateQuantity);
            this.Controls.Add(this.btnSurcharge);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.FinalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductSaleGrid);
            this.Controls.Add(this.ProductQtd);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSaleGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsViewGrid)).EndInit();
            this.PaymentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label FinalPrice;
        private System.Windows.Forms.DataGridView ProductSaleGrid;
        private System.Windows.Forms.TextBox ProductQtd;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBarChangeMode;
        private System.Windows.Forms.Button btnSurcharge;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnConclude;
        private System.Windows.Forms.Label LabelDayMonth;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProductsViewGrid;
        private System.Windows.Forms.GroupBox PaymentGroupBox;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioPix;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioVoucher;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bar_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}