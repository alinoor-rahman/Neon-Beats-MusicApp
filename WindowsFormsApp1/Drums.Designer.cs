namespace WindowsFormsApp1
{
    partial class Drums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drums));
            this.Hats = new System.Windows.Forms.Button();
            this.Snare = new System.Windows.Forms.Button();
            this.Tom1 = new System.Windows.Forms.Button();
            this.Tom2 = new System.Windows.Forms.Button();
            this.Bass = new System.Windows.Forms.Button();
            this.FloorTom = new System.Windows.Forms.Button();
            this.Crash = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hats
            // 
            this.Hats.Location = new System.Drawing.Point(80, 149);
            this.Hats.Name = "Hats";
            this.Hats.Size = new System.Drawing.Size(67, 23);
            this.Hats.TabIndex = 1;
            this.Hats.Text = "Hats (0)";
            this.Hats.UseVisualStyleBackColor = true;
            this.Hats.Click += new System.EventHandler(this.Hats_Click);
            // 
            // Snare
            // 
            this.Snare.Location = new System.Drawing.Point(192, 182);
            this.Snare.Name = "Snare";
            this.Snare.Size = new System.Drawing.Size(63, 23);
            this.Snare.TabIndex = 2;
            this.Snare.Text = "Snare(2)";
            this.Snare.UseVisualStyleBackColor = true;
            this.Snare.Click += new System.EventHandler(this.Snare_Click);
            // 
            // Tom1
            // 
            this.Tom1.Location = new System.Drawing.Point(232, 91);
            this.Tom1.Name = "Tom1";
            this.Tom1.Size = new System.Drawing.Size(66, 23);
            this.Tom1.TabIndex = 3;
            this.Tom1.Text = "Tom 1 (4)";
            this.Tom1.UseVisualStyleBackColor = true;
            this.Tom1.Click += new System.EventHandler(this.Tom1_Click);
            // 
            // Tom2
            // 
            this.Tom2.Location = new System.Drawing.Point(399, 91);
            this.Tom2.Name = "Tom2";
            this.Tom2.Size = new System.Drawing.Size(77, 23);
            this.Tom2.TabIndex = 4;
            this.Tom2.Text = "Tom 2 (5)";
            this.Tom2.UseVisualStyleBackColor = true;
            this.Tom2.Click += new System.EventHandler(this.Tom2_Click);
            // 
            // Bass
            // 
            this.Bass.Location = new System.Drawing.Point(317, 265);
            this.Bass.Name = "Bass";
            this.Bass.Size = new System.Drawing.Size(62, 23);
            this.Bass.TabIndex = 6;
            this.Bass.Text = "Bass (1)";
            this.Bass.UseVisualStyleBackColor = true;
            this.Bass.Click += new System.EventHandler(this.Bass_Click);
            // 
            // FloorTom
            // 
            this.FloorTom.Location = new System.Drawing.Point(479, 182);
            this.FloorTom.Name = "FloorTom";
            this.FloorTom.Size = new System.Drawing.Size(86, 23);
            this.FloorTom.TabIndex = 7;
            this.FloorTom.Text = "Floor Tom(3)";
            this.FloorTom.UseVisualStyleBackColor = true;
            this.FloorTom.Click += new System.EventHandler(this.FloorTom_Click);
            // 
            // Crash
            // 
            this.Crash.Location = new System.Drawing.Point(516, 27);
            this.Crash.Name = "Crash";
            this.Crash.Size = new System.Drawing.Size(73, 23);
            this.Crash.TabIndex = 8;
            this.Crash.Text = "Crash (6)";
            this.Crash.UseVisualStyleBackColor = true;
            this.Crash.Click += new System.EventHandler(this.Crash_Click);
            this.Crash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Crash_KeyDown);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._60689_left_back_arrow_in_filled_square_button;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 32);
            this.Back.TabIndex = 23;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Green;
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(112, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 24;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(206, 11);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(74, 24);
            this.pauseButton.TabIndex = 25;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(12, 376);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(217, 80);
            this.WMP1.TabIndex = 28;
            this.WMP1.Visible = false;
            // 
            // Drums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.DK7500_DF_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 495);
            this.Controls.Add(this.WMP1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Crash);
            this.Controls.Add(this.FloorTom);
            this.Controls.Add(this.Bass);
            this.Controls.Add(this.Tom2);
            this.Controls.Add(this.Tom1);
            this.Controls.Add(this.Snare);
            this.Controls.Add(this.Hats);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(670, 534);
            this.MinimumSize = new System.Drawing.Size(670, 534);
            this.Name = "Drums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drums";
            this.Load += new System.EventHandler(this.Drums_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drums_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Hats;
        private System.Windows.Forms.Button Snare;
        private System.Windows.Forms.Button Tom1;
        private System.Windows.Forms.Button Tom2;
        private System.Windows.Forms.Button Bass;
        private System.Windows.Forms.Button FloorTom;
        private System.Windows.Forms.Button Crash;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button pauseButton;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
    }
}