namespace DavaoChestCenter
{
    partial class formModule2
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
            this.buttonProductNew = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonServiceNew = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTransactionNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewRequired = new System.Windows.Forms.DataGridView();
            this.buttonStockOut = new System.Windows.Forms.Button();
            this.checkBoxCascade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProductNew
            // 
            this.buttonProductNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.buttonProductNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductNew.FlatAppearance.BorderSize = 0;
            this.buttonProductNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonProductNew.Location = new System.Drawing.Point(12, 702);
            this.buttonProductNew.Name = "buttonProductNew";
            this.buttonProductNew.Size = new System.Drawing.Size(76, 148);
            this.buttonProductNew.TabIndex = 5;
            this.buttonProductNew.Text = "Encode Product";
            this.buttonProductNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProductNew.UseVisualStyleBackColor = false;
            this.buttonProductNew.Click += new System.EventHandler(this.buttonProductNew_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.Size = new System.Drawing.Size(835, 666);
            this.dataGridViewInventory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inventory";
            // 
            // buttonServiceNew
            // 
            this.buttonServiceNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonServiceNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.buttonServiceNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonServiceNew.FlatAppearance.BorderSize = 0;
            this.buttonServiceNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServiceNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonServiceNew.Location = new System.Drawing.Point(94, 702);
            this.buttonServiceNew.Name = "buttonServiceNew";
            this.buttonServiceNew.Size = new System.Drawing.Size(76, 148);
            this.buttonServiceNew.TabIndex = 12;
            this.buttonServiceNew.Text = "Add New Service";
            this.buttonServiceNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonServiceNew.UseVisualStyleBackColor = false;
            this.buttonServiceNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 702);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(145, 25);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Refresh Tables";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(853, 30);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(464, 386);
            this.dataGridViewProduct.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Products";
            // 
            // buttonTransactionNew
            // 
            this.buttonTransactionNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransactionNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.verified_list_of_exercises_of_a_gymnast_on_a_clipboard;
            this.buttonTransactionNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransactionNew.FlatAppearance.BorderSize = 0;
            this.buttonTransactionNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonTransactionNew.Location = new System.Drawing.Point(176, 720);
            this.buttonTransactionNew.Name = "buttonTransactionNew";
            this.buttonTransactionNew.Size = new System.Drawing.Size(79, 130);
            this.buttonTransactionNew.TabIndex = 26;
            this.buttonTransactionNew.Text = "Encode Transaction";
            this.buttonTransactionNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransactionNew.UseVisualStyleBackColor = false;
            this.buttonTransactionNew.Click += new System.EventHandler(this.buttonTransactionNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Products out of stock";
            // 
            // dataGridViewRequired
            // 
            this.dataGridViewRequired.AllowUserToAddRows = false;
            this.dataGridViewRequired.AllowUserToDeleteRows = false;
            this.dataGridViewRequired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequired.Location = new System.Drawing.Point(853, 441);
            this.dataGridViewRequired.Name = "dataGridViewRequired";
            this.dataGridViewRequired.ReadOnly = true;
            this.dataGridViewRequired.RowHeadersVisible = false;
            this.dataGridViewRequired.Size = new System.Drawing.Size(464, 255);
            this.dataGridViewRequired.TabIndex = 30;
            // 
            // buttonStockOut
            // 
            this.buttonStockOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonStockOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStockOut.FlatAppearance.BorderSize = 0;
            this.buttonStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockOut.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonStockOut.Location = new System.Drawing.Point(261, 753);
            this.buttonStockOut.Name = "buttonStockOut";
            this.buttonStockOut.Size = new System.Drawing.Size(77, 97);
            this.buttonStockOut.TabIndex = 32;
            this.buttonStockOut.Text = "Perform Stockout";
            this.buttonStockOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStockOut.UseVisualStyleBackColor = false;
            this.buttonStockOut.Click += new System.EventHandler(this.buttonStockOut_Click);
            // 
            // checkBoxCascade
            // 
            this.checkBoxCascade.AutoSize = true;
            this.checkBoxCascade.Location = new System.Drawing.Point(163, 704);
            this.checkBoxCascade.Name = "checkBoxCascade";
            this.checkBoxCascade.Size = new System.Drawing.Size(120, 23);
            this.checkBoxCascade.TabIndex = 33;
            this.checkBoxCascade.Text = "Cascade View";
            this.checkBoxCascade.UseVisualStyleBackColor = true;
            this.checkBoxCascade.CheckedChanged += new System.EventHandler(this.checkBoxCascade_CheckedChanged);
            // 
            // formModule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 862);
            this.Controls.Add(this.checkBoxCascade);
            this.Controls.Add(this.buttonStockOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRequired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.buttonProductNew);
            this.Controls.Add(this.buttonServiceNew);
            this.Controls.Add(this.buttonTransactionNew);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formModule2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProductNew;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServiceNew;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTransactionNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewRequired;
        private System.Windows.Forms.Button buttonStockOut;
        private System.Windows.Forms.CheckBox checkBoxCascade;
    }
}