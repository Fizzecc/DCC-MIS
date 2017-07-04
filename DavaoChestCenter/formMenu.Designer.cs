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
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonModule1);
            this.flowLayoutPanel1.Controls.Add(this.buttonModule2);
            this.flowLayoutPanel1.Controls.Add(this.buttonModule3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 257);
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
            this.buttonModule1.Size = new System.Drawing.Size(152, 225);
            this.buttonModule1.TabIndex = 4;
            this.buttonModule1.Text = "MODULE 1 V0.1\r\n";
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
            this.buttonModule2.Location = new System.Drawing.Point(161, 3);
            this.buttonModule2.Name = "buttonModule2";
            this.buttonModule2.Size = new System.Drawing.Size(152, 225);
            this.buttonModule2.TabIndex = 5;
            this.buttonModule2.Text = "MODULE 2\r\n";
            this.buttonModule2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModule2.UseVisualStyleBackColor = false;
            // 
            // buttonModule3
            // 
            this.buttonModule3.BackColor = System.Drawing.Color.Transparent;
            this.buttonModule3.BackgroundImage = global::DavaoChestCenter.Properties.Resources.users;
            this.buttonModule3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule3.FlatAppearance.BorderSize = 0;
            this.buttonModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModule3.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.buttonModule3.Location = new System.Drawing.Point(319, 3);
            this.buttonModule3.Name = "buttonModule3";
            this.buttonModule3.Size = new System.Drawing.Size(176, 225);
            this.buttonModule3.TabIndex = 3;
            this.buttonModule3.Text = "MODULE 3 V0.1";
            this.buttonModule3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModule3.UseVisualStyleBackColor = false;
            this.buttonModule3.Click += new System.EventHandler(this.buttonSchedules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current User:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(98, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "FIRSTNAME LASTNAME";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonModule3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonModule1;
        private System.Windows.Forms.Button buttonModule2;
    }
}