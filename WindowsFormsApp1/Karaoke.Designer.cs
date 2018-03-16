namespace WindowsFormsApp1
{
    partial class Karaoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karaoke));
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Back = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(-1, 40);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(661, 456);
            this.WMP1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._60689_left_back_arrow_in_filled_square_button;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(68, 32);
            this.Back.TabIndex = 24;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Green;
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(822, 40);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 25;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click_1);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(822, 86);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 24);
            this.pauseButton.TabIndex = 27;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(822, 134);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 28;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Karaoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 508);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.WMP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(974, 547);
            this.MinimumSize = new System.Drawing.Size(974, 547);
            this.Name = "Karaoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Karaoke";
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;

    }
}