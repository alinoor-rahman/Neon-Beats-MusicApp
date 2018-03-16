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
    public partial class NeonBeats : Form
    {
        public NeonBeats()
        {
            InitializeComponent();
        }

        private void label_Instrument_Click(object sender, EventArgs e)
        {
            Instruments frm = new Instruments();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Karaoke k = new Karaoke();
            k.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MusicPad mp = new MusicPad();
            mp.Show();
            this.Hide();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            CreAcc ca = new CreAcc();
            ca.Show();
            this.Hide();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            LogInForm logf = new LogInForm();
            logf.Show();
            this.Hide();
        }

        private void NeonBeats_Load(object sender, EventArgs e)
        {
            label_Instrument.Parent = pictureBox1;
            label_Instrument.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }
    }
}
