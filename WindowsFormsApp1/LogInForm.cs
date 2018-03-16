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

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sakib\Documents\BeatNewDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back
            NeonBeats n = new NeonBeats();
            n.Show();
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login
            con.Open();

            string query1 = "SELECT COUNT(*) FROM BeatTable2 WHERE Email = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";

            SqlDataAdapter SDA = new SqlDataAdapter(query1, con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("logged in");
                con.Close();
            }
            else {
                MessageBox.Show("try again");
                con.Close();
            }

        }
    }
}
