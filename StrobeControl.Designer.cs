namespace SerialKiller3000
{
    partial class StrobeControl
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
            this.timerStrobe = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.blueupdown = new System.Windows.Forms.NumericUpDown();
            this.greenupdown = new System.Windows.Forms.NumericUpDown();
            this.redupdown = new System.Windows.Forms.NumericUpDown();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStrobe
            // 
            this.timerStrobe.Interval = 500;
            this.timerStrobe.Tick += new System.EventHandler(this.timerStrobe_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Select the led color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select the strobe speed";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(20, 38);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 44;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 45;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 105;
            this.button1.Text = "Color picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // blueupdown
            // 
            this.blueupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.blueupdown.ForeColor = System.Drawing.Color.Blue;
            this.blueupdown.Location = new System.Drawing.Point(198, 181);
            this.blueupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueupdown.Name = "blueupdown";
            this.blueupdown.Size = new System.Drawing.Size(45, 21);
            this.blueupdown.TabIndex = 104;
            this.blueupdown.Click += new System.EventHandler(this.blueupdown_ValueChanged);
            // 
            // greenupdown
            // 
            this.greenupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greenupdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenupdown.Location = new System.Drawing.Point(109, 181);
            this.greenupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenupdown.Name = "greenupdown";
            this.greenupdown.Size = new System.Drawing.Size(45, 21);
            this.greenupdown.TabIndex = 103;
            this.greenupdown.Click += new System.EventHandler(this.greenupdown_ValueChanged);
            // 
            // redupdown
            // 
            this.redupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.redupdown.ForeColor = System.Drawing.Color.Red;
            this.redupdown.Location = new System.Drawing.Point(20, 181);
            this.redupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redupdown.Name = "redupdown";
            this.redupdown.Size = new System.Drawing.Size(45, 21);
            this.redupdown.TabIndex = 102;
            this.redupdown.Click += new System.EventHandler(this.redupdown_ValueChanged);
            // 
            // bluebar
            // 
            this.bluebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bluebar.Location = new System.Drawing.Point(198, 209);
            this.bluebar.Maximum = 255;
            this.bluebar.Name = "bluebar";
            this.bluebar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bluebar.Size = new System.Drawing.Size(45, 86);
            this.bluebar.TabIndex = 98;
            this.bluebar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll);
            // 
            // greenbar
            // 
            this.greenbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.greenbar.Location = new System.Drawing.Point(109, 210);
            this.greenbar.Maximum = 255;
            this.greenbar.Name = "greenbar";
            this.greenbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenbar.Size = new System.Drawing.Size(45, 86);
            this.greenbar.TabIndex = 97;
            this.greenbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll);
            // 
            // redbar
            // 
            this.redbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.redbar.Location = new System.Drawing.Point(20, 208);
            this.redbar.Maximum = 255;
            this.redbar.Name = "redbar";
            this.redbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redbar.Size = new System.Drawing.Size(45, 87);
            this.redbar.TabIndex = 96;
            this.redbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(213, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(123, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(34, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "R";
            // 
            // StrobeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blueupdown);
            this.Controls.Add(this.greenupdown);
            this.Controls.Add(this.redupdown);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StrobeControl";
            this.Size = new System.Drawing.Size(263, 320);
            this.Load += new System.EventHandler(this.StrobeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerStrobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.NumericUpDown blueupdown;
        internal System.Windows.Forms.NumericUpDown greenupdown;
        internal System.Windows.Forms.NumericUpDown redupdown;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;

    }
}
