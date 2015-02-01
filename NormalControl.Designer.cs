namespace SerialKiller3000
{
    partial class NormalControl
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
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.blueupdown = new System.Windows.Forms.NumericUpDown();
            this.greenupdown = new System.Windows.Forms.NumericUpDown();
            this.redupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blueupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 288);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 50;
            this.btnStop.Text = "Off";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "Color picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // blueupdown
            // 
            this.blueupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.blueupdown.ForeColor = System.Drawing.Color.Blue;
            this.blueupdown.Location = new System.Drawing.Point(198, 94);
            this.blueupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueupdown.Name = "blueupdown";
            this.blueupdown.Size = new System.Drawing.Size(45, 21);
            this.blueupdown.TabIndex = 94;
            this.blueupdown.ValueChanged += new System.EventHandler(this.blueupdown_ValueChanged);
            // 
            // greenupdown
            // 
            this.greenupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greenupdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenupdown.Location = new System.Drawing.Point(109, 94);
            this.greenupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenupdown.Name = "greenupdown";
            this.greenupdown.Size = new System.Drawing.Size(45, 21);
            this.greenupdown.TabIndex = 93;
            this.greenupdown.ValueChanged += new System.EventHandler(this.greenupdown_ValueChanged);
            // 
            // redupdown
            // 
            this.redupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.redupdown.ForeColor = System.Drawing.Color.Red;
            this.redupdown.Location = new System.Drawing.Point(21, 93);
            this.redupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redupdown.Name = "redupdown";
            this.redupdown.Size = new System.Drawing.Size(45, 21);
            this.redupdown.TabIndex = 92;
            this.redupdown.ValueChanged += new System.EventHandler(this.redupdown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(213, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(123, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "R";
            // 
            // bluebar
            // 
            this.bluebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bluebar.Location = new System.Drawing.Point(198, 122);
            this.bluebar.Maximum = 255;
            this.bluebar.Name = "bluebar";
            this.bluebar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bluebar.Size = new System.Drawing.Size(45, 158);
            this.bluebar.TabIndex = 88;
            this.bluebar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.bluebar.ValueChanged += new System.EventHandler(this.bluebar_Scroll);
            // 
            // greenbar
            // 
            this.greenbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.greenbar.Location = new System.Drawing.Point(109, 123);
            this.greenbar.Maximum = 255;
            this.greenbar.Name = "greenbar";
            this.greenbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenbar.Size = new System.Drawing.Size(45, 158);
            this.greenbar.TabIndex = 87;
            this.greenbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.greenbar.ValueChanged += new System.EventHandler(this.greenbar_Scroll);
            // 
            // redbar
            // 
            this.redbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.redbar.Location = new System.Drawing.Point(20, 121);
            this.redbar.Maximum = 255;
            this.redbar.Name = "redbar";
            this.redbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redbar.Size = new System.Drawing.Size(45, 159);
            this.redbar.TabIndex = 86;
            this.redbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.redbar.ValueChanged += new System.EventHandler(this.redbar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Select the led color";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Saves the current color.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NormalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blueupdown);
            this.Controls.Add(this.greenupdown);
            this.Controls.Add(this.redupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.btnStop);
            this.Name = "NormalControl";
            this.Size = new System.Drawing.Size(263, 320);
            this.Load += new System.EventHandler(this.NormalControl_Load);
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

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.NumericUpDown blueupdown;
        internal System.Windows.Forms.NumericUpDown greenupdown;
        internal System.Windows.Forms.NumericUpDown redupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
