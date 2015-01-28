namespace SerialKiller3000
{
    partial class BreathingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.breathGB = new System.Windows.Forms.RadioButton();
            this.breathRB = new System.Windows.Forms.RadioButton();
            this.breathRG = new System.Windows.Forms.RadioButton();
            this.breathWhite = new System.Windows.Forms.RadioButton();
            this.breathBlue = new System.Windows.Forms.RadioButton();
            this.breathGreen = new System.Windows.Forms.RadioButton();
            this.breathRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // breathGB
            // 
            this.breathGB.AutoSize = true;
            this.breathGB.Location = new System.Drawing.Point(194, 221);
            this.breathGB.Name = "breathGB";
            this.breathGB.Size = new System.Drawing.Size(52, 17);
            this.breathGB.TabIndex = 49;
            this.breathGB.TabStop = true;
            this.breathGB.Text = "G + B";
            this.breathGB.UseVisualStyleBackColor = true;
            // 
            // breathRB
            // 
            this.breathRB.AutoSize = true;
            this.breathRB.Location = new System.Drawing.Point(103, 221);
            this.breathRB.Name = "breathRB";
            this.breathRB.Size = new System.Drawing.Size(52, 17);
            this.breathRB.TabIndex = 48;
            this.breathRB.TabStop = true;
            this.breathRB.Text = "R + B";
            this.breathRB.UseVisualStyleBackColor = true;
            // 
            // breathRG
            // 
            this.breathRG.AutoSize = true;
            this.breathRG.Location = new System.Drawing.Point(19, 221);
            this.breathRG.Name = "breathRG";
            this.breathRG.Size = new System.Drawing.Size(53, 17);
            this.breathRG.TabIndex = 47;
            this.breathRG.TabStop = true;
            this.breathRG.Text = "R + G";
            this.breathRG.UseVisualStyleBackColor = true;
            // 
            // breathWhite
            // 
            this.breathWhite.AutoSize = true;
            this.breathWhite.Location = new System.Drawing.Point(103, 253);
            this.breathWhite.Name = "breathWhite";
            this.breathWhite.Size = new System.Drawing.Size(53, 17);
            this.breathWhite.TabIndex = 46;
            this.breathWhite.TabStop = true;
            this.breathWhite.Text = "White";
            this.breathWhite.UseVisualStyleBackColor = true;
            // 
            // breathBlue
            // 
            this.breathBlue.AutoSize = true;
            this.breathBlue.Location = new System.Drawing.Point(194, 198);
            this.breathBlue.Name = "breathBlue";
            this.breathBlue.Size = new System.Drawing.Size(46, 17);
            this.breathBlue.TabIndex = 45;
            this.breathBlue.TabStop = true;
            this.breathBlue.Text = "Blue";
            this.breathBlue.UseVisualStyleBackColor = true;
            // 
            // breathGreen
            // 
            this.breathGreen.AutoSize = true;
            this.breathGreen.Location = new System.Drawing.Point(103, 198);
            this.breathGreen.Name = "breathGreen";
            this.breathGreen.Size = new System.Drawing.Size(54, 17);
            this.breathGreen.TabIndex = 44;
            this.breathGreen.TabStop = true;
            this.breathGreen.Text = "Green";
            this.breathGreen.UseVisualStyleBackColor = true;
            // 
            // breathRed
            // 
            this.breathRed.AutoSize = true;
            this.breathRed.Location = new System.Drawing.Point(19, 198);
            this.breathRed.Name = "breathRed";
            this.breathRed.Size = new System.Drawing.Size(45, 17);
            this.breathRed.TabIndex = 43;
            this.breathRed.TabStop = true;
            this.breathRed.Text = "Red";
            this.breathRed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select the led color";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Normal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(20, 38);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 53;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 3;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Select the breathing speed";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.BreathingStart);
            // 
            // BreathingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.breathGB);
            this.Controls.Add(this.breathRB);
            this.Controls.Add(this.breathRG);
            this.Controls.Add(this.breathWhite);
            this.Controls.Add(this.breathBlue);
            this.Controls.Add(this.breathGreen);
            this.Controls.Add(this.breathRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Name = "BreathingControl";
            this.Size = new System.Drawing.Size(263, 320);
            this.Load += new System.EventHandler(this.BreathingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton breathGB;
        public System.Windows.Forms.RadioButton breathRB;
        public System.Windows.Forms.RadioButton breathRG;
        private System.Windows.Forms.RadioButton breathWhite;
        private System.Windows.Forms.RadioButton breathBlue;
        private System.Windows.Forms.RadioButton breathGreen;
        public System.Windows.Forms.RadioButton breathRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;


    }
}
