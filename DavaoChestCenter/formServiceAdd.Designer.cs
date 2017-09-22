namespace DavaoChestCenter
{
    partial class formServiceAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServiceType = new System.Windows.Forms.TextBox();
            this.textBoxServiceDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonServiceCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxExtra = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Service Details:";
            // 
            // textBoxServiceType
            // 
            this.textBoxServiceType.Location = new System.Drawing.Point(133, 39);
            this.textBoxServiceType.Multiline = true;
            this.textBoxServiceType.Name = "textBoxServiceType";
            this.textBoxServiceType.Size = new System.Drawing.Size(203, 27);
            this.textBoxServiceType.TabIndex = 21;
            // 
            // textBoxServiceDetails
            // 
            this.textBoxServiceDetails.Location = new System.Drawing.Point(133, 72);
            this.textBoxServiceDetails.Multiline = true;
            this.textBoxServiceDetails.Name = "textBoxServiceDetails";
            this.textBoxServiceDetails.Size = new System.Drawing.Size(203, 27);
            this.textBoxServiceDetails.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Service Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Service Type:";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(133, 6);
            this.textBoxServiceName.Multiline = true;
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(203, 27);
            this.textBoxServiceName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Product Required:";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(133, 103);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(203, 27);
            this.comboBoxItems.TabIndex = 27;
            // 
            // buttonServiceCreate
            // 
            this.buttonServiceCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonServiceCreate.FlatAppearance.BorderSize = 0;
            this.buttonServiceCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServiceCreate.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonServiceCreate.ForeColor = System.Drawing.Color.White;
            this.buttonServiceCreate.Location = new System.Drawing.Point(16, 359);
            this.buttonServiceCreate.Name = "buttonServiceCreate";
            this.buttonServiceCreate.Size = new System.Drawing.Size(320, 33);
            this.buttonServiceCreate.TabIndex = 28;
            this.buttonServiceCreate.Text = "Create Service";
            this.buttonServiceCreate.UseVisualStyleBackColor = false;
            this.buttonServiceCreate.Click += new System.EventHandler(this.buttonServiceCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quantity Req:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(133, 136);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(203, 27);
            this.textBoxQuantity.TabIndex = 30;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.comboBoxExtra);
            this.flowLayoutPanel.Controls.Add(this.textBox1);
            this.flowLayoutPanel.Location = new System.Drawing.Point(16, 202);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(320, 151);
            this.flowLayoutPanel.TabIndex = 31;
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(295, 169);
            this.textBoxOther.Multiline = true;
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(41, 27);
            this.textBoxOther.TabIndex = 33;
            this.textBoxOther.TextChanged += new System.EventHandler(this.textBoxQuantityOther_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "#:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Other Products Required:";
            // 
            // comboBoxExtra
            // 
            this.comboBoxExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtra.FormattingEnabled = true;
            this.comboBoxExtra.Location = new System.Drawing.Point(3, 3);
            this.comboBoxExtra.Name = "comboBoxExtra";
            this.comboBoxExtra.Size = new System.Drawing.Size(203, 27);
            this.comboBoxExtra.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 27);
            this.textBox1.TabIndex = 34;
            // 
            // formServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonServiceCreate);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServiceType);
            this.Controls.Add(this.textBoxServiceDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServiceName);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formServiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Service";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServiceType;
        private System.Windows.Forms.TextBox textBoxServiceDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonServiceCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxExtra;
        private System.Windows.Forms.TextBox textBox1;
    }
}