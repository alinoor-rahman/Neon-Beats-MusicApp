namespace WindowsFormsApp1
{
    partial class Piano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piano));
            this.A = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.Black9 = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.C5 = new System.Windows.Forms.Button();
            this.D5 = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(28, 263);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(29, 23);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(82, 263);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(28, 23);
            this.S.TabIndex = 1;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(135, 263);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(28, 23);
            this.D.TabIndex = 2;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(488, 263);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(28, 23);
            this.B4.TabIndex = 3;
            this.B4.Text = ";";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(443, 263);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(28, 23);
            this.L.TabIndex = 5;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(386, 263);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(28, 23);
            this.K.TabIndex = 6;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // J
            // 
            this.J.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.J.ForeColor = System.Drawing.SystemColors.ControlText;
            this.J.Location = new System.Drawing.Point(333, 263);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(28, 23);
            this.J.TabIndex = 7;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            this.J.Click += new System.EventHandler(this.J_Click);
            // 
            // H
            // 
            this.H.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.H.Location = new System.Drawing.Point(284, 263);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(28, 23);
            this.H.TabIndex = 8;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // G
            // 
            this.G.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G.Location = new System.Drawing.Point(236, 263);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(28, 23);
            this.G.TabIndex = 9;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(183, 263);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(28, 23);
            this.F.TabIndex = 10;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // W
            // 
            this.W.Location = new System.Drawing.Point(3, 156);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(28, 23);
            this.W.TabIndex = 11;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // Black9
            // 
            this.Black9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Black9.Location = new System.Drawing.Point(568, 155);
            this.Black9.Name = "Black9";
            this.Black9.Size = new System.Drawing.Size(28, 23);
            this.Black9.TabIndex = 12;
            this.Black9.Text = "[";
            this.Black9.UseVisualStyleBackColor = true;
            this.Black9.Click += new System.EventHandler(this.Black9_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(466, 156);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(28, 23);
            this.P.TabIndex = 13;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // O
            // 
            this.O.Location = new System.Drawing.Point(415, 156);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(28, 23);
            this.O.TabIndex = 14;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(359, 156);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(28, 23);
            this.I.TabIndex = 15;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(110, 156);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(28, 23);
            this.R.TabIndex = 16;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(54, 156);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(28, 23);
            this.E.TabIndex = 17;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // C5
            // 
            this.C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C5.Location = new System.Drawing.Point(537, 263);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(28, 23);
            this.C5.TabIndex = 18;
            this.C5.Text = "\'";
            this.C5.UseVisualStyleBackColor = true;
            this.C5.Click += new System.EventHandler(this.C5_Click);
            // 
            // D5
            // 
            this.D5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D5.Location = new System.Drawing.Point(594, 263);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(28, 23);
            this.D5.TabIndex = 19;
            this.D5.Text = "]";
            this.D5.UseVisualStyleBackColor = true;
            this.D5.Click += new System.EventHandler(this.D5_Click);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(211, 156);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(28, 23);
            this.T.TabIndex = 20;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(263, 156);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(28, 23);
            this.Y.TabIndex = 21;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._60689_left_back_arrow_in_filled_square_button;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(3, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 32);
            this.Back.TabIndex = 22;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Green;
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(121, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 29;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(226, 11);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(74, 24);
            this.pauseButton.TabIndex = 30;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(537, 11);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(76, 80);
            this.WMP1.TabIndex = 31;
            this.WMP1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Chords";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Piano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.piano2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WMP1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.T);
            this.Controls.Add(this.D5);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.E);
            this.Controls.Add(this.R);
            this.Controls.Add(this.I);
            this.Controls.Add(this.O);
            this.Controls.Add(this.P);
            this.Controls.Add(this.Black9);
            this.Controls.Add(this.W);
            this.Controls.Add(this.F);
            this.Controls.Add(this.G);
            this.Controls.Add(this.H);
            this.Controls.Add(this.J);
            this.Controls.Add(this.K);
            this.Controls.Add(this.L);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Piano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Piano_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Piano_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button Black9;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button C5;
        private System.Windows.Forms.Button D5;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button pauseButton;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}