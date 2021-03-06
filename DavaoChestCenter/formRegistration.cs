﻿using System;
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
        Dictionary<int, string> services = new Dictionary<int, string>();

        public formAppointment ref_To_Main { get; set; }
        public formRegistration()
        {
            InitializeComponent();

            gatherServices();
        }

        public formRegistration(int selectIDappointment, string firstname,  string middlename, 
            string lastname, string patient_status, string patient_gender, string services, string age, 
            string address, string contact_num1, string ref_Phys, string occupation, string CPLname, 
            string CPFname, string CPMname, string CPaddress, string CPrelation, string CPcontact, string weight)
        {
            InitializeComponent();
            txtFname.Text = firstname;
            txtMname.Text = middlename;
            txtLname.Text = lastname;
            txtAge.Text = age;
            txtAddress.Text = address;
            txtContact.Text = contact_num1;
            txtPhys.Text = ref_Phys;
            txtOccupation.Text = occupation;
            txtCPLname.Text = CPLname;
            txtCPFname.Text = CPFname;
            txtCPMname.Text = CPMname;
            txtCPrel.Text = CPrelation;
            txtCPContact.Text = CPcontact;
            txtCPAddress.Text = CPaddress;
            txtWeight.Text = weight;

            if(patient_status == "Single")
            {
                radButtonSingle.Checked = true;
            }
            if(patient_status == "Married")
            {
                radButtonMarried.Checked = true;
            }
            if(patient_gender == "Male")
            {
                radButtonMale.Checked = true;
            }
            if(patient_gender == "Female")
            {
                radButtonFemale.Checked = true;
            }
            gatherServices();
        }

        private Boolean validate()
        {
            if(txtLname.Text == "")
            {
                MessageBox.Show("Invalid Last name");
                return false;
            }
            if (txtFname.Text == "")
            {
                MessageBox.Show("Invalid First name");
                return false;
            }
            if (txtMname.Text == "")
            {
                MessageBox.Show("Invalid Middle name");
                return false;
            }
            if (radButtonSingle.Checked == false && radButtonMarried.Checked == false)
            {
                MessageBox.Show("Invalid Civil Status. Please choose one");
                return false;
            }
            if (radButtonMale.Checked == false && radButtonFemale.Checked == false)
            {
                MessageBox.Show("Invalid Gender. Please choose one.");
                return false;
            }
            if (comboBoxService.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Invalid Service. Please Select one");
                return false;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Invalid Age.");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Invalid Address");
                return false;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Invalid Contact");
                return false;
            }
            if (txtPhys.Text == "")
            {
                MessageBox.Show("Invalid Referring Physician");
                return false;
            }
            if (txtOccupation.Text == "")
            {
                MessageBox.Show("Invalid Occupation");
                return false;
            }
            if (txtCPLname.Text == "")
            {
                MessageBox.Show("Invalid Last name");
                return false;
            }
            if (txtCPFname.Text == "")
            {
                MessageBox.Show("Invalid Last name");
                return false;
            }
            if (txtCPMname.Text == "")
            {
                MessageBox.Show("Invalid Last name");
                return false;
            }
            if (txtCPrel.Text == "")
            {
                MessageBox.Show("Invalid Last name");
                return false;
            }
            if (txtCPContact.Text == "")
            {
                MessageBox.Show("Invalid Contact");
                return false;
            }
            if (txtCPAddress.Text == "")
            {
                MessageBox.Show("Invalid Address");
                return false;
            }
            if (txtWeight.Text == "")
            {
                MessageBox.Show("Invalid Weight");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void gatherServices()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM services", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                services.Add(rdr.GetInt32(0), rdr.GetString(3));

                                comboBoxService.DataSource = new BindingSource(services, null);
                                comboBoxService.DisplayMember = "Value";
                                comboBoxService.ValueMember = "Key";
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                con.Close();
            }
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
                using (var com = new MySqlCommand("INSERT INTO registration VALUES(null, @patient_Lname, @patient_Fname, @patient_Mname, @patient_status, @patient_gender, @services, @appointmentDate, @age, @address, @contact_num1, @ref_Phys, @occupation, @CPLname, @CPFname, @CPMname, @CPrelation, @CPcontact, @CPaddress, @treatment_partner, @weight, @pulmonaries, @extra_pulmonaries, @diabetic, @hypertensive, @smoke, @smoke_day, @start_smoking, @stop_smoking, @prev_tb, @tb_months, @tb_date, @medicines, @medicine_under, @alcoholic, @alcohol_start, @alcohol_stop, @exam_reason, @hist_treatment, @specimen_type, @specimen_date1, @speciman_date2, @test_request, @prepared_by, @staff_position, @lab_crea, @lab_sgpt, @lab_FBS, @lab_acid, @chest_XrayResult, @sputum_month, @sputum_due, @sputum_examDate, @sputum_result, @sputum_appearance, @doctors_order, @visual_appearance1, @visual_appearance2, @visual_appearanceXpert, @reading1, @reading2, @readingX, @LabDiag, @LabX, @tbdc_rec, @suggestions)", con))
                {
                    com.Parameters.AddWithValue("@patient_Lname", txtLname.Text);
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
                    com.Parameters.AddWithValue("@weight", txtWeight.Text);
                    com.Parameters.AddWithValue("@CPrelation", txtCPrel.Text);
                    com.Parameters.AddWithValue("@CPcontact", txtCPContact.Text);
                    com.Parameters.AddWithValue("@CPaddress", txtCPAddress.Text);
                    com.Parameters.AddWithValue("@services", ((KeyValuePair<int, string>)comboBoxService.SelectedItem).Key);

                    /*
                    com.Parameters.AddWithValue("@treatment_partner", comboBoxTreat.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@weight", txtWeight.Text);
                    com.Parameters.AddWithValue("@contact_num2", txtTcontact.Text);
                    com.Parameters.AddWithValue("@pulmonaries", txtPulm.Text);
                    com.Parameters.AddWithValue("@extra_pulmonaries", txtEpulm.Text);
                    com.Parameters.AddWithValue("@specimen_date1", dateTimePickerSpecimen1.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@specimen_date2", dateTimePickerSpecimen2.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@prepared_by", txtPrepared.Text);
                    com.Parameters.AddWithValue("@staff_position", txtPosition.Text);


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
                        com.Parameters.AddWithValue("@smoke", radButtonSmokeNo.Text);
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
                    */

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

                    //exam reason
                    /*
                    if (radButtDiagnosis.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtDiagnosis.Text);
                    }
                    if (radButtBaseline.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtBaseline.Text);
                    }
                    if (radButtonFollow.Checked)
                    {
                        com.Parameters.AddWithValue("@exam_reason", radButtonFollow.Text);
                    }

                    //history treatment
                    if (radButtonHistNew.Checked)
                    {
                        com.Parameters.AddWithValue("@hist_treatment", radButtonHistNew.Text);
                    }
                    if (radButtonHistRT.Checked)
                    {
                        com.Parameters.AddWithValue("@hist_treatment", radButtonHistRT.Text);
                    }

                    //specimen type
                    if (radButtonSputum.Checked)
                    {
                        com.Parameters.AddWithValue("@specimen_type", radButtonSputum.Text);
                    }
                    if (radButtonOthers.Checked)
                    {
                        com.Parameters.AddWithValue("@specimen_type", txtOthers.Text);
                    }

                    //test request
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
                    */

                    com.Parameters.AddWithValue("@treatment_partner", "");
                    
                    com.Parameters.AddWithValue("@pulmonaries", "");
                    com.Parameters.AddWithValue("@extra_pulmonaries", "");
                    com.Parameters.AddWithValue("@diabetic", "");
                    com.Parameters.AddWithValue("@hypertensive", "");
                    com.Parameters.AddWithValue("@smoke", "");
                    com.Parameters.AddWithValue("@smoke_day", "");
                    com.Parameters.AddWithValue("@start_smoking", "");
                    com.Parameters.AddWithValue("@stop_smoking", "");
                    com.Parameters.AddWithValue("@prev_tb", "");
                    com.Parameters.AddWithValue("@tb_months", "");
                    com.Parameters.AddWithValue("@tb_date", "");
                    com.Parameters.AddWithValue("@medicines", "");
                    com.Parameters.AddWithValue("@medicine_under", "");
                    com.Parameters.AddWithValue("@alcoholic", "");
                    com.Parameters.AddWithValue("@alcohol_start", "");
                    com.Parameters.AddWithValue("@alcohol_stop", "");
                    com.Parameters.AddWithValue("@exam_reason", "");
                    com.Parameters.AddWithValue("@hist_treatment", "");
                    com.Parameters.AddWithValue("@specimen_type", "");
                    com.Parameters.AddWithValue("@specimen_date1", "");
                    com.Parameters.AddWithValue("@speciman_date2", "");
                    com.Parameters.AddWithValue("@test_request", "");
                    com.Parameters.AddWithValue("@prepared_by", "");
                    com.Parameters.AddWithValue("@staff_position", "");
                    com.Parameters.AddWithValue("@lab_crea", "");
                    com.Parameters.AddWithValue("@lab_sgpt", "");
                    com.Parameters.AddWithValue("@lab_FBS", "");
                    com.Parameters.AddWithValue("@lab_acid", "");
                    com.Parameters.AddWithValue("@chest_XrayResult", "");
                    com.Parameters.AddWithValue("@sputum_month", "");
                    com.Parameters.AddWithValue("@sputum_due", "");
                    com.Parameters.AddWithValue("@sputum_examDate", "");
                    com.Parameters.AddWithValue("@sputum_result", "");
                    com.Parameters.AddWithValue("@sputum_appearance", "");
                    com.Parameters.AddWithValue("@visual_appearance1", "");
                    com.Parameters.AddWithValue("@visual_appearance2", "");
                    com.Parameters.AddWithValue("@visual_appearanceXpert", "");
                    com.Parameters.AddWithValue("@reading1", "");
                    com.Parameters.AddWithValue("@reading2", "");
                    com.Parameters.AddWithValue("@readingX", "");
                    com.Parameters.AddWithValue("@LabDiag", "");
                    com.Parameters.AddWithValue("@LabX", "");
                    com.Parameters.AddWithValue("@tbdc_rec", "");
                    com.Parameters.AddWithValue("@suggestions", "");
                    com.Parameters.AddWithValue("@doctors_order", "");

                    DialogResult r = MessageBox.Show("Appointment Added", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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


        private void formRegistration_Load(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void radButtonSmokeYes_CheckedChanged(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void radButtonSmokeNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (radButtonTBYes.Checked)
            {
                dateTimeTBTreat.Enabled = true;
                checkBoxAB.Enabled = true;
                checkBoxTB.Enabled = true;
                txtMonths.Enabled = true;
                txtMedicines.Enabled = true;
            }

            if (radButtonTBNo.Checked)
            {
                dateTimeTBTreat.Enabled = false;
                checkBoxAB.Enabled = false;
                checkBoxTB.Enabled = false;
                txtMonths.Enabled = false;
                txtMedicines.Enabled = false;
            }
            */
        }

        private void radButtonAlcoholicYes_CheckedChanged(object sender, EventArgs e)
        {
            /*
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
            */
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
            //txtTreatment.Text = "Dr. Effren Salvado";
            /*
            txtWeight.Text = "65";
            txtTcontact.Text = "2673";
            txtPulm.Text = "Cough";
            txtEpulm.Text = "Pimples";
            */
        }

        private void radButtonSputum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCough.Checked)
            {
                txtPulm.AppendText(checkBoxCough.Text + ", ");
            }
        }

        private void txtPulm_TextChanged(object sender, EventArgs e)
        {
            
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

        private void checkBoxDypsnea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDypsnea.Checked)
            {
                txtPulm.AppendText(checkBoxDypsnea.Text + ", ");
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtPulm.Text = "";
            checkBoxCough.Checked = false;
            checkBoxFever.Checked = false;
            checkBoxSputum.Checked = false;
            checkBoxWeight.Checked = false;
            checkBoxHemo.Checked = false;
            checkBoxChest.Checked = false;
            checkBoxDypsnea.Checked = false;
            checkBoxChills.Checked = false;
            checkBoxFatigue.Checked = false;
            checkBoxMalaise.Checked = false;

        }
        */
    }
}
