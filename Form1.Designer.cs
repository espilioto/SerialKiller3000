namespace SerialKiller3000
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openport = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.btnNormal = new System.Windows.Forms.CheckBox();
            this.btnRainbow = new System.Windows.Forms.CheckBox();
            this.btnBreathing = new System.Windows.Forms.CheckBox();
            this.btnSound = new System.Windows.Forms.CheckBox();
            this.btnStrobe = new System.Windows.Forms.CheckBox();
            this.btnTemp = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnDualBreathing = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDualBreathingPrefs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTempPrefs = new System.Windows.Forms.Button();
            this.btnStrobePrefs = new System.Windows.Forms.Button();
            this.btnSoundPrefs = new System.Windows.Forms.Button();
            this.btnBreathingPrefs = new System.Windows.Forms.Button();
            this.btnRainbowPrefs = new System.Windows.Forms.Button();
            this.btnNormalPrefs = new System.Windows.Forms.Button();
            this.normalControl1 = new SerialKiller3000.NormalControl();
            this.breathingControl1 = new SerialKiller3000.BreathingControl();
            this.tempControl1 = new SerialKiller3000.TempControl();
            this.strobeControl1 = new SerialKiller3000.StrobeControl();
            this.soundControl1 = new SerialKiller3000.SoundControl();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openport
            // 
            resources.ApplyResources(this.openport, "openport");
            this.openport.Name = "openport";
            this.openport.UseVisualStyleBackColor = true;
            this.openport.CheckedChanged += new System.EventHandler(this.openport_CheckedChanged);
            // 
            // portBox
            // 
            resources.ApplyResources(this.portBox, "portBox");
            this.portBox.FormattingEnabled = true;
            this.portBox.Name = "portBox";
            // 
            // baudBox
            // 
            resources.ApplyResources(this.baudBox, "baudBox");
            this.baudBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.baudBox.Name = "baudBox";
            this.baudBox.Value = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            // 
            // btnNormal
            // 
            resources.ApplyResources(this.btnNormal, "btnNormal");
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.CheckedChanged += new System.EventHandler(this.btnNormal_CheckedChanged);
            // 
            // btnRainbow
            // 
            resources.ApplyResources(this.btnRainbow, "btnRainbow");
            this.btnRainbow.Name = "btnRainbow";
            this.btnRainbow.UseVisualStyleBackColor = true;
            this.btnRainbow.CheckedChanged += new System.EventHandler(this.btnRainbow_CheckedChanged);
            // 
            // btnBreathing
            // 
            resources.ApplyResources(this.btnBreathing, "btnBreathing");
            this.btnBreathing.Name = "btnBreathing";
            this.btnBreathing.UseVisualStyleBackColor = true;
            this.btnBreathing.CheckedChanged += new System.EventHandler(this.btnBreathing_CheckedChanged);
            // 
            // btnSound
            // 
            resources.ApplyResources(this.btnSound, "btnSound");
            this.btnSound.Name = "btnSound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.CheckedChanged += new System.EventHandler(this.btnSound_CheckedChanged);
            // 
            // btnStrobe
            // 
            resources.ApplyResources(this.btnStrobe, "btnStrobe");
            this.btnStrobe.Name = "btnStrobe";
            this.btnStrobe.UseVisualStyleBackColor = true;
            this.btnStrobe.CheckedChanged += new System.EventHandler(this.btnStrobe_CheckedChanged);
            // 
            // btnTemp
            // 
            resources.ApplyResources(this.btnTemp, "btnTemp");
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.CheckedChanged += new System.EventHandler(this.btnTemp_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnDualBreathing
            // 
            resources.ApplyResources(this.btnDualBreathing, "btnDualBreathing");
            this.btnDualBreathing.Name = "btnDualBreathing";
            this.btnDualBreathing.UseVisualStyleBackColor = true;
            this.btnDualBreathing.CheckedChanged += new System.EventHandler(this.btnDualBreathing_CheckedChanged);
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // taskbarIcon
            // 
            resources.ApplyResources(this.taskbarIcon, "taskbarIcon");
            this.taskbarIcon.DoubleClick += new System.EventHandler(this.open_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonMinimize
            // 
            resources.ApplyResources(this.buttonMinimize, "buttonMinimize");
            this.buttonMinimize.BackgroundImage = global::SerialKiller3000.Properties.Resources._;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonMinimize_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.buttonMinimize_MouseLeave);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.BackgroundImage = global::SerialKiller3000.Properties.Resources.x;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // btnPreferences
            // 
            resources.ApplyResources(this.btnPreferences, "btnPreferences");
            this.btnPreferences.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDualBreathingPrefs
            // 
            resources.ApplyResources(this.btnDualBreathingPrefs, "btnDualBreathingPrefs");
            this.btnDualBreathingPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnDualBreathingPrefs.Name = "btnDualBreathingPrefs";
            this.btnDualBreathingPrefs.UseVisualStyleBackColor = true;
            this.btnDualBreathingPrefs.Click += new System.EventHandler(this.btnDualBreathingPrefs_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTempPrefs
            // 
            resources.ApplyResources(this.btnTempPrefs, "btnTempPrefs");
            this.btnTempPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnTempPrefs.Name = "btnTempPrefs";
            this.btnTempPrefs.UseVisualStyleBackColor = true;
            this.btnTempPrefs.Click += new System.EventHandler(this.btnTempPrefs_Click);
            // 
            // btnStrobePrefs
            // 
            resources.ApplyResources(this.btnStrobePrefs, "btnStrobePrefs");
            this.btnStrobePrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnStrobePrefs.Name = "btnStrobePrefs";
            this.btnStrobePrefs.UseVisualStyleBackColor = true;
            this.btnStrobePrefs.Click += new System.EventHandler(this.btnStrobePrefs_Click);
            // 
            // btnSoundPrefs
            // 
            resources.ApplyResources(this.btnSoundPrefs, "btnSoundPrefs");
            this.btnSoundPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnSoundPrefs.Name = "btnSoundPrefs";
            this.btnSoundPrefs.UseVisualStyleBackColor = true;
            this.btnSoundPrefs.Click += new System.EventHandler(this.btnSoundPrefs_Click);
            // 
            // btnBreathingPrefs
            // 
            resources.ApplyResources(this.btnBreathingPrefs, "btnBreathingPrefs");
            this.btnBreathingPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnBreathingPrefs.Name = "btnBreathingPrefs";
            this.btnBreathingPrefs.UseVisualStyleBackColor = true;
            this.btnBreathingPrefs.Click += new System.EventHandler(this.btnBreathingPrefs_Click);
            // 
            // btnRainbowPrefs
            // 
            resources.ApplyResources(this.btnRainbowPrefs, "btnRainbowPrefs");
            this.btnRainbowPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnRainbowPrefs.Name = "btnRainbowPrefs";
            this.btnRainbowPrefs.UseVisualStyleBackColor = true;
            this.btnRainbowPrefs.Click += new System.EventHandler(this.btnRainbowPrefs_Click);
            // 
            // btnNormalPrefs
            // 
            resources.ApplyResources(this.btnNormalPrefs, "btnNormalPrefs");
            this.btnNormalPrefs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNormalPrefs.Image = global::SerialKiller3000.Properties.Resources.gear;
            this.btnNormalPrefs.Name = "btnNormalPrefs";
            this.btnNormalPrefs.UseVisualStyleBackColor = true;
            this.btnNormalPrefs.Click += new System.EventHandler(this.btnNormalPrefs_Click);
            // 
            // normalControl1
            // 
            this.normalControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.normalControl1, "normalControl1");
            this.normalControl1.Name = "normalControl1";
            // 
            // breathingControl1
            // 
            this.breathingControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.breathingControl1, "breathingControl1");
            this.breathingControl1.Name = "breathingControl1";
            // 
            // tempControl1
            // 
            this.tempControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.tempControl1, "tempControl1");
            this.tempControl1.Name = "tempControl1";
            // 
            // strobeControl1
            // 
            this.strobeControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.strobeControl1, "strobeControl1");
            this.strobeControl1.Name = "strobeControl1";
            // 
            // soundControl1
            // 
            this.soundControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.soundControl1, "soundControl1");
            this.soundControl1.Name = "soundControl1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.btnDualBreathingPrefs);
            this.Controls.Add(this.btnDualBreathing);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnTempPrefs);
            this.Controls.Add(this.btnStrobePrefs);
            this.Controls.Add(this.btnSoundPrefs);
            this.Controls.Add(this.btnBreathingPrefs);
            this.Controls.Add(this.btnRainbowPrefs);
            this.Controls.Add(this.btnNormalPrefs);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnStrobe);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnBreathing);
            this.Controls.Add(this.btnRainbow);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.openport);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.baudBox);
            this.Controls.Add(this.normalControl1);
            this.Controls.Add(this.breathingControl1);
            this.Controls.Add(this.tempControl1);
            this.Controls.Add(this.strobeControl1);
            this.Controls.Add(this.soundControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox openport;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.CheckBox btnNormal;
        private System.Windows.Forms.CheckBox btnRainbow;
        private System.Windows.Forms.CheckBox btnBreathing;
        private System.Windows.Forms.CheckBox btnSound;
        private System.Windows.Forms.CheckBox btnStrobe;
        private System.Windows.Forms.CheckBox btnTemp;
        private System.Windows.Forms.Button btnNormalPrefs;
        private System.Windows.Forms.Button btnRainbowPrefs;
        private System.Windows.Forms.Button btnBreathingPrefs;
        private System.Windows.Forms.Button btnSoundPrefs;
        private System.Windows.Forms.Button btnStrobePrefs;
        private System.Windows.Forms.Button btnTempPrefs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnDualBreathingPrefs;
        private System.Windows.Forms.CheckBox btnDualBreathing;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private BreathingControl breathingControl1;
        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private NormalControl normalControl1;
        private StrobeControl strobeControl1;
        private TempControl tempControl1;
        private SoundControl soundControl1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}


