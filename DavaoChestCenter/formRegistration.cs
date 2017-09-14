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
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /*using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM users", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["id"].Visible = false;
                    }
                }
                con.Close();
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtUser.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txtType.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO registration VALUES(null, @patient_Lname, @patient_Fname, @patient_Mname, @patient_status, @patient_gender, @appointmentDate, @age, @address, @contact_num1, @ref_Phys, @occupation, @CPLname, @CPFname, @CPMname, @CPrelation, @CPcontact, @CPaddress, @treatment_partner, @weight, @contact_num2, @pulmonaries, @extra_pulmonaries, @diabetic, @hypertensive, @smoke, @smoke_day, @start_smoking, @stop_smoking, @prev_tb, @tb_months, @tb_date, @medicines, @medicine_under, @alcoholic, @alcoholic_start, @alcoholic_stop, @blank)", con))
                {
                    com.Parameters.AddWithValue("@patient_Lname", txtFname.Text);
                    com.Parameters.AddWithValue("@patient_Fname", txtFname.Text);
                    com.Parameters.AddWithValue("@patient_Mname", txtMname.Text);
                    com.Parameters.AddWithValue("@appointmentDate", dateTimeAppDate.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@age", txtAge.Text);
                    com.Parameters.AddWithValue("@address", txtAddress.Text);
                    com.Parameters.AddWithValue("@contact_num1", txtContact.Text);
                    com.Parameters.AddWithValue("@ref_Phys", txtPhys.Text);
                    com.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    com.Parameters.AddWithValue("@CPLname", txtCPLname.Text);
                    com.Parameters.AddWithValue("@CPFname", txtCPFname.Text);
                    com.Parameters.AddWithValue("@CPMname", txtCPMname.Text);
                    com.Parameters.AddWithValue("@CPrelation", txtCPrel.Text);
                    com.Parameters.AddWithValue("@CPcontact", txtCPContact.Text);
                    com.Parameters.AddWithValue("@CPaddress", txtCPAddress.Text);
                    com.Parameters.AddWithValue("@treatment_partner", txtTreatment.Text);
                    com.Parameters.AddWithValue("@weight", txtWeight.Text);
                    com.Parameters.AddWithValue("@contact_num2", txtTcontact.Text);
                    com.Parameters.AddWithValue("@pulmonaries", txtPulm.Text);
                    com.Parameters.AddWithValue("@extra_pulmonaries", txtEpulm.Text);

                    //alcohol
                    if (radButtonAlcoholicYes.Checked)
                    {
                        com.Parameters.AddWithValue("@alcoholic", radButtonAlcoholicYes.Text);
                        com.Parameters.AddWithValue("@alcoholic_start", dateTimeDRNKstart.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@alcoholic_stop", dateTimeDRNKstop.Value.ToString("yyyy-MM-dd"));
                    }

                    if (radButtonAlcohlicNo.Checked)
                    {
                        com.Parameters.AddWithValue("@alcoholic", radButtonAlcohlicNo.Text);
                        com.Parameters.AddWithValue("@alcoholic_start", "");
                        com.Parameters.AddWithValue("@alcoholic_stop", "");
                    }

                    //TB
                    if (radButtonTBYes.Checked)
                    {
                        com.Parameters.AddWithValue("@prev_tb", radButtonTBYes.Text);
                        com.Parameters.AddWithValue("@tb_months", txtMonths.Text);
                        com.Parameters.AddWithValue("@tb_date", dateTimeTBTreat.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@medicines", txtMedicines.Text);
                        if (checkBoxAB.Checked)
                        {
                            com.Parameters.AddWithValue("@medicine_under", checkBoxAB.Text);
                        }
                        if (checkBoxTB.Checked)
                        {
                            com.Parameters.AddWithValue("@medicine_under", checkBoxTB.Text);
                        }
                    }

                    if (radButtonTBNo.Checked)
                    {
                        com.Parameters.AddWithValue("@prev_tb", radButtonTBNo.Text);
                        com.Parameters.AddWithValue("@tb_months", "");
                        com.Parameters.AddWithValue("@tb_date", "");
                        com.Parameters.AddWithValue("@medicines", "");
                        com.Parameters.AddWithValue("@medicine_under", "");
                    }

                    //Smoke

                    if (radButtonSmokeYes.Checked)
                    {
                        com.Parameters.AddWithValue("@smoke", radButtonSmokeYes.Text);
                        com.Parameters.AddWithValue("@smoke_day", txtTimesSmoke.Text);
                        com.Parameters.AddWithValue("@start_smoking", dateTimeSMKstart.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@stop_smoking", dateTimeSMKstop.Value.ToString("yyyy-MM-dd"));
                    }

                    if (radButtonSmokeNo.Checked)
                    {
                        com.Parameters.AddWithValue("@smoke", "radButtonSmokeNo.Text");
                        com.Parameters.AddWithValue("@smoke_day", "");
                        com.Parameters.AddWithValue("@start_smoking", "");
                        com.Parameters.AddWithValue("@stop_smoking", "");
                    }

                    //Diabetic

                    if (radButtonDiabYes.Checked)
                    {
                        com.Parameters.AddWithValue("@diabetic", radButtonDiabYes.Text);
                    }

                    if (radButtonDiabNo.Checked)
                    {
                        com.Parameters.AddWithValue("@diabetic", radButtonDiabNo.Text);
                    }

                    //Hyper

                    if (radButtonHyperYes.Checked)
                    {
                        com.Parameters.AddWithValue("@hypertensive", radButtonHyperYes.Text);
                    }

                    if (radButtonHyperNo.Checked)
                    {
                        com.Parameters.AddWithValue("@hypertensive", radButtonHyperNo.Text);
                    }

                    //Gender

                    if (radButtonMale.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_gender", radButtonMale.Text);
                    }

                    if (radButtonFemale.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_gender", radButtonFemale.Text);
                    }

                    //Status

                    if (radButtonSingle.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_status", radButtonSingle.Text);
                    }

                    if (radButtonMarried.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_status", radButtonMarried.Text);
                    }

                    com.Parameters.AddWithValue("@blank", "");

                    DialogResult r = MessageBox.Show("Appointment Added", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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

        private void formRegistration_Load(object sender, EventArgs e)
        {
            txtTimesSmoke.Enabled = false;
            dateTimeSMKstart.Enabled = false;
            dateTimeSMKstop.Enabled = false;
            dateTimeTBTreat.Enabled = false;
            checkBoxAB.Enabled = false;
            checkBoxTB.Enabled = false;
            txtMedicines.Enabled = false;
            dateTimeDRNKstart.Enabled = false;
            dateTimeDRNKstop.Enabled = false;
            txtMonths.Enabled = false;
        }

        private void radButtonSmokeYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonSmokeYes.Checked)
            {
                txtTimesSmoke.Enabled = true;
                dateTimeSMKstart.Enabled = true;
                dateTimeSMKstop.Enabled = true;
            }

            if (radButtonSmokeNo.Checked)
            {
                txtTimesSmoke.Enabled = false;
                dateTimeSMKstart.Enabled = false;
                dateTimeSMKstop.Enabled = false;
            }
        }

        private void radButtonSmokeNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonTBYes.Checked)
            {
                dateTimeTBTreat.Enabled = true;
                checkBoxAB.Enabled = true;
                checkBoxTB.Enabled = true;
                txtMonths.Enabled = true;
            }

            if (radButtonTBNo.Checked)
            {
                dateTimeTBTreat.Enabled = false;
                checkBoxAB.Enabled = false;
                checkBoxTB.Enabled = false;
                txtMonths.Enabled = false;
            }
        }

        private void radButtonAlcoholicYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonAlcoholicYes.Checked)
            {
                dateTimeDRNKstart.Enabled = true;
                dateTimeDRNKstop.Enabled = true;
            }

            if (radButtonAlcohlicNo.Checked)
            {
                dateTimeDRNKstart.Enabled = false;
                dateTimeDRNKstop.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtLname.Text = "Crumb";
            txtFname.Text = "Christian";
            txtMname.Text = "Emmanuel";
            txtAge.Text = "19";
            txtAddress.Text = "Davao";
            txtContact.Text = "5552471";
            txtPhys.Text = "What";
            txtOccupation.Text = "Programmer";
            txtCPLname.Text = "Cruise";
            txtCPFname.Text = "Thomas";
            txtCPMname.Text = "Daniel";
            txtCPrel.Text = "Father";
            txtCPContact.Text = "1337";
            txtCPAddress.Text = "USSR Soviet Russia";
            txtTreatment.Text = "Dr. Effren Salvado";
            txtWeight.Text = "65";
            txtTcontact.Text = "2673";
            txtPulm.Text = "Cough";
            txtEpulm.Text = "Pimples";
        }
    }
}
