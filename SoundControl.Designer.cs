namespace SerialKiller3000
{
    partial class SoundControl
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
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.radioGB = new System.Windows.Forms.RadioButton();
            this.radioRB = new System.Windows.Forms.RadioButton();
            this.radioRG = new System.Windows.Forms.RadioButton();
            this.radioWhite = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soundBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSound
            // 
            this.timerSound.Interval = 10;
            this.timerSound.Tick += new System.EventHandler(this.timerSound_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select the device";
            // 
            // deviceBox
            // 
            this.deviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Location = new System.Drawing.Point(21, 24);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(220, 21);
            this.deviceBox.TabIndex = 60;
            this.deviceBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // radioGB
            // 
            this.radioGB.AutoSize = true;
            this.radioGB.Location = new System.Drawing.Point(194, 221);
            this.radioGB.Name = "radioGB";
            this.radioGB.Size = new System.Drawing.Size(52, 17);
            this.radioGB.TabIndex = 72;
            this.radioGB.TabStop = true;
            this.radioGB.Text = "G + B";
            this.radioGB.UseVisualStyleBackColor = true;
            // 
            // radioRB
            // 
            this.radioRB.AutoSize = true;
            this.radioRB.Location = new System.Drawing.Point(103, 221);
            this.radioRB.Name = "radioRB";
            this.radioRB.Size = new System.Drawing.Size(52, 17);
            this.radioRB.TabIndex = 71;
            this.radioRB.TabStop = true;
            this.radioRB.Text = "R + B";
            this.radioRB.UseVisualStyleBackColor = true;
            // 
            // radioRG
            // 
            this.radioRG.AutoSize = true;
            this.radioRG.Location = new System.Drawing.Point(19, 221);
            this.radioRG.Name = "radioRG";
            this.radioRG.Size = new System.Drawing.Size(53, 17);
            this.radioRG.TabIndex = 70;
            this.radioRG.TabStop = true;
            this.radioRG.Text = "R + G";
            this.radioRG.UseVisualStyleBackColor = true;
            // 
            // radioWhite
            // 
            this.radioWhite.AutoSize = true;
            this.radioWhite.Location = new System.Drawing.Point(104, 244);
            this.radioWhite.Name = "radioWhite";
            this.radioWhite.Size = new System.Drawing.Size(53, 17);
            this.radioWhite.TabIndex = 69;
            this.radioWhite.TabStop = true;
            this.radioWhite.Text = "White";
            this.radioWhite.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(194, 198);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 68;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(103, 198);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 67;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(19, 198);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 66;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(222, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "100";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 104);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(204, 45);
            this.trackBar1.TabIndex = 64;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Select the led color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Audio level";
            // 
            // soundBar
            // 
            this.soundBar.Location = new System.Drawing.Point(21, 75);
            this.soundBar.MarqueeAnimationSpeed = 1;
            this.soundBar.Name = "soundBar";
            this.soundBar.Size = new System.Drawing.Size(220, 23);
            this.soundBar.TabIndex = 61;
            // 
            // SoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.radioGB);
            this.Controls.Add(this.radioRB);
            this.Controls.Add(this.radioRG);
            this.Controls.Add(this.radioWhite);
            this.Controls.Add(this.radioBlue);
            this.Controls.Add(this.radioGreen);
            this.Controls.Add(this.radioRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soundBar);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.label1);
            this.Name = "SoundControl";
            this.Size = new System.Drawing.Size(263, 320);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceBox;
        public System.Windows.Forms.RadioButton radioGB;
        public System.Windows.Forms.RadioButton radioRB;
        public System.Windows.Forms.RadioButton radioRG;
        private System.Windows.Forms.RadioButton radioWhite;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radioGreen;
        public System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar soundBar;

    }
}
