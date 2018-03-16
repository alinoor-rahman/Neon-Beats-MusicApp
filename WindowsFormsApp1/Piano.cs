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
    public partial class Piano : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Piano()
        {
            InitializeComponent();
        }

          private void Piano_Load(object sender, EventArgs e)
        {

        }

        private void Piano_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "A":
                    A.PerformClick();
                    break;

                case "S":
                    S.PerformClick();
                    break;

                case "D":
                    D.PerformClick();
                    break;

                case "F":
                    F.PerformClick();                  
                    break;

                case "G":
                    G.PerformClick();
                    break;

                case "H":
                    H.PerformClick();
                    break;

                case "J":
                    J.PerformClick();
                    break;

                case "K":
                    K.PerformClick();
                    break;

                case "L":
                    L.PerformClick();
                    break;

                case ";":
                    B4.PerformClick();
                    break;
                case "'":
                    C5.PerformClick();
                    break;

               case "]":
                    D5.PerformClick();
                    break;

                case "W":
                    W.PerformClick();
                    break;

                case "E":
                    E.PerformClick();
                    break;

                case "R":
                    R.PerformClick();
                    break;

                case "T":
                    T.PerformClick();
                    break;

                case "Y":
                    Y.PerformClick();
                    break;

                case "I":
                    I.PerformClick();
                    break;
                case "O":
                    O.PerformClick();
                    break;

                case "P":
                    P.PerformClick();
                    break;

                case "[":
                    Black9.PerformClick();
                    break;
            }
        }

          private void A_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player1 = new WindowsMediaPlayer();
            Player1.URL = "Piano G3.wav";
            Player1.controls.play();
        
        }

        private void S_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player2 = new WindowsMediaPlayer();
            Player2.URL = "Piano A3.wav";
            Player2.controls.play();
        }

        private void D_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player3 = new WindowsMediaPlayer();
            Player3.URL = "Piano B3.wav";
            Player3.controls.play();
        }

        private void F_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player4 = new WindowsMediaPlayer();
            Player4.URL = "Piano C4.wav";
            Player4.controls.play();
        }

        private void G_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player5 = new WindowsMediaPlayer();
            Player5.URL = "Piano D4.wav";
            Player5.controls.play();
        
        }

        private void H_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player6 = new WindowsMediaPlayer();
            Player6.URL = "Piano E4.wav";
            Player6.controls.play();
        }

        private void J_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player7 = new WindowsMediaPlayer();
            Player7.URL = "Piano F4.wav";
            Player7.controls.play();
        }

        private void K_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player8 = new WindowsMediaPlayer();
            Player8.URL = "Piano G4.wav";
            Player8.controls.play();
        }

        private void L_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player9 = new WindowsMediaPlayer();
            Player9.URL = "Piano A4.wav";
            Player9.controls.play();
        
        }

        private void B4_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player10 = new WindowsMediaPlayer();
            Player10.URL = "Piano B4.wav";
            Player10.controls.play();
        }

        private void C5_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player11 = new WindowsMediaPlayer();
            Player11.URL = "Piano C5.wav";
            Player11.controls.play();
        }

        private void D5_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player12 = new WindowsMediaPlayer();
            Player12.URL = "Piano D5.wav";
            Player12.controls.play();
        }

        private void W_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player13 = new WindowsMediaPlayer();
            Player13.URL = "Black1.wav";
            Player13.controls.play();
        }

        private void E_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player14 = new WindowsMediaPlayer();
            Player14.URL = "Black2.wav";
            Player14.controls.play();
        }

        private void R_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player14 = new WindowsMediaPlayer();
            Player14.URL = "Black3.wav";
            Player14.controls.play();
        
        }

        private void T_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player15 = new WindowsMediaPlayer();
            Player15.URL = "Black4.wav";
            Player15.controls.play();
        }

        private void Y_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player16 = new WindowsMediaPlayer();
            Player16.URL = "Black5.wav";
            Player16.controls.play();
        }

        private void I_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player17 = new WindowsMediaPlayer();
            Player17.URL = "Black6.wav";
            Player17.controls.play();
        }

        private void O_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player18 = new WindowsMediaPlayer();
            Player18.URL = "Black7.wav";
            Player18.controls.play();
        
        }

        private void P_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player19 = new WindowsMediaPlayer();
            Player19.URL = "Black8.wav";
            Player19.controls.play();
        
        }

        private void Black9_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer Player20 = new WindowsMediaPlayer();
            Player20.URL = "Black9.wav";
            Player20.controls.play();
        
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

        private void button1_Click(object sender, EventArgs e)
        {
            chords c = new chords();
            c.Show();
            
        }
    }
}
