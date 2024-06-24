namespace BasicSales.SaleScreens
{
    partial class SalesDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDiscount));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.LabelDayMonth = new System.Windows.Forms.Label();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioPercent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnApply.Enabled = false;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(166, 184);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(148, 42);
            this.btnApply.TabIndex = 29;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel1.FlatAppearance.BorderSize = 2;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.White;
            this.btnCancel1.Location = new System.Drawing.Point(8, 184);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(148, 42);
            this.btnCancel1.TabIndex = 28;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // LabelDayMonth
            // 
            this.LabelDayMonth.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.LabelDayMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelDayMonth.Location = new System.Drawing.Point(59, 9);
            this.LabelDayMonth.Name = "LabelDayMonth";
            this.LabelDayMonth.Size = new System.Drawing.Size(205, 36);
            this.LabelDayMonth.TabIndex = 27;
            this.LabelDayMonth.Text = "Discount";
            this.LabelDayMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPercent
            // 
            this.numPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPercent.DecimalPlaces = 2;
            this.numPercent.Enabled = false;
            this.numPercent.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.numPercent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numPercent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPercent.Location = new System.Drawing.Point(153, 114);
            this.numPercent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPercent.Name = "numPercent";
            this.numPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numPercent.Size = new System.Drawing.Size(112, 36);
            this.numPercent.TabIndex = 32;
            this.numPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPercent.ValueChanged += new System.EventHandler(this.numPercent_ValueChanged);
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCash.Location = new System.Drawing.Point(153, 61);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(145, 40);
            this.txtCash.TabIndex = 30;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // radioCash
            // 
            this.radioCash.Checked = true;
            this.radioCash.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioCash.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioCash.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioCash.Location = new System.Drawing.Point(37, 66);
            this.radioCash.Name = "radioCash";
            this.radioCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCash.Size = new System.Drawing.Size(89, 30);
            this.radioCash.TabIndex = 33;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.radioCash_CheckedChanged);
            // 
            // radioPercent
            // 
            this.radioPercent.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.radioPercent.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.radioPercent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPercent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioPercent.Location = new System.Drawing.Point(25, 119);
            this.radioPercent.Name = "radioPercent";
            this.radioPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioPercent.Size = new System.Drawing.Size(101, 30);
            this.radioPercent.TabIndex = 34;
            this.radioPercent.Text = "Percent";
            this.radioPercent.UseVisualStyleBackColor = true;
            this.radioPercent.CheckedChanged += new System.EventHandler(this.radioPercent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(264, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "%";
            // 
            // SalesDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 234);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPercent);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.numPercent);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.LabelDayMonth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 273);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 273);
            this.Name = "SalesDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales - Discount";
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Label LabelDayMonth;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioPercent;
        private System.Windows.Forms.Label label1;
    }
}