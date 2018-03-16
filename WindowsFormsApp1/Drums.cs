using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Drums : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Drums()
        {
            InitializeComponent();
        }


        private void Drums_Load(object sender, EventArgs e)
        {
            //remove this

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //remove this

        }

        private void Snare_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums snare.wav";
            Player1.controls.play();
        }

        private void Hats_Click(object sender, EventArgs e)
        {
           WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums hat.wav";
            Player1.controls.play();
        }

        private void Bass_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums bass.wav";
            Player1.controls.play();
        }

        private void Tom1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums tom1.wav";
            Player1.controls.play();
        }

        private void Tom2_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums tom2.wav";
            Player1.controls.play();
        }

        private void FloorTom_Click(object sender, EventArgs e)
        {
           WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums floortom.wav";
            Player1.controls.play();
        }

        private void Crash_Click(object sender, EventArgs e)
        {
           WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Drums crash.wav";
            Player1.controls.play();
        }

        private void Crash_KeyDown(object sender, KeyEventArgs e)
        {
            //remove this

        }

        private void Drums_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    Bass.PerformClick();
                    break;
                case "2":
                    Snare.PerformClick();
                    break;
                case "3":
                    FloorTom.PerformClick();
                    break;
                case "4":
                    Tom1.PerformClick();
                    break;
                case "5":
                    Tom2.PerformClick();
                    break;
                case "6":
                    Crash.PerformClick();
                    break;
                case "0":
                    Hats.PerformClick();
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
    }
}
