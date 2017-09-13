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
    public partial class formRegistration3 : Form
    {
        public formRegistration3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO registration VALUES(null, @patient_name, @patient_age, @patient_gender, @patient_status, @occupation1, @contact_num1, @appointmentDate, @refPhys, @contPerson, @cp_rel, @cp_addr, @treatmentPartner, @weight, @pulmonary, @occupation2, @pharmacist, @civil_status, @philHealth_member, @contact_num2, @extra_pulmonary, @diabetic, @smoker, @num_months1, @smoke_start, @smoke_stopped, @prev_treatment, @num_months2, @treat_date, @treat_medicine, @AB_treatment, @alcoholic_drinker, @alcohol_start, @alcohol_stop, @lab_result, @sputum_result, @chest_date)", con))
                {
                    com.Parameters.AddWithValue("@patient_name", txtName.Text);
                    com.Parameters.AddWithValue("@patient_age", txtAge.Text);
                    com.Parameters.AddWithValue("@occupation1", txtOccupation.Text);
                    com.Parameters.AddWithValue("@contact_num1", txtContact.Text);
                    com.Parameters.AddWithValue("@appointmentDate", dateTimePickerDateApp.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@refPhys", txtPhys.Text);
                    com.Parameters.AddWithValue("@contPerson", txtCP.Text);
                    com.Parameters.AddWithValue("@cp_rel", txtCPrel.Text);
                    com.Parameters.AddWithValue("@cp_addr", txtCPaddress.Text);
                    com.Parameters.AddWithValue("@treatmentPartner", txtTpartner.Text);
                    com.Parameters.AddWithValue("@weight", txtWeight.Text);
                    com.Parameters.AddWithValue("@pulmonary", txtPulm.Text);
                    com.Parameters.AddWithValue("@occupation2", txtOccupation2.Text);
                    com.Parameters.AddWithValue("@pharmacist", txtPharmacist.Text);
                    com.Parameters.AddWithValue("@civil_status", txtCivStat.Text);
                    com.Parameters.AddWithValue("@philHealth_member", txtCivStat.Text);
                    com.Parameters.AddWithValue("@contact_num2", txtContact2.Text);
                    com.Parameters.AddWithValue("@extra_pulmonary", txtPulm.Text);
                    com.Parameters.AddWithValue("@diabetic", txtDiabetic.Text);
                    com.Parameters.AddWithValue("@smoker", txtSmoker.Text);
                    com.Parameters.AddWithValue("@num_months1", txtNum_months.Text);
                    com.Parameters.AddWithValue("@smoke_start", dateTimeSMKstart.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@smoke_stopped", dateTimeSMKstop.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@prev_treatment", txtPrevTreat.Text);
                    com.Parameters.AddWithValue("@num_months2", txtPrevMonths.Text);
                    com.Parameters.AddWithValue("@treat_date", dateTimeTreatDate.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@treat_medicine", txtTreatMeds.Text);
                    com.Parameters.AddWithValue("@AB_treatment", txtABtreat.Text);
                    com.Parameters.AddWithValue("@alcoholic_drinker", txtAlcoholic.Text);
                    com.Parameters.AddWithValue("@alcohol_start", dateTimeAlcohlicStart.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@alcohol_stop", dateTimeAlcoholicStop.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@lab_result", txtLabResult.Text);
                    com.Parameters.AddWithValue("@sputum_result", txtSputum.Text);
                    com.Parameters.AddWithValue("@chest_date", dateTimeChestDate.Value.ToString("yyyy-MM-dd"));
                    
                   if (radButtonMale.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_gender", radButtonMale.Text);
                    }

                   if (radButtonFemale.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_gender", radButtonFemale.Text);
                    }

                   if (radButtonSingle.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_status", radButtonSingle.Text);
                    }

                   if (radButtonMarried.Checked)
                    {
                        com.Parameters.AddWithValue("@patient_status", radButtonMarried.Text);
                    }

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

        private void formRegistration3_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "Crumb";
            txtAge.Text = "12";
            txtOccupation.Text = "Davao";
            txtContact.Text = "09772";
            txtPhys.Text = "Mr. Todd";
            txtCP.Text = "Dad";
            txtCPrel.Text = "Father";
            txtCPaddress.Text = "House";
            txtTpartner.Text = "Bro";
            txtWeight.Text = "65";
            txtPulm.Text = "Pimple";
            txtOccupation2.Text = "Home";
            txtPharmacist.Text = "Here";
            txtCivStat.Text = "Single";
            txtPhilHealth.Text = "Yes";
            txtContact2.Text = "5552471";
            txtPulm.Text = "Dimple";
            txtDiabetic.Text = "Yes";
            txtSmoker.Text = "No";
            txtNum_months.Text = "5";
            txtPrevTreat.Text = "6";
            txtPrevMonths.Text = "3";
            txtTreatMeds.Text = "Paracetamol";
            txtABtreat.Text = "Yes";
            txtAlcoholic.Text = "Yes";
            txtLabResult.Text = "Cancer";
            txtSputum.Text = "Eww";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtOccupation.Text = "";
            txtContact.Text = "";
            txtPhys.Text = "";
            txtCP.Text = "";
            txtCPrel.Text = "";
            txtCPaddress.Text = "";
            txtTpartner.Text = "";
            txtWeight.Text = "";
            txtPulm.Text = "";
            txtOccupation2.Text = "";
            txtPharmacist.Text = "";
            txtCivStat.Text = "";
            txtPhilHealth.Text = "";
            txtContact2.Text = "";
            txtPulm.Text = "";
            txtDiabetic.Text = "";
            txtSmoker.Text = "";
            txtNum_months.Text = "";
            txtPrevTreat.Text = "";
            txtPrevMonths.Text = "";
            txtTreatMeds.Text = "";
            txtABtreat.Text = "";
            txtAlcoholic.Text = "";
            txtLabResult.Text = "";
            txtSputum.Text = "";
        }

        private void dateTimeChestDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
