﻿namespace DavaoChestCenter
{
    partial class formAppointment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAppoint = new System.Windows.Forms.Button();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 298);
            this.dataGridView1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tw Cen MT", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 24);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appointment Date:";
            // 
            // buttonAppoint
            // 
            this.buttonAppoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonAppoint.FlatAppearance.BorderSize = 0;
            this.buttonAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppoint.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.buttonAppoint.ForeColor = System.Drawing.Color.White;
            this.buttonAppoint.Location = new System.Drawing.Point(324, 363);
            this.buttonAppoint.Name = "buttonAppoint";
            this.buttonAppoint.Size = new System.Drawing.Size(124, 32);
            this.buttonAppoint.TabIndex = 18;
            this.buttonAppoint.Text = "Appoint";
            this.buttonAppoint.UseVisualStyleBackColor = false;
            this.buttonAppoint.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(15, 363);
            this.textBoxService.Multiline = true;
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(303, 32);
            this.textBoxService.TabIndex = 19;
            this.textBoxService.Text = "indicate service here";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // formAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.buttonAppoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAppoint;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Label labelName;
    }
}