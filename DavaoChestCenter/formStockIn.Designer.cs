﻿namespace DavaoChestCenter
{
    partial class formStockIn
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
            this.dataGridViewRequired = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequired
            // 
            this.dataGridViewRequired.AllowUserToAddRows = false;
            this.dataGridViewRequired.AllowUserToDeleteRows = false;
            this.dataGridViewRequired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequired.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRequired.Name = "dataGridViewRequired";
            this.dataGridViewRequired.ReadOnly = true;
            this.dataGridViewRequired.RowHeadersVisible = false;
            this.dataGridViewRequired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequired.Size = new System.Drawing.Size(688, 339);
            this.dataGridViewRequired.TabIndex = 7;
            this.dataGridViewRequired.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequired_CellClick);
            // 
            // formStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 478);
            this.Controls.Add(this.dataGridViewRequired);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formStockIn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequired)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequired;
    }
}