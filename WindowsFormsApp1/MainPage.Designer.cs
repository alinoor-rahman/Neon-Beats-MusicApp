namespace WindowsFormsApp1
{
    partial class NeonBeats
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.CreateAcc = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Instrument = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAcc
            // 
            this.CreateAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateAcc.ForeColor = System.Drawing.Color.LawnGreen;
            this.CreateAcc.Location = new System.Drawing.Point(50, 551);
            this.CreateAcc.Name = "CreateAcc";
            this.CreateAcc.Size = new System.Drawing.Size(90, 29);
            this.CreateAcc.TabIndex = 6;
            this.CreateAcc.Text = "Create Account";
            this.CreateAcc.UseVisualStyleBackColor = false;
            this.CreateAcc.Click += new System.EventHandler(this.CreateAcc_Click);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogIn.ForeColor = System.Drawing.Color.Aqua;
            this.LogIn.Location = new System.Drawing.Point(247, 551);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(95, 29);
            this.LogIn.TabIndex = 7;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.output_YAWKJh1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 619);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label_Instrument
            // 
            this.label_Instrument.AutoSize = true;
            this.label_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Instrument.Location = new System.Drawing.Point(45, 112);
            this.label_Instrument.Name = "label_Instrument";
            this.label_Instrument.Size = new System.Drawing.Size(315, 108);
            this.label_Instrument.TabIndex = 10;
            this.label_Instrument.Text = "          ";
            this.label_Instrument.Click += new System.EventHandler(this.label_Instrument_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 108);
            this.label1.TabIndex = 13;
            this.label1.Text = "          ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 108);
            this.label2.TabIndex = 14;
            this.label2.Text = "          ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NeonBeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Instrument);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.CreateAcc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NeonBeats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeonBeats";
            this.Load += new System.EventHandler(this.NeonBeats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button CreateAcc;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Instrument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

