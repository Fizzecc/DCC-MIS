namespace DavaoChestCenter
{
    partial class formTransactionEdit
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
            this.comboBoxProductStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInventoryEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxProductStatus
            // 
            this.comboBoxProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductStatus.FormattingEnabled = true;
            this.comboBoxProductStatus.Items.AddRange(new object[] {
            "Normal",
            "Returned",
            "Damaged",
            "Expired"});
            this.comboBoxProductStatus.Location = new System.Drawing.Point(131, 43);
            this.comboBoxProductStatus.Name = "comboBoxProductStatus";
            this.comboBoxProductStatus.Size = new System.Drawing.Size(217, 27);
            this.comboBoxProductStatus.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Product Status:";
            // 
            // buttonInventoryEncode
            // 
            this.buttonInventoryEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonInventoryEncode.FlatAppearance.BorderSize = 0;
            this.buttonInventoryEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryEncode.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonInventoryEncode.ForeColor = System.Drawing.Color.White;
            this.buttonInventoryEncode.Location = new System.Drawing.Point(14, 76);
            this.buttonInventoryEncode.Name = "buttonInventoryEncode";
            this.buttonInventoryEncode.Size = new System.Drawing.Size(334, 33);
            this.buttonInventoryEncode.TabIndex = 49;
            this.buttonInventoryEncode.Text = "Encode Transaction";
            this.buttonInventoryEncode.UseVisualStyleBackColor = false;
            this.buttonInventoryEncode.Click += new System.EventHandler(this.buttonInventoryEncode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Product Required:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product Required:";
            // 
            // formTransactionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProductStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInventoryEncode);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTransactionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProductStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInventoryEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}