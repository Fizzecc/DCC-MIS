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
    public partial class formProfileUpdate : Form
    {
        public formProfile referenceToMain { get; set; }

        int selectedUser = -1;

        public formProfileUpdate()
        {
            InitializeComponent();
        }

        public formProfileUpdate(int x,
            string firstname, string middlename, string lastname,
            string username, string password,
            string schedule_days, string working_time_start, string working_time_end,
            string address, string contact)
        {
            InitializeComponent();

            selectedUser = x;

            textBoxNameFirst.Text = firstname;
            textBoxNameMiddle.Text = middlename;
            textBoxNameLast.Text = lastname;
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            dateTimePickerWorkingTimeStart.Value = DateTime.Parse(working_time_start);
            dateTimePickerWorkingTimeEnd.Value = DateTime.Parse(working_time_end);

            string[] split = schedule_days.Split('/');

            foreach(string word in split)
            {
                if (word == "Monday")
                    checkBoxMonday.Checked = true;
                if (word == "Tuesday")
                    checkBoxTuesday.Checked = true;
                if (word == "Wednesday")
                    checkBoxWednesday.Checked = true;
                if (word == "Thursday")
                    checkBoxThursday.Checked = true;
                if (word == "Friday")
                    checkBoxFriday.Checked = true;
                if (word == "Saturday")
                    checkBoxSaturday.Checked = true;
                if (word == "Sunday")
                    checkBoxSunday.Checked = true;
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE staff SET firstname = @firstname, middlename = @middlename, lastname = @lastname, username = @username, password = @password, contact = @contact, address = @address WHERE id = @id", con))
                {
                    com.Parameters.AddWithValue("@firstname", textBoxNameFirst.Text);
                    com.Parameters.AddWithValue("@middlename", textBoxNameMiddle.Text);
                    com.Parameters.AddWithValue("@lastname", textBoxNameLast.Text);
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    com.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    com.Parameters.AddWithValue("@contact", textBoxContact.Text);
                    com.Parameters.AddWithValue("@id", selectedUser);

                    com.ExecuteNonQuery();
                }

                using (var com = new MySqlCommand("UPDATE schedules SET schedule_days = @schedule_days, working_time_start = @working_time_start, working_time_end = @working_time_end WHERE staff_id = @staff_id", con))
                {
                    string daysWorking = "";

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
                    com.Parameters.AddWithValue("@staff_id", selectedUser);

                    com.ExecuteNonQuery();

                    referenceToMain.refreshTables();
                }
                con.Close();
            }
        }
    }
}
