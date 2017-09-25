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

        public formMedRecords(int selectedID, string firstname, string middlename, string lastname)
        {
            InitializeComponent();
            lblID.Text = selectedID.ToString();
            lblName.Text = lastname + ", " + firstname + " " + middlename;
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
                    com.Parameters.AddWithValue("@pulmonaries", txtPulm.Text);
                    com.Parameters.AddWithValue("@extra_pulmonaries", txtExpilm.Text);
                    //com.Parameters.AddWithValue("@smoke_day", lblID.Text);
                    com.Parameters.AddWithValue("@prepared_by", txtPrepared.Text);
                    com.Parameters.AddWithValue("@staff_position", txtPosition.Text);
                    com.Parameters.AddWithValue("@specimen_date1", dateTimePickerSpecimen1.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@speciman_date2", dateTimePickerSpecimen2.Value.ToString("yyyy-MM-dd"));

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
    }
}
