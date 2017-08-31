namespace DavaoChestCenter
{
    partial class formProductNew
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
            this.textBoxProductType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonProductEncode = new System.Windows.Forms.Button();
            this.textBoxProductMinimum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProductType
            // 
            this.textBoxProductType.Location = new System.Drawing.Point(133, 39);
            this.textBoxProductType.Multiline = true;
            this.textBoxProductType.Name = "textBoxProductType";
            this.textBoxProductType.Size = new System.Drawing.Size(203, 27);
            this.textBoxProductType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Type:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(133, 6);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(203, 27);
            this.textBoxProductName.TabIndex = 0;
            // 
            // buttonProductEncode
            // 
            this.buttonProductEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonProductEncode.FlatAppearance.BorderSize = 0;
            this.buttonProductEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductEncode.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonProductEncode.ForeColor = System.Drawing.Color.White;
            this.buttonProductEncode.Location = new System.Drawing.Point(16, 105);
            this.buttonProductEncode.Name = "buttonProductEncode";
            this.buttonProductEncode.Size = new System.Drawing.Size(320, 33);
            this.buttonProductEncode.TabIndex = 3;
            this.buttonProductEncode.Text = "Encode Product";
            this.buttonProductEncode.UseVisualStyleBackColor = false;
            this.buttonProductEncode.Click += new System.EventHandler(this.buttonProductEncode_Click);
            // 
            // textBoxProductMinimum
            // 
            this.textBoxProductMinimum.Location = new System.Drawing.Point(133, 72);
            this.textBoxProductMinimum.Multiline = true;
            this.textBoxProductMinimum.Name = "textBoxProductMinimum";
            this.textBoxProductMinimum.Size = new System.Drawing.Size(203, 27);
            this.textBoxProductMinimum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Minimum #:";
            // 
            // formProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 143);
            this.Controls.Add(this.textBoxProductMinimum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonProductEncode);
            this.Controls.Add(this.textBoxProductType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formProductNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProductType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonProductEncode;
        private System.Windows.Forms.TextBox textBoxProductMinimum;
        private System.Windows.Forms.Label label3;
    }
}