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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonModule1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelModule1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonModule2 = new System.Windows.Forms.Button();
            this.buttonModule3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.flowLayoutPanelModule1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.flowLayoutPanelMenu);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 951);
            this.panelMenu.TabIndex = 23;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDashboard);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonModule1);
            this.flowLayoutPanelMenu.Controls.Add(this.flowLayoutPanelModule1);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonModule2);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonModule3);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(258, 892);
            this.flowLayoutPanelMenu.TabIndex = 25;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.DimGray;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 3);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(252, 29);
            this.buttonDashboard.TabIndex = 4;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonModule1
            // 
            this.buttonModule1.BackColor = System.Drawing.Color.DimGray;
            this.buttonModule1.FlatAppearance.BorderSize = 0;
            this.buttonModule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModule1.Location = new System.Drawing.Point(3, 38);
            this.buttonModule1.Name = "buttonModule1";
            this.buttonModule1.Size = new System.Drawing.Size(252, 29);
            this.buttonModule1.TabIndex = 0;
            this.buttonModule1.Text = "Profiling and Laboratory";
            this.buttonModule1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonModule1.UseVisualStyleBackColor = false;
            this.buttonModule1.Click += new System.EventHandler(this.buttonModule1_Click);
            // 
            // flowLayoutPanelModule1
            // 
            this.flowLayoutPanelModule1.Controls.Add(this.buttonProfile);
            this.flowLayoutPanelModule1.Controls.Add(this.button2);
            this.flowLayoutPanelModule1.Controls.Add(this.buttonServices);
            this.flowLayoutPanelModule1.Controls.Add(this.button1);
            this.flowLayoutPanelModule1.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanelModule1.Name = "flowLayoutPanelModule1";
            this.flowLayoutPanelModule1.Size = new System.Drawing.Size(252, 147);
            this.flowLayoutPanelModule1.TabIndex = 3;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.DimGray;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonProfile.Location = new System.Drawing.Point(3, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(252, 29);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Profiles";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(3, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Diagnosis";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(3, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Appointments and Medical Records";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.Color.DimGray;
            this.buttonServices.FlatAppearance.BorderSize = 0;
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonServices.Location = new System.Drawing.Point(3, 73);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(252, 29);
            this.buttonServices.TabIndex = 4;
            this.buttonServices.Text = "Services";
            this.buttonServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonModule2
            // 
            this.buttonModule2.BackColor = System.Drawing.Color.DimGray;
            this.buttonModule2.FlatAppearance.BorderSize = 0;
            this.buttonModule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModule2.Location = new System.Drawing.Point(3, 226);
            this.buttonModule2.Name = "buttonModule2";
            this.buttonModule2.Size = new System.Drawing.Size(252, 29);
            this.buttonModule2.TabIndex = 1;
            this.buttonModule2.Text = "Inventory Management";
            this.buttonModule2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonModule2.UseVisualStyleBackColor = false;
            this.buttonModule2.Click += new System.EventHandler(this.buttonModule2_Click_1);
            // 
            // buttonModule3
            // 
            this.buttonModule3.BackColor = System.Drawing.Color.DimGray;
            this.buttonModule3.FlatAppearance.BorderSize = 0;
            this.buttonModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModule3.Location = new System.Drawing.Point(3, 261);
            this.buttonModule3.Name = "buttonModule3";
            this.buttonModule3.Size = new System.Drawing.Size(252, 29);
            this.buttonModule3.TabIndex = 5;
            this.buttonModule3.Text = "Staff Attendance";
            this.buttonModule3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonModule3.UseVisualStyleBackColor = false;
            this.buttonModule3.Click += new System.EventHandler(this.buttonModule3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 24;
            this.label2.Text = "Davao Chest Center \r\nManagement Information System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(257, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1329, 862);
            this.panelForm.TabIndex = 24;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMenu_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.flowLayoutPanelModule1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonModule1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelModule1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonModule2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonModule3;
        public System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonServices;
    }
}