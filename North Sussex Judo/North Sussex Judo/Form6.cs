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
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
        }
        static string connection = @"Data Source=DESKTOP-2EM15V1\SQLEXPRESS01;Initial Catalog=northsussex;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        private void button1_Click(object sender, EventArgs e)
        {
            string search = "Select * from Athlete  where Athlete_ID ='" + txtId.Text + "'";
            SqlCommand cmd = new SqlCommand(search, con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                string total = r["Total_fee"].ToString();
                double fee;
                fee = double.Parse(total) * 4;

                string compCount = r["Competition_count"].ToString();
                double competitionFee;
                competitionFee = double.Parse(compCount) * 22.00;

                double monthlyFee;
                monthlyFee = fee + competitionFee;

                string name = r["Name"].ToString();
                string trainingFee= r["Training_fee"].ToString();
                string coachingFee= r["Coaching_fee"].ToString();

                con.Close();
                con.Open();

                string insert = "Insert into Payment values('" + txtId.Text + "','" + name + "','" + trainingFee + "','" + coachingFee + "','"+
                    competitionFee + "','" + monthlyFee + "')";

                SqlCommand cmdd = new SqlCommand(insert, con);
                cmdd.ExecuteNonQuery();

                SqlDataAdapter dtadpt = new SqlDataAdapter("select * from Payment", con);
                DataTable dttbl = new DataTable();
                dtadpt.Fill(dttbl);
                gridviewPayment.DataSource = dttbl;
                con.Close();
                MessageBox.Show("successfully saved in Payment database", "Message");

                txtId.Clear();

            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            filldata();
        }
        private void filldata()
        {
            con.Open();

            SqlDataAdapter dtadpt = new SqlDataAdapter("select * from Payment", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            gridviewPayment.DataSource = dttbl;

            con.Close();
        }

        private void btndashBoard_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }
    }
}
