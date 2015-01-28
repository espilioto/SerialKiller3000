namespace SerialKiller3000
{
    partial class TempControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upperColorBox = new System.Windows.Forms.PictureBox();
            this.lowerColorBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.NumericUpDown();
            this.txtLower = new System.Windows.Forms.NumericUpDown();
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upperColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLower)).BeginInit();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(155, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "upper color";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "lower color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // upperColorBox
            // 
            this.upperColorBox.BackColor = System.Drawing.Color.Red;
            this.upperColorBox.Location = new System.Drawing.Point(155, 196);
            this.upperColorBox.Name = "upperColorBox";
            this.upperColorBox.Size = new System.Drawing.Size(74, 56);
            this.upperColorBox.TabIndex = 68;
            this.upperColorBox.TabStop = false;
            this.upperColorBox.Click += new System.EventHandler(this.upperColorBox_Click);
            // 
            // lowerColorBox
            // 
            this.lowerColorBox.BackColor = System.Drawing.Color.Blue;
            this.lowerColorBox.Location = new System.Drawing.Point(34, 196);
            this.lowerColorBox.Name = "lowerColorBox";
            this.lowerColorBox.Size = new System.Drawing.Size(74, 56);
            this.lowerColorBox.TabIndex = 67;
            this.lowerColorBox.TabStop = false;
            this.lowerColorBox.Click += new System.EventHandler(this.lowerColorBox_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(107, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 29);
            this.label6.TabIndex = 66;
            this.label6.Text = "current value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(109, 103);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(47, 20);
            this.txtValue.TabIndex = 65;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(191, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "upper threshold";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "lower threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(192, 104);
            this.txtUpper.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.txtUpper.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(47, 20);
            this.txtUpper.TabIndex = 62;
            this.txtUpper.Value = new decimal(new int[] {
            78,
            0,
            0,
            0});
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(24, 104);
            this.txtLower.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.txtLower.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.txtLower.Name = "txtLower";
            this.txtLower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLower.Size = new System.Drawing.Size(47, 20);
            this.txtLower.TabIndex = 61;
            this.txtLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLower.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.txtLower.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // deviceBox
            // 
            this.deviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Location = new System.Drawing.Point(21, 24);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(220, 21);
            this.deviceBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Select the led color";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.tempStart);
            // 
            // backgroundTimer
            // 
            this.backgroundTimer.Tick += new System.EventHandler(this.MeasureTemperature);
            // 
            // TempControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upperColorBox);
            this.Controls.Add(this.lowerColorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TempControl";
            this.Size = new System.Drawing.Size(263, 320);
            ((System.ComponentModel.ISupportInitialize)(this.upperColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox upperColorBox;
        private System.Windows.Forms.PictureBox lowerColorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtUpper;
        private System.Windows.Forms.NumericUpDown txtLower;
        private System.Windows.Forms.ComboBox deviceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Timer backgroundTimer;

    }
}
