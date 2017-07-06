namespace DavaoChestCenter
{
    partial class formModule1
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
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonDiagnosis = new System.Windows.Forms.Button();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.BackgroundImage = global::DavaoChestCenter.Properties.Resources.users;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonProfile.Location = new System.Drawing.Point(28, 12);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(127, 172);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profiles";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonDiagnosis
            // 
            this.buttonDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.buttonDiagnosis.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.buttonDiagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiagnosis.FlatAppearance.BorderSize = 0;
            this.buttonDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnosis.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonDiagnosis.Location = new System.Drawing.Point(198, 12);
            this.buttonDiagnosis.Name = "buttonDiagnosis";
            this.buttonDiagnosis.Size = new System.Drawing.Size(109, 139);
            this.buttonDiagnosis.TabIndex = 6;
            this.buttonDiagnosis.Text = "Diagnosis";
            this.buttonDiagnosis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDiagnosis.UseVisualStyleBackColor = false;
            this.buttonDiagnosis.Click += new System.EventHandler(this.buttonDiagnosis_Click);
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.BackColor = System.Drawing.Color.Transparent;
            this.buttonAppointment.BackgroundImage = global::DavaoChestCenter.Properties.Resources.verified_list_of_exercises_of_a_gymnast_on_a_clipboard;
            this.buttonAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAppointment.FlatAppearance.BorderSize = 0;
            this.buttonAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppointment.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonAppointment.Location = new System.Drawing.Point(28, 190);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(127, 172);
            this.buttonAppointment.TabIndex = 7;
            this.buttonAppointment.Text = "Appointments";
            this.buttonAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAppointment.UseVisualStyleBackColor = false;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppoinment_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.button3.Location = new System.Drawing.Point(219, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 172);
            this.button3.TabIndex = 8;
            this.button3.Text = "Services";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // formModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 382);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.buttonDiagnosis);
            this.Controls.Add(this.buttonProfile);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formModule1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profiling and Laboratory Management System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonDiagnosis;
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button button3;
    }
}