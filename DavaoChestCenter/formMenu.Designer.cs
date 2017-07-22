namespace DavaoChestCenter
{
    partial class formMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonModule1 = new System.Windows.Forms.Button();
            this.buttonModule2 = new System.Windows.Forms.Button();
            this.buttonModule3 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchedules = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPatientNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonProductNew = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonModule1);
            this.flowLayoutPanel1.Controls.Add(this.buttonModule2);
            this.flowLayoutPanel1.Controls.Add(this.buttonModule3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(463, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 219);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonModule1
            // 
            this.buttonModule1.BackColor = System.Drawing.Color.Transparent;
            this.buttonModule1.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.buttonModule1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule1.FlatAppearance.BorderSize = 0;
            this.buttonModule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule1.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonModule1.Location = new System.Drawing.Point(3, 3);
            this.buttonModule1.Name = "buttonModule1";
            this.buttonModule1.Size = new System.Drawing.Size(91, 172);
            this.buttonModule1.TabIndex = 4;
            this.buttonModule1.Text = "MODULE 1 V0.2";
            this.buttonModule1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModule1.UseVisualStyleBackColor = false;
            this.buttonModule1.Click += new System.EventHandler(this.buttonModule1_Click);
            // 
            // buttonModule2
            // 
            this.buttonModule2.BackColor = System.Drawing.Color.Transparent;
            this.buttonModule2.BackgroundImage = global::DavaoChestCenter.Properties.Resources.verified_list_of_exercises_of_a_gymnast_on_a_clipboard;
            this.buttonModule2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule2.FlatAppearance.BorderSize = 0;
            this.buttonModule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule2.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonModule2.Location = new System.Drawing.Point(100, 3);
            this.buttonModule2.Name = "buttonModule2";
            this.buttonModule2.Size = new System.Drawing.Size(109, 172);
            this.buttonModule2.TabIndex = 5;
            this.buttonModule2.Text = "MODULE 2\r\n V0.1";
            this.buttonModule2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModule2.UseVisualStyleBackColor = false;
            this.buttonModule2.Click += new System.EventHandler(this.buttonModule2_Click);
            // 
            // buttonModule3
            // 
            this.buttonModule3.BackColor = System.Drawing.Color.Transparent;
            this.buttonModule3.BackgroundImage = global::DavaoChestCenter.Properties.Resources.users;
            this.buttonModule3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule3.FlatAppearance.BorderSize = 0;
            this.buttonModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule3.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonModule3.Location = new System.Drawing.Point(215, 3);
            this.buttonModule3.Name = "buttonModule3";
            this.buttonModule3.Size = new System.Drawing.Size(105, 172);
            this.buttonModule3.TabIndex = 3;
            this.buttonModule3.Text = "MODULE 3 V0.1";
            this.buttonModule3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModule3.UseVisualStyleBackColor = false;
            this.buttonModule3.Click += new System.EventHandler(this.buttonSchedules_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "FIRSTNAME LASTNAME";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(16, 294);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.RowHeadersVisible = false;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(428, 322);
            this.dataGridViewAppointments.TabIndex = 3;
            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.AllowUserToAddRows = false;
            this.dataGridViewSchedules.AllowUserToDeleteRows = false;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Location = new System.Drawing.Point(463, 294);
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.ReadOnly = true;
            this.dataGridViewSchedules.RowHeadersVisible = false;
            this.dataGridViewSchedules.Size = new System.Drawing.Size(446, 322);
            this.dataGridViewSchedules.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patients (dapat appointments)";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Staff Schedule (Today)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonPatientNew);
            this.flowLayoutPanel2.Controls.Add(this.buttonProductNew);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(428, 218);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonPatientNew
            // 
            this.buttonPatientNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatientNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.users;
            this.buttonPatientNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPatientNew.FlatAppearance.BorderSize = 0;
            this.buttonPatientNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonPatientNew.Location = new System.Drawing.Point(3, 3);
            this.buttonPatientNew.Name = "buttonPatientNew";
            this.buttonPatientNew.Size = new System.Drawing.Size(91, 172);
            this.buttonPatientNew.TabIndex = 5;
            this.buttonPatientNew.Text = "Create New Patient";
            this.buttonPatientNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPatientNew.UseVisualStyleBackColor = false;
            this.buttonPatientNew.Click += new System.EventHandler(this.buttonPatientNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quick Controls:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(384, 264);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(145, 25);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh Tables";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonProductNew
            // 
            this.buttonProductNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductNew.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.buttonProductNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductNew.FlatAppearance.BorderSize = 0;
            this.buttonProductNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductNew.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonProductNew.Location = new System.Drawing.Point(100, 3);
            this.buttonProductNew.Name = "buttonProductNew";
            this.buttonProductNew.Size = new System.Drawing.Size(91, 172);
            this.buttonProductNew.TabIndex = 6;
            this.buttonProductNew.Text = "Encode Product";
            this.buttonProductNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProductNew.UseVisualStyleBackColor = false;
            this.buttonProductNew.Click += new System.EventHandler(this.buttonProductNew_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 628);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSchedules);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMenu_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonModule3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonModule1;
        private System.Windows.Forms.Button buttonModule2;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewSchedules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonPatientNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonProductNew;
    }
}