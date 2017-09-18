using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DavaoChestCenter
{
    public partial class Diagnosis2 : Form
    {
        public Diagnosis2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET lab_crea = @lab_crea, lab_sgpt = @lab_sgpt, lab_FBS = @lab_FBS, lab_acid = @lab_acid, chest_XrayResult = @chest_XrayResult, sputum_month = @sputum_month, sputum_due = @sputum_due, sputum_examDate = @sputum_examDate, sputum_result = @sputum_result, sputum_appearance = @sputum_appearance, doctors_order = @doctors_order WHERE registration_id = @registration_id", con))
                {
                    com.Parameters.AddWithValue("@registration_id", txtID.Text);
                    com.Parameters.AddWithValue("@lab_crea", txtCREA.Text);
                    com.Parameters.AddWithValue("@lab_sgpt", txtSGPT.Text);
                    com.Parameters.AddWithValue("@lab_FBS", txtPBS.Text);
                    com.Parameters.AddWithValue("@lab_acid", txtURIC.Text);
                    com.Parameters.AddWithValue("@chest_XrayResult", txtChest.Text);
                    com.Parameters.AddWithValue("@sputum_month", txtMonth.Text);
                    com.Parameters.AddWithValue("@sputum_due", dateTimeDue.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sputum_examDate", dateTimeExam.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sputum_result", txtResult.Text);
                    com.Parameters.AddWithValue("@sputum_appearance", txtAppearance.Text);
                    com.Parameters.AddWithValue("@doctors_order", txtDoctor.Text);



                    DialogResult r = MessageBox.Show("Apply Laboratory Results?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK)
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }

                }
                con.Close();
            }
        }
    }
}
