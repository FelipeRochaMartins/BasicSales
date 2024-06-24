namespace BasicSales
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpiringList = new System.Windows.Forms.ListBox();
            this.LabelActualDay = new System.Windows.Forms.Label();
            this.LabelActualHour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesExtract = new System.Windows.Forms.Button();
            this.StockExtract = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ExpiringList);
            this.panel2.Controls.Add(this.LabelActualDay);
            this.panel2.Controls.Add(this.LabelActualHour);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 761);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(43, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 41);
            this.label7.TabIndex = 13;
            this.label7.Text = "Products Close to Expiration";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExpiringList
            // 
            this.ExpiringList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpiringList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExpiringList.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.ExpiringList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ExpiringList.FormattingEnabled = true;
            this.ExpiringList.ItemHeight = 50;
            this.ExpiringList.Location = new System.Drawing.Point(50, 385);
            this.ExpiringList.Name = "ExpiringList";
            this.ExpiringList.Size = new System.Drawing.Size(972, 300);
            this.ExpiringList.TabIndex = 4;
            this.ExpiringList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ExpiringList_DrawItem);
            // 
            // LabelActualDay
            // 
            this.LabelActualDay.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelActualDay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelActualDay.Location = new System.Drawing.Point(288, 197);
            this.LabelActualDay.Name = "LabelActualDay";
            this.LabelActualDay.Size = new System.Drawing.Size(489, 59);
            this.LabelActualDay.TabIndex = 3;
            this.LabelActualDay.Text = "00/00/0000";
            this.LabelActualDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelActualHour
            // 
            this.LabelActualHour.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelActualHour.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelActualHour.Location = new System.Drawing.Point(288, 242);
            this.LabelActualHour.Name = "LabelActualHour";
            this.LabelActualHour.Size = new System.Drawing.Size(489, 59);
            this.LabelActualHour.TabIndex = 2;
            this.LabelActualHour.Text = "00:00:00";
            this.LabelActualHour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(292, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 119);
            this.label6.TabIndex = 1;
            this.label6.Text = "This application allows you to manage your small business in an easy and intuitiv" +
    "e way.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(282, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 59);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome to Basic Sale!";
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
            // 
            // ChangeMode
            // 
            this.ChangeMode.BackColor = System.Drawing.Color.White;
            this.ChangeMode.FlatAppearance.BorderSize = 0;
            this.ChangeMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ChangeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeMode.ForeColor = System.Drawing.Color.Black;
            this.ChangeMode.Location = new System.Drawing.Point(10, 715);
            this.ChangeMode.Name = "ChangeMode";
            this.ChangeMode.Size = new System.Drawing.Size(180, 34);
            this.ChangeMode.TabIndex = 1;
            this.ChangeMode.Text = "Change Mode";
            this.ChangeMode.UseVisualStyleBackColor = false;
            this.ChangeMode.Click += new System.EventHandler(this.ChangeMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.SalesExtract);
            this.panel1.Controls.Add(this.StockExtract);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListProduct);
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Controls.Add(this.ChangeMode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 0;
            // 
            // SalesExtract
            // 
            this.SalesExtract.BackColor = System.Drawing.Color.White;
            this.SalesExtract.FlatAppearance.BorderSize = 0;
            this.SalesExtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SalesExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesExtract.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesExtract.ForeColor = System.Drawing.Color.Black;
            this.SalesExtract.Location = new System.Drawing.Point(10, 283);
            this.SalesExtract.Name = "SalesExtract";
            this.SalesExtract.Size = new System.Drawing.Size(180, 34);
            this.SalesExtract.TabIndex = 9;
            this.SalesExtract.Text = "Sales";
            this.SalesExtract.UseVisualStyleBackColor = false;
            this.SalesExtract.Click += new System.EventHandler(this.SalesExtract_Click);
            // 
            // StockExtract
            // 
            this.StockExtract.BackColor = System.Drawing.Color.White;
            this.StockExtract.FlatAppearance.BorderSize = 0;
            this.StockExtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.StockExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockExtract.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockExtract.ForeColor = System.Drawing.Color.Black;
            this.StockExtract.Location = new System.Drawing.Point(10, 245);
            this.StockExtract.Name = "StockExtract";
            this.StockExtract.Size = new System.Drawing.Size(180, 34);
            this.StockExtract.TabIndex = 8;
            this.StockExtract.Text = "Stock";
            this.StockExtract.UseVisualStyleBackColor = false;
            this.StockExtract.Click += new System.EventHandler(this.StockExtract_Click);
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
            // ListProduct
            // 
            this.ListProduct.BackColor = System.Drawing.Color.White;
            this.ListProduct.FlatAppearance.BorderSize = 0;
            this.ListProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ListProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProduct.ForeColor = System.Drawing.Color.Black;
            this.ListProduct.Location = new System.Drawing.Point(10, 104);
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(180, 34);
            this.ListProduct.TabIndex = 5;
            this.ListProduct.Text = "List";
            this.ListProduct.UseVisualStyleBackColor = false;
            this.ListProduct.Click += new System.EventHandler(this.ListProduct_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.White;
            this.AddProduct.FlatAppearance.BorderSize = 0;
            this.AddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.Color.Black;
            this.AddProduct.Location = new System.Drawing.Point(10, 144);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(180, 34);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListProduct;
        private System.Windows.Forms.Button SalesExtract;
        private System.Windows.Forms.Button StockExtract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelActualHour;
        private System.Windows.Forms.Label LabelActualDay;
        private System.Windows.Forms.ListBox ExpiringList;
        private System.Windows.Forms.Label label7;
    }
}

