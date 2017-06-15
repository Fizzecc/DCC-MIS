using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavaoChestCenter
{
    public partial class formMenu : Form
    {
        public formLogIn referenceToMain { get; set; }

        int id = -1;
        string name = "";
        public formMenu(int x, string y)
        {
            InitializeComponent();

            id = x;
            name = y;

            labelName.Text = name;
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            referenceToMain.Show();
            Dispose();
        }

        private void buttonSchedules_Click(object sender, EventArgs e)
        {
            formSchedules schedules = new formSchedules(id);
            schedules.ShowDialog();
        }

        private void buttonModule1_Click(object sender, EventArgs e)
        {
            formModule1 module1 = new formModule1(id, name);
            module1.ShowDialog();
        }
    }
}
