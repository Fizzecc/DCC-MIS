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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTransactionNew = new System.Windows.Forms.Button();
            this.buttonStockOut = new System.Windows.Forms.Button();
            this.labelNormal = new System.Windows.Forms.Label();
            this.labelReturned = new System.Windows.Forms.Label();
            this.labelDamaged = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNonNormal = new System.Windows.Forms.Label();
            this.labelNonUnderRepair = new System.Windows.Forms.Label();
            this.labelNonDamaged = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCascade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.buttonProductNew.Location = new System.Drawing.Point(1128, 426);
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
            this.dataGridViewInventory.Size = new System.Drawing.Size(1106, 820);
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
            this.buttonServiceNew.Location = new System.Drawing.Point(1128, 580);
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
            this.buttonRefresh.Location = new System.Drawing.Point(1128, 395);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(189, 25);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Refresh Tables";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item Status Summary";
            // 
            // buttonTransactionNew
            // 
            this.buttonTransactionNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransactionNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.verified_list_of_exercises_of_a_gymnast_on_a_clipboard;
            this.buttonTransactionNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransactionNew.FlatAppearance.BorderSize = 0;
            this.buttonTransactionNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonTransactionNew.Location = new System.Drawing.Point(1232, 444);
            this.buttonTransactionNew.Name = "buttonTransactionNew";
            this.buttonTransactionNew.Size = new System.Drawing.Size(79, 130);
            this.buttonTransactionNew.TabIndex = 26;
            this.buttonTransactionNew.Text = "Encode Transaction";
            this.buttonTransactionNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransactionNew.UseVisualStyleBackColor = false;
            this.buttonTransactionNew.Click += new System.EventHandler(this.buttonTransactionNew_Click);
            // 
            // buttonStockOut
            // 
            this.buttonStockOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonStockOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStockOut.FlatAppearance.BorderSize = 0;
            this.buttonStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockOut.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonStockOut.Location = new System.Drawing.Point(1234, 598);
            this.buttonStockOut.Name = "buttonStockOut";
            this.buttonStockOut.Size = new System.Drawing.Size(77, 97);
            this.buttonStockOut.TabIndex = 32;
            this.buttonStockOut.Text = "Perform Stockout";
            this.buttonStockOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStockOut.UseVisualStyleBackColor = false;
            this.buttonStockOut.Click += new System.EventHandler(this.buttonStockOut_Click);
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(9, 21);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(82, 19);
            this.labelNormal.TabIndex = 35;
            this.labelNormal.Text = "Normal: 99";
            // 
            // labelReturned
            // 
            this.labelReturned.AutoSize = true;
            this.labelReturned.Location = new System.Drawing.Point(9, 40);
            this.labelReturned.Name = "labelReturned";
            this.labelReturned.Size = new System.Drawing.Size(91, 19);
            this.labelReturned.TabIndex = 36;
            this.labelReturned.Text = "Returned: 99";
            // 
            // labelDamaged
            // 
            this.labelDamaged.AutoSize = true;
            this.labelDamaged.Location = new System.Drawing.Point(9, 59);
            this.labelDamaged.Name = "labelDamaged";
            this.labelDamaged.Size = new System.Drawing.Size(100, 19);
            this.labelDamaged.TabIndex = 37;
            this.labelDamaged.Text = "Damaged: 99";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNormal);
            this.groupBox1.Controls.Add(this.labelReturned);
            this.groupBox1.Controls.Add(this.labelDamaged);
            this.groupBox1.Location = new System.Drawing.Point(1128, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 104);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumables";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNonNormal);
            this.groupBox2.Controls.Add(this.labelNonUnderRepair);
            this.groupBox2.Controls.Add(this.labelNonDamaged);
            this.groupBox2.Location = new System.Drawing.Point(1128, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 104);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Non-consumables";
            // 
            // labelNonNormal
            // 
            this.labelNonNormal.AutoSize = true;
            this.labelNonNormal.Location = new System.Drawing.Point(9, 21);
            this.labelNonNormal.Name = "labelNonNormal";
            this.labelNonNormal.Size = new System.Drawing.Size(82, 19);
            this.labelNonNormal.TabIndex = 35;
            this.labelNonNormal.Text = "Normal: 99";
            // 
            // labelNonUnderRepair
            // 
            this.labelNonUnderRepair.AutoSize = true;
            this.labelNonUnderRepair.Location = new System.Drawing.Point(9, 40);
            this.labelNonUnderRepair.Name = "labelNonUnderRepair";
            this.labelNonUnderRepair.Size = new System.Drawing.Size(120, 19);
            this.labelNonUnderRepair.TabIndex = 36;
            this.labelNonUnderRepair.Text = "Under Repair: 99";
            // 
            // labelNonDamaged
            // 
            this.labelNonDamaged.AutoSize = true;
            this.labelNonDamaged.Location = new System.Drawing.Point(9, 59);
            this.labelNonDamaged.Name = "labelNonDamaged";
            this.labelNonDamaged.Size = new System.Drawing.Size(100, 19);
            this.labelNonDamaged.TabIndex = 37;
            this.labelNonDamaged.Text = "Damaged: 99";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "All Items",
            "Generic Name",
            "Brand Name",
            "Expiration Date"});
            this.comboBoxSort.Location = new System.Drawing.Point(10, 43);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(169, 27);
            this.comboBoxSort.TabIndex = 41;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Sort Table By:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(10, 95);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(169, 25);
            this.textBoxSearch.TabIndex = 43;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Search Item:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxCascade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.comboBoxSort);
            this.groupBox3.Location = new System.Drawing.Point(1128, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 138);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort";
            // 
            // checkBoxCascade
            // 
            this.checkBoxCascade.AutoSize = true;
            this.checkBoxCascade.Location = new System.Drawing.Point(94, 72);
            this.checkBoxCascade.Name = "checkBoxCascade";
            this.checkBoxCascade.Size = new System.Drawing.Size(84, 23);
            this.checkBoxCascade.TabIndex = 45;
            this.checkBoxCascade.Text = "Cascade";
            this.checkBoxCascade.UseVisualStyleBackColor = true;
            this.checkBoxCascade.CheckedChanged += new System.EventHandler(this.checkBoxCascade_CheckedChanged);
            // 
            // formModule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 862);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStockOut);
            this.Controls.Add(this.label2);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProductNew;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServiceNew;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTransactionNew;
        private System.Windows.Forms.Button buttonStockOut;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelReturned;
        private System.Windows.Forms.Label labelDamaged;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNonNormal;
        private System.Windows.Forms.Label labelNonUnderRepair;
        private System.Windows.Forms.Label labelNonDamaged;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxCascade;
    }
}