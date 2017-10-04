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
    public partial class formMedRecords : Form
    {
        public formAppointment ref_To_Main { get; set; }
        public formMedRecords()
        {
            InitializeComponent();
        }

        public Boolean validate()
        {
            if(comboBoxStaff.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Invalid Treatment Staff");
                return false;
            }
            if (txtPulm.Text == "")
            {
                MessageBox.Show("Invalid Pulmonary. Please choose one.");
                return false;
            }
            if (radButtPulm.Checked)
            {
                if(txtPulm.Text == "")
                {
                    MessageBox.Show("Invalid Pulmonary/s. Please select one.");
                    return false;
                }
            }
            if (radButtEpulm.Checked)
            {
                if (txtExpilm.Text == "")
                {
                    MessageBox.Show("Invalid Extra Pulmonary.");
                    return false;
                }
            }
            if(radButtonDiabNo.Checked == false && radButtonDiabYes.Checked == false)
            {
                MessageBox.Show("Please Select one from Diabetic.");
                return false;
            }
            if(radButtonHypeYes.Checked == false && radButtonHypeNo.Checked == false)
            {
                MessageBox.Show("Please Select from Hypertensive");
                return false;
            }
            if(radButtonSmokeYes.Checked == false && radButtonSmokeNo.Checked == false)
            {
                MessageBox.Show("Invalid Smoker");
                return false;
            }
            if (radButtonSmokeYes.Checked)
            {
                if(txtTimesSmoke.Text == "")
                {
                    MessageBox.Show("Invalid Times Smoke");
                    return false;
                }
            }
            if(radButtonTBYes.Checked == false && radButtonTBNo.Checked == false)
            {
                MessageBox.Show("Invalid Previous TB");
                return false;
            }
            if (radButtonTBYes.Checked)
            {
                if(txtMonths.Text == "")
                {
                    MessageBox.Show("Invalid TB months");
                    return false;
                }
                if(txtMedicines.Text == "")
                {
                    MessageBox.Show("Invalid Medicines");
                    return false;
                }
                if(radButtonAB.Checked == false && radButtonTB.Checked == false)
                {
                    MessageBox.Show("Invalid medicines under.");
                    return false;
                }
            }
            if(radButtonAlcoholicYes.Checked == false && radButtonAlcoholicNo.Checked == false)
            {
                MessageBox.Show("Choose Alcoholic.");
            }
            
            if(radButtonDiagnosis.Checked == false && radButtonBaseline.Checked == false && radButtonFollow.Checked == false)
            {
                MessageBox.Show("Invalid Exam Reason. Please Choose one");
                return false;
            }
            if(radButtonHistNew.Checked == false && radButtonHistRT.Checked == false)
            {
                MessageBox.Show("Invalid History Treatment. Please Choose one");
                return false;
            }
            if(radButtonSputum.Checked == false && radButtonOthers.Checked == false)
            {
                MessageBox.Show("Invalid Specimen Type. Please choose one");
                return false;
            }
            if (radButtonOthers.Checked)
            {
                if (txtOthers.Text == "")
                {
                    MessageBox.Show("Invalid Other specimen.");
                    return false;
                }
            }
            if(radButtonDSSM.Checked == false && radButtonXpert.Checked == false && radButtonCulture.Checked == false && radButtonDST.Checked == false && radButtonUPA.Checked == false)
            {
                MessageBox.Show("Invalid Test Request. Please Choose one.");
                return false;
            }
            if(txtPrepared.Text == "")
            {
                MessageBox.Show("Invalid 'Prepared by'.");
                return false;
            }
            if(txtPosition.Text == "")
            {
                MessageBox.Show("Invalid Position.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public formMedRecords(int selectedID, string firstname, string middlename, string lastname, string pulmonaries,
            string extra_pulmonaries, string diabetic, string hypertensive, string smoke, string smoke_day,
            string start_smoking, string stop_smoking, string prev_tb, string tb_months, string tb_date,
            string medicines, string medicine_under, string alcoholic, string alcohol_start, string alcohol_stop,
            string exam_reason, string hist_treatment, string specimen_type, string specimen_date1, string speciman_date2,
            string test_request, string prepared_by, string staff_position, string treatment_partner)
        {
            InitializeComponent();
            lblID.Text = selectedID.ToString();
            lblName.Text = lastname + ", " + firstname + " " + middlename;
            txtPulm.Text = pulmonaries;
            txtExpilm.Text = extra_pulmonaries;

            if(diabetic == "Yes")
            {
                radButtonDiabYes.Checked = true;
            }
            if (diabetic == "No")
            {
                radButtonDiabNo.Checked = true;
            }
            if(hypertensive == "Yes")
            {
                radButtonHypeYes.Checked = true;
            }
            if(hypertensive == "No")
            {
                radButtonHypeNo.Checked = true;
            }
            if(smoke == "Yes")
            {
                radButtonSmokeYes.Checked = true;
                txtTimesSmoke.Enabled = true;
                dateTimeSMKstart.Enabled = true;
                dateTimeSMKstop.Enabled = true;
                txtTimesSmoke.Text = smoke_day;
            }
            if(smoke == "No")
            {
                radButtonSmokeNo.Checked = true;
                txtTimesSmoke.Enabled = false;
                dateTimeSMKstart.Enabled = false;
                dateTimeSMKstop.Enabled = false;
            }
            if(prev_tb == "Yes")
            {
                radButtonTBYes.Checked = true;
                txtMonths.Enabled = true;
                dateTimeTBTreat.Enabled = true;
                txtMedicines.Enabled = true;
                radButtonTB.Enabled = true;
                radButtonAB.Enabled = true;
                txtMonths.Text = tb_months;
                txtMedicines.Text = medicine_under;
                if (medicines == "AB Treatment")
                {
                    radButtonAB.Checked = true;
                }
                if(medicines == "TB Treatment")
                {
                    radButtonTB.Checked = true;
                }
            }
            if(prev_tb == "No")
            {
                radButtonTBNo.Checked = true;
                txtMonths.Enabled = false;
                dateTimeTBTreat.Enabled = false;
                txtMedicines.Enabled = false;
                radButtonTB.Enabled = false;
                radButtonAB.Enabled = false;
            }
            if(alcoholic == "Yes")
            {
                radButtonAlcoholicYes.Checked = true;
                dateTimeDRNKstart.Enabled = true;
                dateTimeDRNKstop.Enabled = true;
            }
            if(alcoholic == "No")
            {
                radButtonAlcoholicNo.Checked = true;
                dateTimeDRNKstart.Enabled = false;
                dateTimeDRNKstop.Enabled = false;
            }
            if(exam_reason == "Diagnosis")
            {
                radButtonDiagnosis.Checked = true;
            }
            if(exam_reason == "Baseline")
            {
                radButtonBaseline.Checked = true;
            }
            if(exam_reason == "Follow")
            {
                radButtonFollow.Checked = true;
            }
            if(hist_treatment == "New")
            {
                radButtonHistNew.Checked = true;
            }
            if(hist_treatment == "Retreatment")
            {
                radButtonHistRT.Checked = true;
            }
            if(specimen_type == "Sputum")
            {
                radButtonSputum.Checked = true;
            }
            if(specimen_type != "Sputum")
            {
                radButtonOthers.Checked = true;
                txtOthers.Text = specimen_type;
            }
            if(test_request == "DSSM")
            {
                radButtonDSSM.Checked = true;
            }
            if(test_request == "Xpert")
            {
                radButtonXpert.Checked = true;
            }
            if(test_request == "Culture")
            {
                radButtonCulture.Checked = true;
            }
            if(test_request == "DST")
            {
                radButtonDST.Checked = true;
            }
            if(test_request == "UPA")
            {
                radButtonUPA.Checked = true;
            }
            txtPrepared.Text = prepared_by;
            txtPosition.Text = staff_position;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET treatment_partner = @treatment_partner, pulmonaries = @pulmonaries, extra_pulmonaries = @extra_pulmonaries, diabetic = @diabetic, hypertensive = @hypertensive, smoke = @smoke, smoke_day = @smoke_day, start_smoking = @start_smoking, stop_smoking = @stop_smoking, prev_tb = @prev_tb, tb_months = @tb_months, tb_date = @tb_date, medicines = @medicines, medicine_under = @medicine_under, alcoholic = @alcoholic, alcohol_start = @alcohol_start, alcohol_stop = @alcohol_stop, exam_reason = @exam_reason, hist_treatment = @hist_treatment, specimen_type = @specimen_type, specimen_date1 = @specimen_date1, speciman_date2 = @speciman_date2, test_request = @test_request, prepared_by = @prepared_by, staff_position = @staff_position WHERE registration_id = @registration_id", con))
                {
                    com.Parameters.AddWithValue("@registration_id", lblID.Text);
                    com.Parameters.AddWithValue("@treatment_partner", comboBoxStaff.SelectedItem.ToString());
                    //com.Parameters.AddWithValue("@smoke_day", lblID.Text);
                    com.Parameters.AddWithValue("@prepared_by", txtPrepared.Text);
                    com.Parameters.AddWithValue("@staff_position", txtPosition.Text);
                    com.Parameters.AddWithValue("@specimen_date1", dateTimePickerSpecimen1.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@speciman_date2", dateTimePickerSpecimen2.Value.ToString("yyyy-MM-dd"));


                    if (radButtEpulm.Checked)
                    {
                       com.Parameters.AddWithValue("@pulmonaries", "");
                        com.Parameters.AddWithValue("@extra_pulmonaries", txtExpilm.Text);
                    }
                    if(radButtPulm.Checked)
                    {
                        com.Parameters.AddWithValue("@pulmonaries", txtPulm.Text);
                        com.Parameters.AddWithValue("@extra_pulmonaries", "");
                    }
                    if (radButtBoth.Checked)
                    {
                        com.Parameters.AddWithValue("@pulmonaries", txtPulm.Text);
                        com.Parameters.AddWithValue("@extra_pulmonaries", txtExpilm.Text);
                    }
                    if (radButtonDiabYes.Checked)
                    {
                        com.Parameters.AddWithValue("@diabetic", radButtonDiabYes.Text);
                    }

                    if (radButtonDiabNo.Checked)
                    {
                        com.Parameters.AddWithValue("@diabetic", radButtonDiabNo.Text);
                    }

                    if (radButtonHypeYes.Checked)
                    {
                        com.Parameters.AddWithValue("@hypertensive", radButtonHypeYes.Text);
                    }

                    if (radButtonHypeNo.Checked)
                    {
                        com.Parameters.AddWithValue("@hypertensive", radButtonHypeNo.Text);
                    }

                    if (radButtonSmokeYes.Checked)
                    {
                        txtTimesSmoke.Enabled = true;
                        dateTimeSMKstart.Enabled = true;
                        dateTimeSMKstop.Enabled = true;
                        com.Parameters.AddWithValue("@smoke", radButtonSmokeYes.Text);
                        com.Parameters.AddWithValue("@smoke_day", txtTimesSmoke.Text);
                        com.Parameters.AddWithValue("@start_smoking", dateTimeSMKstart.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@stop_smoking", dateTimeSMKstop.Value.ToString("yyyy-MM-dd"));
                    }

                    if (radButtonSmokeNo.Checked)
                    {
                        txtTimesSmoke.Enabled = false;
                        dateTimeSMKstart.Enabled = false;
                        dateTimeSMKstop.Enabled = false;
                        com.Parameters.AddWithValue("@smoke", "");
                        com.Parameters.AddWithValue("@smoke_day", "");
                        com.Parameters.AddWithValue("@start_smoking", "");
                        com.Parameters.AddWithValue("@stop_smoking", "");
                    }

                    if (radButtonTBYes.Checked)
                    {
                        txtMonths.Enabled = true;
                        dateTimeTBTreat.Enabled = true;
                        txtMedicines.Enabled = true;
                        radButtonTB.Enabled = true;
                        radButtonAB.Enabled = true;
                        com.Parameters.AddWithValue("@prev_tb", radButtonTBYes.Text);
                        com.Parameters.AddWithValue("@tb_months", txtMonths.Text);
                        com.Parameters.AddWithValue("@tb_date", dateTimeTBTreat.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@medicines", txtMedicines.Text);
                        if (radButtonAB.Checked)
                        {
                            com.Parameters.AddWithValue("@medicine_under", radButtonAB.Text);
                        }

                        if (radButtonTB.Checked)
                        {
                            com.Parameters.AddWithValue("@medicine_under", radButtonTB.Text);
                        }
                        
                    }

                    if (radButtonTBNo.Checked)
                    {
                        txtMonths.Enabled = false;
                        dateTimeTBTreat.Enabled = false;
                        txtMedicines.Enabled = false;
                        radButtonTB.Enabled = false;
                        radButtonAB.Enabled = false;
                        com.Parameters.AddWithValue("@prev_tb", "");
                        com.Parameters.AddWithValue("@tb_months", "");
                        com.Parameters.AddWithValue("@tb_date", "");
                        com.Parameters.AddWithValue("@medicines", "");
                        com.Parameters.AddWithValue("@medicine_under", "");
                    }

                    if (radButtonAlcoholicYes.Checked)
                    {
                        dateTimeDRNKstart.Enabled = true;
                        dateTimeDRNKstop.Enabled = true;
                        com.Parameters.AddWithValue("@alcoholic", radButtonAlcoholicYes.Text);
                        com.Parameters.AddWithValue("@alcohol_start", dateTimeDRNKstart.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@alcohol_stop", dateTimeDRNKstop.Value.ToString("yyyy-MM-dd"));
                    }

                    if (radButtonAlcoholicNo.Checked)
                    {
                        dateTimeDRNKstart.Enabled = false;
                        dateTimeDRNKstop.Enabled = false;
                        com.Parameters.AddWithValue("@alcoholic", "");
                        com.Parameters.AddWithValue("@alcohol_start", "");
                        com.Parameters.AddWithValue("@alcohol_stop", "");

                    }

                    if (radButtonDiagnosis.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtonDiagnosis.Text);
                    }

                    if (radButtonBaseline.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtonBaseline.Text);
                    }

                    if (radButtonFollow.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtonFollow.Text);
                    }

                    if (radButtonHistNew.Checked)
                    {
                        com.Parameters.AddWithValue("@hist_treatment", radButtonHistNew.Text);
                    }

                    if (radButtonHistRT.Checked)
                    {
                        com.Parameters.AddWithValue("@hist_treatment", radButtonHistRT.Text);
                    }

                    if (radButtonSputum.Checked)
                    {
                        txtOthers.Enabled = false;
                        com.Parameters.AddWithValue("@specimen_type", radButtonSputum.Text);
                    }
                    if (radButtonOthers.Checked)
                    {
                        txtOthers.Enabled = true;
                        com.Parameters.AddWithValue("@specimen_type", txtOthers.Text);
                    }
                    if (radButtonDSSM.Checked)
                    {
                        com.Parameters.AddWithValue("@test_request", radButtonDSSM.Text);
                    }

                    if (radButtonXpert.Checked)
                    {
                        com.Parameters.AddWithValue("@test_request", radButtonXpert.Text);
                    }

                    if (radButtonCulture.Checked)
                    {
                        com.Parameters.AddWithValue("@test_request", radButtonCulture.Text);
                    }

                    if (radButtonDST.Checked)
                    {
                        com.Parameters.AddWithValue("@test_request", radButtonDST.Text);
                    }

                    if (radButtonUPA.Checked)
                    {
                        com.Parameters.AddWithValue("@test_request", radButtonUPA.Text);
                    }

                    DialogResult r = MessageBox.Show("Apply Laboratory Results?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK && validate())
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

        private void radButtonTBYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonTBYes.Checked)
            {
                txtMonths.Enabled = true;
                dateTimeTBTreat.Enabled = true;
                txtMedicines.Enabled = true;
                radButtonTB.Enabled = true;
                radButtonAB.Enabled = true;
            }
            if (radButtonTBNo.Checked)
            {
                txtMonths.Enabled = false;
                dateTimeTBTreat.Enabled = false;
                txtMedicines.Enabled = false;
                radButtonTB.Enabled = false;
                radButtonAB.Enabled = false;
            }
        }

        private void radButtonAlcoholicYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonAlcoholicYes.Checked)
            {
                dateTimeDRNKstart.Enabled = true;
                dateTimeDRNKstop.Enabled = true;
            }

            if (radButtonAlcoholicNo.Checked)
            {
                dateTimeDRNKstart.Enabled = false;
                dateTimeDRNKstop.Enabled = false;

            }
        }

        private void formMedRecords_Load(object sender, EventArgs e)
        {
            dateTimeDRNKstart.Enabled = false;
            dateTimeDRNKstop.Enabled = false;
            txtMonths.Enabled = false;
            dateTimeTBTreat.Enabled = false;
            txtMedicines.Enabled = false;
            radButtonTB.Enabled = false;
            radButtonAB.Enabled = false;
            txtTimesSmoke.Enabled = false;
            dateTimeSMKstart.Enabled = false;
            dateTimeSMKstop.Enabled = false;
            txtOthers.Enabled = false;
            txtExpilm.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPulm.Text = "cough";
            txtExpilm.Text = "yes";
        }

        private void radButtonSputum_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtonSputum.Checked)
            {
                radButtonSputum.Enabled = true;
            }

            if (radButtonOthers.Checked)
            {
                radButtonOthers.Enabled = true;
                radButtonSputum.Enabled = false;
            }
        }

        private void radButtonDSSM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCough_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCough.Checked)
            {
                txtPulm.AppendText(checkBoxCough.Text + ", ");
            }
        }

        private void checkBoxFever_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFever.Checked)
            {
                txtPulm.AppendText(checkBoxFever.Text + ", ");
            }
        }

        private void checkBoxSputum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSputum.Checked)
            {
                txtPulm.AppendText(checkBoxSputum.Text + ", ");
            }
        }

        private void checkBoxWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeight.Checked)
            {
                txtPulm.AppendText(checkBoxWeight.Text + ", ");
            }
        }

        private void checkBoxHemo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHemo.Checked)
            {
                txtPulm.AppendText(checkBoxHemo.Text + ", ");
            }
        }

        private void checkBoxChest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChest.Checked)
            {
                txtPulm.AppendText(checkBoxChest.Text + ", ");
            }
        }

        private void checkBoxDyspnea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDyspnea.Checked)
            {
                txtPulm.AppendText(checkBoxDyspnea.Text + ", ");
            }
        }

        private void checkBoxChills_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChills.Checked)
            {
                txtPulm.AppendText(checkBoxChills.Text + ", ");
            }
        }

        private void checkBoxFatigue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFatigue.Checked)
            {
                txtPulm.AppendText(checkBoxFatigue.Text + ", ");
            }
        }

        private void checkBoxMalaise_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMalaise.Checked)
            {
                txtPulm.AppendText(checkBoxMalaise.Text + ", ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPulm.Enabled = true;
            txtExpilm.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtExpilm.Enabled = true;
            txtPulm.Enabled = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtPulm.Enabled = true;
            txtExpilm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPulm.Text = "";
        }
    }
}
