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
    public partial class CreAcc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sakib\Documents\BeatNewDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public CreAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "INSERT INTO BeatTable2 (Name,Password,Email,Number) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Beatlami b1 = new Beatlami();
          // b1.Show();
            NeonBeats n = new NeonBeats();
            n.Show();
            this.Hide();
        }

        private void CreAcc_Load(object sender, EventArgs e)
        {
           
        }
    }
}
