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
    public partial class Karaoke : Form
    {
        public Karaoke()
        {
            InitializeComponent();
        }
        private string path;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            NeonBeats n = new NeonBeats();
            n.Show();
            this.Hide();
        }



        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text.Equals("Pause"))
            {
                WMP1.Ctlcontrols.pause();
                pauseButton.Text = "Play";
            }
            else
            {
                WMP1.Ctlcontrols.play();
                pauseButton.Text = "Pause";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
             WMP1.Ctlcontrols.stop();
        }

        private void OpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {

                path = open.FileName;

                WMP1.URL = path;
                WMP1.Ctlcontrols.play();

                pauseButton.Enabled = true;
            }
        }

        
    }
}
