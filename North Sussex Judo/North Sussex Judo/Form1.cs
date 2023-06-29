using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_Sussex_Judo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string Username = usrnametxtbx.Text;
            string Password = passwrdtxtbx.Text;

            if (Username == "123" && Password == "123")
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);

                usrnametxtbx.Clear();
                passwrdtxtbx.Clear();
            }
        }

        private void loginlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
