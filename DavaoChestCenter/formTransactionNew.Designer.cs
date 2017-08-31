namespace DavaoChestCenter
{
    partial class formTransactionNew
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
            this.buttonInventoryEncode = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateExpiry = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProductStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInventoryEncode
            // 
            this.buttonInventoryEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonInventoryEncode.FlatAppearance.BorderSize = 0;
            this.buttonInventoryEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryEncode.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonInventoryEncode.ForeColor = System.Drawing.Color.White;
            this.buttonInventoryEncode.Location = new System.Drawing.Point(12, 138);
            this.buttonInventoryEncode.Name = "buttonInventoryEncode";
            this.buttonInventoryEncode.Size = new System.Drawing.Size(334, 33);
            this.buttonInventoryEncode.TabIndex = 37;
            this.buttonInventoryEncode.Text = "Encode Transaction";
            this.buttonInventoryEncode.UseVisualStyleBackColor = false;
            this.buttonInventoryEncode.Click += new System.EventHandler(this.buttonInventoryEncode_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(129, 12);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(217, 27);
            this.comboBoxProducts.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Required:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Expiry Date:";
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Location = new System.Drawing.Point(129, 76);
            this.textBoxProductQuantity.Multiline = true;
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(217, 27);
            this.textBoxProductQuantity.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Product Status:";
            // 
            // dateTimePickerDateExpiry
            // 
            this.dateTimePickerDateExpiry.Font = new System.Drawing.Font("Tw Cen MT", 9F);
            this.dateTimePickerDateExpiry.Location = new System.Drawing.Point(129, 108);
            this.dateTimePickerDateExpiry.Name = "dateTimePickerDateExpiry";
            this.dateTimePickerDateExpiry.Size = new System.Drawing.Size(217, 21);
            this.dateTimePickerDateExpiry.TabIndex = 44;
            // 
            // comboBoxProductStatus
            // 
            this.comboBoxProductStatus.FormattingEnabled = true;
            this.comboBoxProductStatus.Items.AddRange(new object[] {
            "Normal",
            "Returned",
            "Damaged",
            "Expired"});
            this.comboBoxProductStatus.Location = new System.Drawing.Point(129, 43);
            this.comboBoxProductStatus.Name = "comboBoxProductStatus";
            this.comboBoxProductStatus.Size = new System.Drawing.Size(217, 27);
            this.comboBoxProductStatus.TabIndex = 45;
            this.comboBoxProductStatus.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Product Quantity:";
            // 
            // formTransactionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProductStatus);
            this.Controls.Add(this.dateTimePickerDateExpiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInventoryEncode);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTransactionNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInventoryEncode;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiry;
        private System.Windows.Forms.ComboBox comboBoxProductStatus;
        private System.Windows.Forms.Label label1;
    }
}