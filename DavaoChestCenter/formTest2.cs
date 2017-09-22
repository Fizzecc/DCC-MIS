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
    public partial class formTest2 : Form
    {
        public formTest1 ref_To_Main { get; set; }

        public formTest2()
        {
            InitializeComponent();
        }

        private void test2_Load(object sender, EventArgs e)
        {

        }
    }
}
