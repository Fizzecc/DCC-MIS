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
    public partial class formProfileNew : Form
    {
        public formProfileNew()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using(MySqlCommand com = new MySqlCommand("INSERT INTO users VALUES(null, @firstname, @middlename, @lastname, @username, @password, @birthdate, @sex, @type)", con))
                {
                    com.Parameters.AddWithValue("@firstname", textBoxNameFirst.Text);
                    com.Parameters.AddWithValue("@middlename", textBoxNameMiddle.Text);
                    com.Parameters.AddWithValue("@lastname", textBoxNameLast.Text);
                    com.Parameters.AddWithValue("@birthdate", dateTimePickerDateBirth.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sex", comboBoxSex.Text);
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    com.Parameters.AddWithValue("@type", "Staff");

                    DialogResult r = MessageBox.Show("Create new staff", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK)
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }
                }

                int staffid = -1;

                using(MySqlCommand com = new MySqlCommand("SELECT id FROM users WHERE username = @username AND password = @password", con))
                {
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);

                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            staffid = rdr.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("The staff creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                using(MySqlCommand com = new MySqlCommand("INSERT INTO schedule VALUES(null, @staffid, @clinicaddress, @schedule_days, @working_time_start, @working_time_end)", con))
                {
                    string daysWorking = "";

                    com.Parameters.AddWithValue("@staffid", staffid);
                    com.Parameters.AddWithValue("@clinicaddress", textBoxAddressClinic.Text);

                    if (checkBoxMondayStaff.Checked)
                    {
                        daysWorking += "Monday/";
                    }

                    if (checkBoxTuesdayStaff.Checked)
                    {
                        daysWorking += "Tuesday/";
                    }

                    if (checkBoxWednesdayStaff.Checked)
                    {
                        daysWorking += "Wednesday/";
                    }

                    if (checkBoxThursdayStaff.Checked)
                    {
                        daysWorking += "Thursday/";
                    }

                    if (checkBoxFridayStaff.Checked)
                    {
                        daysWorking += "Friday/";
                    }

                    if (checkBoxSaturdayStaff.Checked)
                    {
                        daysWorking += "Saturday/";
                    }

                    if (checkBoxSundayStaff.Checked)
                    {
                        daysWorking += "Sunday/";
                    }

                    daysWorking = daysWorking.TrimEnd('/');

                    com.Parameters.AddWithValue("@schedule_days", daysWorking);
                    com.Parameters.AddWithValue("@working_time_start", dateTimePickerWorkingTimeStartStaff.Value.ToString("HH:mm:ss"));
                    com.Parameters.AddWithValue("@working_time_end", dateTimePickerWorkingTimeEndStaff.Value.ToString("HH:mm:ss"));

                    com.ExecuteNonQuery();
                }

                int scheduleid = -1;

                using(MySqlCommand com = new MySqlCommand("SELECT schedule_id FROM schedule WHERE staff_id = @staff_id", con))
                {
                    com.Parameters.AddWithValue("@staff_id", staffid);

                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            scheduleid = rdr.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("no schedule for " + staffid, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                con.Close();
            }
        }

        private void buttonCreateDoctor_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO users VALUES(null, @firstname, @middlename, @lastname, @username, @password, @birthdate, @sex, @type)", con))
                {
                    com.Parameters.AddWithValue("@firstname", textBoxNameFirst.Text);
                    com.Parameters.AddWithValue("@middlename", textBoxNameMiddle.Text);
                    com.Parameters.AddWithValue("@lastname", textBoxNameLast.Text);
                    com.Parameters.AddWithValue("@birthdate", dateTimePickerDateBirth.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sex", comboBoxSex.Text);
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    com.Parameters.AddWithValue("@type", "Doctor");

                    DialogResult r = MessageBox.Show("Create new staff", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK)
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }
                }

                int staffid = -1;

                using (MySqlCommand com = new MySqlCommand("SELECT id FROM users WHERE username = @username AND password = @password", con))
                {
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);

                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            staffid = rdr.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("The staff creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                using (MySqlCommand com = new MySqlCommand("INSERT INTO schedule VALUES(null, @staffid, @clinicaddress, @schedule_days, @working_time_start, @working_time_end)", con))
                {
                    string daysWorking = "";

                    com.Parameters.AddWithValue("@staffid", staffid);
                    com.Parameters.AddWithValue("@clinicaddress", "null");

                    if (checkBoxMondayDoctor.Checked)
                    {
                        daysWorking += "Monday/";
                    }

                    if (checkBoxTuesdayDoctor.Checked)
                    {
                        daysWorking += "Tuesday/";
                    }

                    if (checkBoxWednesdayDoctor.Checked)
                    {
                        daysWorking += "Wednesday/";
                    }

                    if (checkBoxThursdayDoctor.Checked)
                    {
                        daysWorking += "Thursday/";
                    }

                    if (checkBoxFridayDoctor.Checked)
                    {
                        daysWorking += "Friday/";
                    }

                    if (checkBoxSaturdayDoctor.Checked)
                    {
                        daysWorking += "Saturday/";
                    }

                    if (checkBoxSundayDoctor.Checked)
                    {
                        daysWorking += "Sunday/";
                    }

                    daysWorking = daysWorking.TrimEnd('/');

                    com.Parameters.AddWithValue("@schedule_days", daysWorking);
                    com.Parameters.AddWithValue("@working_time_start", dateTimePickerWorkingTimeStartDoctor.Value.ToString("HH:mm:ss"));
                    com.Parameters.AddWithValue("@working_time_end", dateTimePickerWorkingTimeEndDoctor.Value.ToString("HH:mm:ss"));

                    com.ExecuteNonQuery();
                }

                int scheduleid = -1;

                using (MySqlCommand com = new MySqlCommand("SELECT schedule_id FROM schedule WHERE staff_id = @staff_id", con))
                {
                    com.Parameters.AddWithValue("@staff_id", staffid);

                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            scheduleid = rdr.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("no schedule for " + staffid, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
