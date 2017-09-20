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
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateExpiry = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameBrand = new System.Windows.Forms.TextBox();
            this.comboBoxDoseType = new System.Windows.Forms.ComboBox();
            this.textBoxProductDose = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInventoryEncode
            // 
            this.buttonInventoryEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonInventoryEncode.FlatAppearance.BorderSize = 0;
            this.buttonInventoryEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryEncode.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonInventoryEncode.ForeColor = System.Drawing.Color.White;
            this.buttonInventoryEncode.Location = new System.Drawing.Point(10, 240);
            this.buttonInventoryEncode.Name = "buttonInventoryEncode";
            this.buttonInventoryEncode.Size = new System.Drawing.Size(337, 33);
            this.buttonInventoryEncode.TabIndex = 37;
            this.buttonInventoryEncode.Text = "Encode Transaction";
            this.buttonInventoryEncode.UseVisualStyleBackColor = false;
            this.buttonInventoryEncode.Click += new System.EventHandler(this.buttonInventoryEncode_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(130, 12);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(216, 27);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Required:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Expiry Date:";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(130, 80);
            this.textBoxManufacturer.Multiline = true;
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(217, 27);
            this.textBoxManufacturer.TabIndex = 2;
            // 
            // dateTimePickerDateExpiry
            // 
            this.dateTimePickerDateExpiry.Font = new System.Drawing.Font("Tw Cen MT", 9F);
            this.dateTimePickerDateExpiry.Location = new System.Drawing.Point(130, 214);
            this.dateTimePickerDateExpiry.Name = "dateTimePickerDateExpiry";
            this.dateTimePickerDateExpiry.Size = new System.Drawing.Size(217, 21);
            this.dateTimePickerDateExpiry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Brand Name:";
            // 
            // textBoxNameBrand
            // 
            this.textBoxNameBrand.Location = new System.Drawing.Point(130, 47);
            this.textBoxNameBrand.Multiline = true;
            this.textBoxNameBrand.Name = "textBoxNameBrand";
            this.textBoxNameBrand.Size = new System.Drawing.Size(217, 27);
            this.textBoxNameBrand.TabIndex = 1;
            // 
            // comboBoxDoseType
            // 
            this.comboBoxDoseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoseType.FormattingEnabled = true;
            this.comboBoxDoseType.Items.AddRange(new object[] {
            "mg",
            "mL",
            "g",
            "L"});
            this.comboBoxDoseType.Location = new System.Drawing.Point(284, 181);
            this.comboBoxDoseType.Name = "comboBoxDoseType";
            this.comboBoxDoseType.Size = new System.Drawing.Size(62, 27);
            this.comboBoxDoseType.TabIndex = 4;
            // 
            // textBoxProductDose
            // 
            this.textBoxProductDose.Location = new System.Drawing.Point(130, 181);
            this.textBoxProductDose.Multiline = true;
            this.textBoxProductDose.Name = "textBoxProductDose";
            this.textBoxProductDose.Size = new System.Drawing.Size(149, 27);
            this.textBoxProductDose.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Dosage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Product Quantity:";
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Location = new System.Drawing.Point(130, 113);
            this.textBoxProductQuantity.Multiline = true;
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(217, 27);
            this.textBoxProductQuantity.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Batch #:";
            // 
            // textBoxBatch
            // 
            this.textBoxBatch.Location = new System.Drawing.Point(130, 146);
            this.textBoxBatch.Multiline = true;
            this.textBoxBatch.Name = "textBoxBatch";
            this.textBoxBatch.Size = new System.Drawing.Size(217, 27);
            this.textBoxBatch.TabIndex = 56;
            // 
            // formTransactionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProductQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDoseType);
            this.Controls.Add(this.textBoxProductDose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateExpiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.buttonInventoryEncode);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBatch);
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
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameBrand;
        private System.Windows.Forms.ComboBox comboBoxDoseType;
        private System.Windows.Forms.TextBox textBoxProductDose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProductQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBatch;
    }
}