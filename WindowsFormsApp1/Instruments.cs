using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Instruments : Form
    {
        public Instruments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guitar frm3 = new Guitar();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Piano frm4 = new Piano();
            frm4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NeonBeats frm1 = new NeonBeats();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drums d = new Drums();
            d.Show();
            this.Hide();
            //this.Hide();
        }

        private void Instruments_Load(object sender, EventArgs e)
        {

        }
    }
}
