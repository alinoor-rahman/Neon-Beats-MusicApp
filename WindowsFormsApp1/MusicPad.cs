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
using System.Media;


namespace WindowsFormsApp1
{
    public partial class MusicPad : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
       
        private SoundPlayer Player = new SoundPlayer();

        public MusicPad()
        {
            InitializeComponent();
        }

        private void CloserPad_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  g1.wav";
            Player1.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  g2.wav";
            Player1.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  g3.wav";
            Player1.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser b1.wav";
            Player1.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  b2.wav";
            Player1.controls.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  b3.wav";
            Player1.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  r1.wav";
            Player1.controls.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  r2.wav";
            Player1.controls.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "MusicPad CLoser  r3.wav";
            Player1.controls.play();
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //remove this
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
               //Media Library , SoundPlayer class

                WindowsMediaPlayer Player10 = new WindowsMediaPlayer();
                Player10.URL = "MusicPad CLoser beat1.wav";
                Player10.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                //Media Library , SoundPlayer class

                WindowsMediaPlayer Player11 = new WindowsMediaPlayer();
                Player11.URL = "MusicPad CLoser beat2.wav";
                Player11.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                //Media Library , SoundPlayer class

                WindowsMediaPlayer Player12 = new WindowsMediaPlayer();
                Player12.URL = "MusicPad CLoser beat3.wav";
                Player12.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CloserPad_KeyPress(object sender, KeyPressEventArgs e)
        {
            WindowsMediaPlayer Player10 = new WindowsMediaPlayer();
            switch (e.KeyChar.ToString())
            {
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "B":
                   // button10.PerformClick();
                    //WindowsMediaPlayer Player10 = new WindowsMediaPlayer();
                    if (WMPPlayState.wmppsPlaying == Player10.playState)
                    {
                        Player10.controls.stop();
                    }
                    else
                    {
                        Player10.URL = "MusicPad CLoser beat1.wav";
                        Player10.controls.play();
                    }

                    break;
                case "N":
                    button11.PerformClick();
                    break;
                case "M":
                    button12.PerformClick();
                    break;
               

            }

        }

        private void BackClick(object sender, EventArgs e)
        {
            NeonBeats n = new NeonBeats();
            n.Show();
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



        
    }
}
