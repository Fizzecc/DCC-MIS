namespace DavaoChestCenter
{
    partial class Testing1
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
            this.txtfname = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtfname
            // 
            this.txtfname.AutoSize = true;
            this.txtfname.Location = new System.Drawing.Point(20, 174);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(35, 13);
            this.txtfname.TabIndex = 1;
            this.txtfname.Text = "label1";
            // 
            // txtlname
            // 
            this.txtlname.AutoSize = true;
            this.txtlname.Location = new System.Drawing.Point(20, 200);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(35, 13);
            this.txtlname.TabIndex = 2;
            this.txtlname.Text = "label2";
            // 
            // txtmname
            // 
            this.txtmname.AutoSize = true;
            this.txtmname.Location = new System.Drawing.Point(20, 229);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(35, 13);
            this.txtmname.TabIndex = 3;
            this.txtmname.Text = "label3";
            // 
            // txtBirth
            // 
            this.txtBirth.AutoSize = true;
            this.txtBirth.Location = new System.Drawing.Point(185, 229);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(35, 13);
            this.txtBirth.TabIndex = 6;
            this.txtBirth.Text = "label4";
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(185, 200);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(35, 13);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "label5";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(185, 174);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(35, 13);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "label6";
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(382, 200);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(35, 13);
            this.txtType.TabIndex = 8;
            this.txtType.Text = "label8";
            // 
            // txtsex
            // 
            this.txtsex.AutoSize = true;
            this.txtsex.Location = new System.Drawing.Point(382, 174);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(35, 13);
            this.txtsex.TabIndex = 7;
            this.txtsex.Text = "label9";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(492, 227);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 26);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Testing1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Testing1";
            this.Text = "Testing1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtfname;
        private System.Windows.Forms.Label txtlname;
        private System.Windows.Forms.Label txtmname;
        private System.Windows.Forms.Label txtBirth;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label txtsex;
        private System.Windows.Forms.Button btnRefresh;
    }
}