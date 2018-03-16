using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Guitar : Form

    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Guitar()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Guitar C.wav";
            Player1.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player2 = new WindowsMediaPlayer();
            Player2.URL = "Guitar C#.wav";
            Player2.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player3 = new WindowsMediaPlayer();
            Player3.URL = "Guitar C#m.wav";
            Player3.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player4 = new WindowsMediaPlayer();
            Player4.URL = "Guitar D.wav";
            Player4.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player5 = new WindowsMediaPlayer();
            Player5.URL = "Guitar D#.wav";
            Player5.controls.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player6 = new WindowsMediaPlayer();
            Player6.URL = "Guitar E.wav";
            Player6.controls.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player7 = new WindowsMediaPlayer();
            Player7.URL = "Guitar Em.wav";
            Player7.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player8 = new WindowsMediaPlayer();
            Player8.URL = "Guitar F.wav";
            Player8.controls.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player9 = new WindowsMediaPlayer();
            Player9.URL = "Guitar F#.wav";
            Player9.controls.play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player10 = new WindowsMediaPlayer();
            Player10.URL = "Guitar G.wav";
            Player10.controls.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player12 = new WindowsMediaPlayer();
            Player12.URL = "Guitar G#.wav";
            Player12.controls.play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player13 = new WindowsMediaPlayer();
            Player13.URL = "Guitar A.wav";
            Player13.controls.play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player14 = new WindowsMediaPlayer();
            Player14.URL = "Guitar Am.wav";
            Player14.controls.play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player15 = new WindowsMediaPlayer();
            Player15.URL = "Guitar A#.wav";
            Player15.controls.play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player16 = new WindowsMediaPlayer();
            Player16.URL = "Guitar B.wav";
            Player16.controls.play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player11 = new WindowsMediaPlayer();
            Player11.URL = "Guitar Bm.wav";
            Player11.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guitar_KeyPress(object sender, KeyPressEventArgs e)
        {
          
         
            switch (e.KeyChar.ToString())
            {
                case "Q":
                    button1.PerformClick();
                    break;

                case "W":
                    button2.PerformClick();
                    break;

                case "E":
                    button3.PerformClick();
                    break;

                case "R":
                    button4.PerformClick();
                    break;

                case "T":
                    button5.PerformClick();
                    break;

                case "Y":
                    button6.PerformClick();
                    break;

                case "U":
                    button8.PerformClick();
                    break;

                case "I":
                    button7.PerformClick();
                    break;

                case "O":
                    button9.PerformClick();
                    break;

                case "P":
                    button10.PerformClick();
                    break;
                case "A":
                    button12.PerformClick();
                    break;

                case "S":
                    button13.PerformClick();
                    break;

                case "D":
                    button14.PerformClick();
                    break;

                case "F":
                    button15.PerformClick();
                    break;

                case "G":
                    button16.PerformClick();
                    break;

                case "H":
                    button11.PerformClick();
                    break;

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Instruments ins = new Instruments();
            ins.Show();
            this.Hide();
        }
        private string a;
        private void OpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {

                a = open.FileName;

                WMP1.URL = a;
                WMP1.Ctlcontrols.play();

                pauseButton.Enabled = true;
            }
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

        private void Guitar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }


        
    }
}
