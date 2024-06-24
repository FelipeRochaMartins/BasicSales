namespace BasicSales.ManagerScreens.Products
{
    partial class ListProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProduct));
            this.label2 = new System.Windows.Forms.Label();
            this.ListProduct_2 = new System.Windows.Forms.Button();
            this.AddProduct_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesExtract_2 = new System.Windows.Forms.Button();
            this.StockExtract_2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeMode_2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberProducts = new System.Windows.Forms.TextBox();
            this.txtListSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddToStock = new System.Windows.Forms.Button();
            this.ListProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsDataGrid)).BeginInit();
            this.SuspendLayout();
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
            // ListProduct_2
            // 
            this.ListProduct_2.BackColor = System.Drawing.Color.White;
            this.ListProduct_2.Enabled = false;
            this.ListProduct_2.FlatAppearance.BorderSize = 0;
            this.ListProduct_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ListProduct_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListProduct_2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProduct_2.ForeColor = System.Drawing.Color.Black;
            this.ListProduct_2.Location = new System.Drawing.Point(10, 104);
            this.ListProduct_2.Name = "ListProduct_2";
            this.ListProduct_2.Size = new System.Drawing.Size(180, 34);
            this.ListProduct_2.TabIndex = 5;
            this.ListProduct_2.Text = "List";
            this.ListProduct_2.UseVisualStyleBackColor = false;
            // 
            // AddProduct_2
            // 
            this.AddProduct_2.BackColor = System.Drawing.Color.White;
            this.AddProduct_2.FlatAppearance.BorderSize = 0;
            this.AddProduct_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddProduct_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct_2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct_2.ForeColor = System.Drawing.Color.Black;
            this.AddProduct_2.Location = new System.Drawing.Point(10, 144);
            this.AddProduct_2.Name = "AddProduct_2";
            this.AddProduct_2.Size = new System.Drawing.Size(180, 34);
            this.AddProduct_2.TabIndex = 2;
            this.AddProduct_2.Text = "Add";
            this.AddProduct_2.UseVisualStyleBackColor = false;
            this.AddProduct_2.Click += new System.EventHandler(this.AddProduct_2_Click);
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
            this.panel1.Controls.Add(this.SalesExtract_2);
            this.panel1.Controls.Add(this.StockExtract_2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListProduct_2);
            this.panel1.Controls.Add(this.AddProduct_2);
            this.panel1.Controls.Add(this.ChangeMode_2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 4;
            // 
            // SalesExtract_2
            // 
            this.SalesExtract_2.BackColor = System.Drawing.Color.White;
            this.SalesExtract_2.FlatAppearance.BorderSize = 0;
            this.SalesExtract_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SalesExtract_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesExtract_2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesExtract_2.ForeColor = System.Drawing.Color.Black;
            this.SalesExtract_2.Location = new System.Drawing.Point(10, 283);
            this.SalesExtract_2.Name = "SalesExtract_2";
            this.SalesExtract_2.Size = new System.Drawing.Size(180, 34);
            this.SalesExtract_2.TabIndex = 9;
            this.SalesExtract_2.Text = "Sales";
            this.SalesExtract_2.UseVisualStyleBackColor = false;
            this.SalesExtract_2.Click += new System.EventHandler(this.SalesExtract_2_Click);
            // 
            // StockExtract_2
            // 
            this.StockExtract_2.BackColor = System.Drawing.Color.White;
            this.StockExtract_2.FlatAppearance.BorderSize = 0;
            this.StockExtract_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.StockExtract_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockExtract_2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockExtract_2.ForeColor = System.Drawing.Color.Black;
            this.StockExtract_2.Location = new System.Drawing.Point(10, 245);
            this.StockExtract_2.Name = "StockExtract_2";
            this.StockExtract_2.Size = new System.Drawing.Size(180, 34);
            this.StockExtract_2.TabIndex = 8;
            this.StockExtract_2.Text = "Stock";
            this.StockExtract_2.UseVisualStyleBackColor = false;
            this.StockExtract_2.Click += new System.EventHandler(this.StockExtract_2_Click);
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
            // ChangeMode_2
            // 
            this.ChangeMode_2.BackColor = System.Drawing.Color.White;
            this.ChangeMode_2.FlatAppearance.BorderSize = 0;
            this.ChangeMode_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ChangeMode_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMode_2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeMode_2.ForeColor = System.Drawing.Color.Black;
            this.ChangeMode_2.Location = new System.Drawing.Point(10, 715);
            this.ChangeMode_2.Name = "ChangeMode_2";
            this.ChangeMode_2.Size = new System.Drawing.Size(180, 34);
            this.ChangeMode_2.TabIndex = 1;
            this.ChangeMode_2.Text = "Change Mode";
            this.ChangeMode_2.UseVisualStyleBackColor = false;
            this.ChangeMode_2.Click += new System.EventHandler(this.ChangeMode_2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(49, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "List the Products";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumberProducts);
            this.panel2.Controls.Add(this.txtListSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAddToStock);
            this.panel2.Controls.Add(this.ListProductsDataGrid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 761);
            this.panel2.TabIndex = 5;
            // 
            // NumberProducts
            // 
            this.NumberProducts.Enabled = false;
            this.NumberProducts.Font = new System.Drawing.Font("Calibri Light", 30F);
            this.NumberProducts.Location = new System.Drawing.Point(56, 685);
            this.NumberProducts.MaxLength = 20;
            this.NumberProducts.Name = "NumberProducts";
            this.NumberProducts.Size = new System.Drawing.Size(256, 56);
            this.NumberProducts.TabIndex = 38;
            this.NumberProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtListSearch
            // 
            this.txtListSearch.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListSearch.Location = new System.Drawing.Point(56, 87);
            this.txtListSearch.Name = "txtListSearch";
            this.txtListSearch.Size = new System.Drawing.Size(955, 40);
            this.txtListSearch.TabIndex = 36;
            this.txtListSearch.TextChanged += new System.EventHandler(this.txtListSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(853, 684);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 58);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddToStock.Enabled = false;
            this.btnAddToStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddToStock.FlatAppearance.BorderSize = 2;
            this.btnAddToStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToStock.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToStock.ForeColor = System.Drawing.Color.White;
            this.btnAddToStock.Location = new System.Drawing.Point(318, 684);
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.Size = new System.Drawing.Size(529, 58);
            this.btnAddToStock.TabIndex = 34;
            this.btnAddToStock.Text = "Add To Stock";
            this.btnAddToStock.UseVisualStyleBackColor = false;
            this.btnAddToStock.Click += new System.EventHandler(this.btnAddToStock_Click);
            // 
            // ListProductsDataGrid
            // 
            this.ListProductsDataGrid.AllowUserToAddRows = false;
            this.ListProductsDataGrid.AllowUserToDeleteRows = false;
            this.ListProductsDataGrid.AllowUserToResizeRows = false;
            this.ListProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListProductsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListProductsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product_name,
            this.bar_code,
            this.validity,
            this.purchase_price,
            this.sale_price,
            this.stock});
            this.ListProductsDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.ListProductsDataGrid.EnableHeadersVisualStyles = false;
            this.ListProductsDataGrid.GridColor = System.Drawing.Color.RoyalBlue;
            this.ListProductsDataGrid.Location = new System.Drawing.Point(56, 133);
            this.ListProductsDataGrid.MultiSelect = false;
            this.ListProductsDataGrid.Name = "ListProductsDataGrid";
            this.ListProductsDataGrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListProductsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ListProductsDataGrid.RowHeadersVisible = false;
            this.ListProductsDataGrid.RowTemplate.Height = 30;
            this.ListProductsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListProductsDataGrid.Size = new System.Drawing.Size(955, 545);
            this.ListProductsDataGrid.TabIndex = 1;
            this.ListProductsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListProductsDataGrid_CellDoubleClick);
            this.ListProductsDataGrid.SelectionChanged += new System.EventHandler(this.ListProductsDataGrid_SelectionChanged);
            // 
            // id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
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
            // 
            // validity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.validity.DefaultCellStyle = dataGridViewCellStyle3;
            this.validity.FillWeight = 80F;
            this.validity.HeaderText = "Validity";
            this.validity.Name = "validity";
            this.validity.ReadOnly = true;
            // 
            // purchase_price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.purchase_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.purchase_price.FillWeight = 95F;
            this.purchase_price.HeaderText = "Purchase Price";
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.ReadOnly = true;
            // 
            // sale_price
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sale_price.DefaultCellStyle = dataGridViewCellStyle5;
            this.sale_price.FillWeight = 95F;
            this.sale_price.HeaderText = "Sale Price";
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            // 
            // stock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle6;
            this.stock.FillWeight = 50F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // ListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager - List Products";
            this.Load += new System.EventHandler(this.ListProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListProduct_2;
        private System.Windows.Forms.Button AddProduct_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SalesExtract_2;
        private System.Windows.Forms.Button StockExtract_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeMode_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListProductsDataGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.TextBox txtListSearch;
        private System.Windows.Forms.TextBox NumberProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bar_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}