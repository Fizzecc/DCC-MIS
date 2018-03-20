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
        public formProfile referenceToMain { get; set; }
        public formProfileNew()
        {
            InitializeComponent();
        }

        private Boolean validate()
        {
            if (textBoxNameFirst.Text.Equals(""))
            {
                MessageBox.Show("First name is not valid");
                return false;
            }
            else if (textBoxNameMiddle.Text.Equals(""))
            {
                MessageBox.Show("Middle name is not valid");
                return false;
            }
            else if (textBoxNameLast.Text.Equals(""))
            {
                MessageBox.Show("Last name is not valid");
                return false;
            }
            else if (textBoxUsername.Text.Equals(""))
            {
                MessageBox.Show("Username is not valid");
                return false;
            }
            else if (textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Password is not valid");
                return false;
            }
            else
            {
                return true;
            }


        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using(var com = new MySqlCommand("INSERT INTO staff VALUES(null, @firstname, @middlename, @lastname, @username, @password, @address, @contact)", con))
                {
                    com.Parameters.AddWithValue("@firstname", textBoxNameFirst.Text);
                    com.Parameters.AddWithValue("@middlename", textBoxNameMiddle.Text);
                    com.Parameters.AddWithValue("@lastname", textBoxNameLast.Text);
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    com.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    com.Parameters.AddWithValue("@contact", textBoxContact.Text);

                    DialogResult r = MessageBox.Show("Create new staff", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK && validate())
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }
                }

                int staffid = -1;

                using(var com = new MySqlCommand("SELECT id FROM staff WHERE username = @username AND password = @password", con))
                {
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);

                    using (var rdr = com.ExecuteReader())
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

                using(var com = new MySqlCommand("INSERT INTO schedules VALUES(null, @staffid, @schedule_days, @working_time_start, @working_time_end)", con))
                {
                    string daysWorking = "";

                    com.Parameters.AddWithValue("@staffid", staffid);

                    if (checkBoxMonday.Checked)
                    {
                        daysWorking += "Monday/";
                    }

                    if (checkBoxTuesday.Checked)
                    {
                        daysWorking += "Tuesday/";
                    }

                    if (checkBoxWednesday.Checked)
                    {
                        daysWorking += "Wednesday/";
                    }

                    if (checkBoxThursday.Checked)
                    {
                        daysWorking += "Thursday/";
                    }

                    if (checkBoxFriday.Checked)
                    {
                        daysWorking += "Friday/";
                    }

                    if (checkBoxSaturday.Checked)
                    {
                        daysWorking += "Saturday/";
                    }

                    if (checkBoxSunday.Checked)
                    {
                        daysWorking += "Sunday/";
                    }

                    daysWorking = daysWorking.TrimEnd('/');

                    com.Parameters.AddWithValue("@schedule_days", daysWorking);
                    com.Parameters.AddWithValue("@working_time_start", dateTimePickerWorkingTimeStart.Value.ToString("HH:mm:ss"));
                    com.Parameters.AddWithValue("@working_time_end", dateTimePickerWorkingTimeEnd.Value.ToString("HH:mm:ss"));

                    com.ExecuteNonQuery();
                }

                int scheduleid = -1;

                using(var com = new MySqlCommand("SELECT schedule_id FROM schedules WHERE staff_id = @staff_id", con))
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
                
                referenceToMain.refreshTables();

                con.Close();
            }
        }
    }
}
