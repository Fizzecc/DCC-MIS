﻿namespace DavaoChestCenter
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAppoinment = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DavaoChestCenter.Properties.Resources.lab_microscope;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.button1.Location = new System.Drawing.Point(198, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 139);
            this.button1.TabIndex = 6;
            this.button1.Text = "Diagnosis";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonAppoinment
            // 
            this.buttonAppoinment.BackColor = System.Drawing.Color.Transparent;
            this.buttonAppoinment.BackgroundImage = global::DavaoChestCenter.Properties.Resources.verified_list_of_exercises_of_a_gymnast_on_a_clipboard;
            this.buttonAppoinment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAppoinment.FlatAppearance.BorderSize = 0;
            this.buttonAppoinment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppoinment.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonAppoinment.Location = new System.Drawing.Point(28, 190);
            this.buttonAppoinment.Name = "buttonAppoinment";
            this.buttonAppoinment.Size = new System.Drawing.Size(127, 172);
            this.buttonAppoinment.TabIndex = 7;
            this.buttonAppoinment.Text = "Appointments";
            this.buttonAppoinment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAppoinment.UseVisualStyleBackColor = false;
            this.buttonAppoinment.Click += new System.EventHandler(this.buttonAppoinment_Click);
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
            this.Controls.Add(this.buttonAppoinment);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAppoinment;
        private System.Windows.Forms.Button button3;
    }
}