namespace BasicSales.SaleScreens
{
    partial class SalesSurcharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesSurcharge));
            this.SurchargeValue = new System.Windows.Forms.TextBox();
            this.LabelDayMonth = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSurcharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurchargeValue
            // 
            this.SurchargeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurchargeValue.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurchargeValue.Location = new System.Drawing.Point(89, 55);
            this.SurchargeValue.MaxLength = 5;
            this.SurchargeValue.Name = "SurchargeValue";
            this.SurchargeValue.Size = new System.Drawing.Size(145, 47);
            this.SurchargeValue.TabIndex = 11;
            this.SurchargeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SurchargeValue.TextChanged += new System.EventHandler(this.SurchargeValue_TextChanged);
            this.SurchargeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurchargeValue_KeyPress);
            // 
            // LabelDayMonth
            // 
            this.LabelDayMonth.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.LabelDayMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelDayMonth.Location = new System.Drawing.Point(59, 9);
            this.LabelDayMonth.Name = "LabelDayMonth";
            this.LabelDayMonth.Size = new System.Drawing.Size(205, 36);
            this.LabelDayMonth.TabIndex = 23;
            this.LabelDayMonth.Text = "Surcharge";
            this.LabelDayMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(8, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 42);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSurcharge.Location = new System.Drawing.Point(166, 112);
            this.btnSurcharge.Name = "btnSurcharge";
            this.btnSurcharge.Size = new System.Drawing.Size(148, 42);
            this.btnSurcharge.TabIndex = 25;
            this.btnSurcharge.Text = "Surcharge";
            this.btnSurcharge.UseVisualStyleBackColor = false;
            this.btnSurcharge.Click += new System.EventHandler(this.btnSurcharge_Click);
            // 
            // SalesSurcharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btnSurcharge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.LabelDayMonth);
            this.Controls.Add(this.SurchargeValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 201);
            this.MinimumSize = new System.Drawing.Size(338, 201);
            this.Name = "SalesSurcharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales - Surcharge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurchargeValue;
        private System.Windows.Forms.Label LabelDayMonth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSurcharge;
    }
}