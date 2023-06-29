using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace North_Sussex_Judo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string connection = @"Data Source=DESKTOP-2EM15V1\SQLEXPRESS01;Initial Catalog=northsussex;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        private void cstmrlbl_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtCompcount.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtWeight.Clear();
            cmbLevel.ResetText();
            cmbprivate.ResetText();
            txtpFee.Text = "£0.00";
            txttFee.Text = "£0.00";
            txttotal.Text = "£0.00";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete = "delete from Athlete where Name ='" + txtName.Text + "'";
            if (MessageBox.Show("Are you sure to delete data?", "confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Message");
                txtName.Clear();
            }
            con.Close();
            filldata();
        }
        private void filldata()
        {
            con.Open();

            SqlDataAdapter dtadpt = new SqlDataAdapter("select * from Athlete", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            dataGridView1.DataSource = dttbl;

            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            filldata();
            this.cmbprivate.SelectedIndex = 0;
            this.cmbLevel.SelectedIndex = 0;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //adding pound sign
            string total = txttotal.Text.Replace("£", "");
            string coaching_Fee = txtpFee.Text.Replace("£", "");
            string training_Fee = txttFee.Text.Replace("£", "");
            // opening the database connection
            con.Open();
            //assining the value to database
            string insert = "Insert into Athlete values('" + txtName.Text + "','" +
                txtEmail.Text + "','" +
                cmbLevel.Text + "','" +
                int.Parse(txtWeight.Text) + "','" +
                txtCompcount.Text + "','" +
                int.Parse(cmbprivate.Text) + "','" +
                txtWeightcat.Text + "' ,'" +
                coaching_Fee + "',' " +
                training_Fee + "','" +
                total + "')";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            //closing the database
            con.Close();
            filldata();
            MessageBox.Show("successfully saved in Athlete database", "Message");
            //clear all text in field
            txtCompcount.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtWeight.TextChanged -= txtWeight_TextChanged;
            txtWeight.Clear();
            cmbLevel.ResetText();
            cmbprivate.ResetText();
            txtpFee.Text = "£0.00";
            txttFee.Text = "£0.00";
            txttotal.Text = "£0.00";
            txtWeightcat.Clear();
            txtWeight.TextChanged += txtWeight_TextChanged;


        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //training plan calculation
            if (cmbLevel.Text == "Beginner")
            {
                txttFee.Text = "£25.00";
                txtCompcount.ReadOnly = true; //greyout the input
            }
            else if (cmbLevel.Text == "Intermediate")
            {
                txttFee.Text = "£30.00";
                txtCompcount.ReadOnly = false; //enable the input
            }
            else if (cmbLevel.Text == "Elite")
            {
                txttFee.Text = "£35.00";
                txtCompcount.ReadOnly = false;
            }
        }

        private void cmbprivate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Private couching hour calculation
            if (cmbprivate.Text == "")
            {
                txtpFee.Text = "£0";
            }
            else if (cmbprivate.Text == "1")
            {
                txtpFee.Text = "£9.50";
            }
            else if (cmbprivate.Text == "2")
            {
                txtpFee.Text = "£19.00";
            }
            else if (cmbprivate.Text == "3")
            {
                txtpFee.Text = "£28.50";
            }
            else if (cmbprivate.Text == "4")
            {
                txtpFee.Text = "£38.00";
            }
            else if (cmbprivate.Text == "5")
            {
                txtpFee.Text = "£47.50";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double total;
            total = double.Parse(txttFee.Text.Replace("£", "")) + double.Parse(txtpFee.Text.Replace("£", ""));
            txttotal.Text = total.ToString("£0.00");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {


            //Weight categeory variable
            string weightCategory;

            int parsedValue;
            //Converting weight to integer


            if (string.IsNullOrEmpty(txtWeight.Text))
            {

                MessageBox.Show("This Field can't be emty", "Message");
            }

            else if (int.TryParse(txtWeight.Text, out parsedValue))
            {

                int weight = int.Parse(txtWeight.Text);
                if (weight > 100)
                {
                    weightCategory = "Heavyweight";
                }
                else if (weight <= 100 && weight >= 90)
                {
                    weightCategory = "lightheaveyweight";
                }
                else if (weight <= 90 && weight >= 81)
                {
                    weightCategory = "Middleweight";
                }
                else if (weight <= 81 && weight >= 73)
                {
                    weightCategory = "Lightweight";
                }
                else if (weight <= 73 && weight >= 66)
                {
                    weightCategory = "Lightweight";
                }
                else if (weight >= 0)
                {
                    weightCategory = "Flyweight";
                }

                else if (txtWeight.Text == "" || txtWeight.Text.Length == 0)
                {
                    weightCategory = "invalid";
                }
                else
                {
                    weightCategory = "invalid";
                }
                txtWeightcat.Text = weightCategory;
            }
            else
            {

                MessageBox.Show("The input should be number", "Message");
                //Stop textchange event
                txtWeight.TextChanged -= txtWeight_TextChanged;
                txtWeight.Clear();
                //Start textchange event
                txtWeight.TextChanged += txtWeight_TextChanged;
            }



        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_Click(object sender, EventArgs e)
        {

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }
    }
}