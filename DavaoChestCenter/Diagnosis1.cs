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
    public partial class Diagnosis1 : Form
    {
        int selectID;
        public Diagnosis1()
        {
            InitializeComponent();
        }

        private void testing1_Load(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["registration_id"].Visible = false;
                        dataGridView1.Columns["registration_id"].HeaderText = "Patient ID";
                        dataGridView1.Columns["appointmentDate"].HeaderText = "Appointment Date";
                        dataGridView1.Columns["patient_Fname"].HeaderText = "First Name";
                        dataGridView1.Columns["patient_Mname"].HeaderText = "Middle Name";
                        dataGridView1.Columns["patient_Lname"].HeaderText = "Last Name";
                        dataGridView1.Columns["patient_status"].HeaderText = "Status";
                        dataGridView1.Columns["patient_gender"].HeaderText = "Gender";
                        dataGridView1.Columns["services"].HeaderText = "Services";
                        dataGridView1.Columns["age"].HeaderText = "Age";
                        dataGridView1.Columns["address"].HeaderText = "Address";
                        dataGridView1.Columns["contact_num1"].HeaderText = "Contact Number";
                        dataGridView1.Columns["ref_Phys"].HeaderText = "Referring Physician";
                        dataGridView1.Columns["occupation"].HeaderText = "Occupation";
                        dataGridView1.Columns["CPLname"].HeaderText = "Contact Person Last Name";
                        dataGridView1.Columns["CPFname"].HeaderText = "Contact Person First Name";
                        dataGridView1.Columns["CPMname"].HeaderText = "Contact Person Middle Name";
                        dataGridView1.Columns["CPrelation"].HeaderText = "Contact Person Relation";
                        dataGridView1.Columns["CPcontact"].HeaderText = "Contact Person's Number";
                        dataGridView1.Columns["CPaddress"].HeaderText = "Contact Person's Address";
                        dataGridView1.Columns["weight"].HeaderText = "Weight";
                        dataGridView1.Columns["treatment_partner"].HeaderText = "Treatment Partner";
                        dataGridView1.Columns["pulmonaries"].HeaderText = "Pulmonaries";
                        dataGridView1.Columns["extra_pulmonaries"].HeaderText = "Extra_Pulmonaries";
                        dataGridView1.Columns["diabetic"].HeaderText = "Diabetic";
                        dataGridView1.Columns["hypertensive"].HeaderText = "Hypertensive";
                        dataGridView1.Columns["smoke"].HeaderText = "smoke";
                        dataGridView1.Columns["smoke_day"].HeaderText = "Times Smoking per day";
                        dataGridView1.Columns["start_smoking"].HeaderText = "Started Smoking";
                        dataGridView1.Columns["stop_smoking"].HeaderText = "Stopped Smoking";
                        dataGridView1.Columns["prev_tb"].HeaderText = "Previous TB";
                        dataGridView1.Columns["tb_months"].HeaderText = "Number of Months";
                        dataGridView1.Columns["medicines"].HeaderText = "Medicines";
                        dataGridView1.Columns["medicine_under"].HeaderText = "Medicines Taking";
                        dataGridView1.Columns["alcoholic"].HeaderText = "Alcoholic";
                        dataGridView1.Columns["alcohol_start"].HeaderText = "Started Drinking";
                        dataGridView1.Columns["alcohol_stop"].HeaderText = "Stopped Drinking";
                        dataGridView1.Columns["lab_crea"].HeaderText = "CREA";
                        dataGridView1.Columns["lab_sgpt"].HeaderText = "SGPT";
                        dataGridView1.Columns["lab_acid"].HeaderText = "ACID";
                        dataGridView1.Columns["chest_XrayResult"].HeaderText = "X-Ray Result";
                        dataGridView1.Columns["sputum_month"].HeaderText = "Sputum Month";
                        dataGridView1.Columns["sputum_due"].HeaderText = "Sputum Due";
                        dataGridView1.Columns["sputum_examDate"].HeaderText = "Sputum Exam Date";
                        dataGridView1.Columns["sputum_result"].HeaderText = "Sputum Result";
                        dataGridView1.Columns["sputum_appearance"].HeaderText = "Sputum Appearance";
                        dataGridView1.Columns["doctors_order"].HeaderText = "Doctor's Order";
                        dataGridView1.Columns["exam_reason"].HeaderText = "Reason for Examination";
                        dataGridView1.Columns["hist_treatment"].HeaderText = "History Treatment";
                        dataGridView1.Columns["specimen_type"].HeaderText = "Specimen Type";
                        dataGridView1.Columns["specimen_date1"].HeaderText = "Specimen Date 1";
                        dataGridView1.Columns["speciman_date2"].HeaderText = "Specimen Date 2";
                        dataGridView1.Columns["test_request"].HeaderText = "Test Request";
                        dataGridView1.Columns["prepared_by"].HeaderText = "Prepared By";
                        dataGridView1.Columns["staff_position"].HeaderText = "Staff Position";
                        dataGridView1.Columns["visual_appearance1"].HeaderText = "Visual Appearance 1";
                        dataGridView1.Columns["visual_appearance2"].HeaderText = "Visual Appearance 2";
                        dataGridView1.Columns["visual_appearanceXpert"].HeaderText = "Visual Appearance Xpert";
                        dataGridView1.Columns["reading1"].HeaderText = "Reading 1";
                        dataGridView1.Columns["reading2"].HeaderText = "Reading 2";
                        dataGridView1.Columns["readingX"].HeaderText = "Reading Xpert";
                        dataGridView1.Columns["LabDiag"].HeaderText = "Laboratory Diagnosis";
                        dataGridView1.Columns["LabX"].HeaderText = "Laboratory Xpert";
                        dataGridView1.Columns["tbdc_rec"].HeaderText = "TBDC Recording";
                        dataGridView1.Columns["suggestions"].HeaderText = "Suggestions";
                    }
                }
                con.Close();
            }

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form diag = new Diagnosis2();
            diag.Show();
            /*
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET patient_Lname = @patient_Lname WHERE registration_id = @registration_id", con))
                {
                    //com.Parameters.AddWithValue("@registration_id", txtID.Text);
                    //com.Parameters.AddWithValue("@patient_Lname", txtLname.Text);


                    DialogResult r = MessageBox.Show("Mark appointment as done?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
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
            */
        }

        private void btn_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();

                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["registration_id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["registration_id"].Value.ToString());
            string firstname = dataGridView1.Rows[e.RowIndex].Cells["patient_Fname"].Value.ToString();
            string middlename = dataGridView1.Rows[e.RowIndex].Cells["patient_Mname"].Value.ToString();
            string lastname = dataGridView1.Rows[e.RowIndex].Cells["patient_Lname"].Value.ToString();

            string lab_crea = dataGridView1.Rows[e.RowIndex].Cells["lab_crea"].Value.ToString();
            string lab_sgpt = dataGridView1.Rows[e.RowIndex].Cells["lab_sgpt"].Value.ToString();
            string lab_FBS = dataGridView1.Rows[e.RowIndex].Cells["lab_FBS"].Value.ToString();
            string lab_acid = dataGridView1.Rows[e.RowIndex].Cells["lab_acid"].Value.ToString();
            string chest_XrayResult = dataGridView1.Rows[e.RowIndex].Cells["chest_XrayResult"].Value.ToString();
            string sputum_month = dataGridView1.Rows[e.RowIndex].Cells["sputum_month"].Value.ToString();
            string sputum_due = dataGridView1.Rows[e.RowIndex].Cells["sputum_due"].Value.ToString();
            string sputum_examDate = dataGridView1.Rows[e.RowIndex].Cells["sputum_examDate"].Value.ToString();
            string sputum_result = dataGridView1.Rows[e.RowIndex].Cells["sputum_result"].Value.ToString();
            string sputum_appearance = dataGridView1.Rows[e.RowIndex].Cells["sputum_appearance"].Value.ToString();
            string doctors_order = dataGridView1.Rows[e.RowIndex].Cells["doctors_order"].Value.ToString();
            string exam_reason = dataGridView1.Rows[e.RowIndex].Cells["exam_reason"].Value.ToString();
            string hist_treatment = dataGridView1.Rows[e.RowIndex].Cells["hist_treatment"].Value.ToString();
            string specimen_type = dataGridView1.Rows[e.RowIndex].Cells["specimen_type"].Value.ToString();
            string specimen_date1 = dataGridView1.Rows[e.RowIndex].Cells["specimen_date1"].Value.ToString();
            string speciman_date2 = dataGridView1.Rows[e.RowIndex].Cells["speciman_date2"].Value.ToString();
            string test_request = dataGridView1.Rows[e.RowIndex].Cells["test_request"].Value.ToString();
            string prepared_by = dataGridView1.Rows[e.RowIndex].Cells["prepared_by"].Value.ToString();
            string staff_position = dataGridView1.Rows[e.RowIndex].Cells["staff_position"].Value.ToString();
            string visual_appearance1 = dataGridView1.Rows[e.RowIndex].Cells["visual_appearance1"].Value.ToString();
            string visual_appearance2 = dataGridView1.Rows[e.RowIndex].Cells["visual_appearance2"].Value.ToString();
            string visual_appearanceXpert = dataGridView1.Rows[e.RowIndex].Cells["visual_appearanceXpert"].Value.ToString();
            string reading1 = dataGridView1.Rows[e.RowIndex].Cells["reading1"].Value.ToString();
            string reading2 = dataGridView1.Rows[e.RowIndex].Cells["reading2"].Value.ToString();
            string readingX = dataGridView1.Rows[e.RowIndex].Cells["readingX"].Value.ToString();
            string LabDiag = dataGridView1.Rows[e.RowIndex].Cells["LabDiag"].Value.ToString();
            string LabX = dataGridView1.Rows[e.RowIndex].Cells["LabX"].Value.ToString();
            string tbdc_rec = dataGridView1.Rows[e.RowIndex].Cells["tbdc_rec"].Value.ToString();
            string suggestions = dataGridView1.Rows[e.RowIndex].Cells["suggestions"].Value.ToString();
            var diag = new Diagnosis2(selectID, firstname, middlename, lastname, lab_crea, lab_sgpt, lab_FBS,
                lab_acid, chest_XrayResult, sputum_month, sputum_due, sputum_examDate, sputum_result, sputum_appearance,
                doctors_order, exam_reason, hist_treatment, specimen_type, specimen_date1, speciman_date2, test_request,
                prepared_by, staff_position, visual_appearance1, visual_appearance2, visual_appearanceXpert, reading1, 
                reading2, readingX, LabDiag, LabX, tbdc_rec, suggestions);
            diag.ref_To_Main = this;
            diag.ShowDialog();
        }
    }
}
