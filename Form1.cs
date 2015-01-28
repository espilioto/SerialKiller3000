using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Input;

namespace SerialKiller3000
{
    public partial class Form1 : Form
    {
        public static Form1 form1 = new Form1();
        PreferencesWindow preferencesWindow = new PreferencesWindow();

        public static bool connected = false;
        bool preferencesOpen = false;
        string pong;

        //borderless form move stuff
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tempControl1.TempControl_Load(null, null);
            soundControl1.SoundControl_Load(null, null);  //preload forms for devices and interfaces to become available

            EnableForms(false);
            initMinimizeToTrayStuff();

            baudBox.Text = "19200";

            stuff.Serial.GetPorts();
            foreach (var port in stuff.Serial.portlist)
            {
                portBox.Items.Add(port);
            }

            portBox.SelectedIndex = 0;

            if (Properties.Settings.Default.Preferences_startMinimized) //start minimized or not
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }

        }
        private void openport_CheckedChanged(object sender, EventArgs e)
        {

            if (openport.Checked)
            {
                portBox.Enabled = false;
                baudBox.Enabled = false;
                openport.Text = "Close Port";

                try
                {
                    stuff.Serial.uart.PortName = portBox.Text;              //open port and send "ping"
                    stuff.Serial.uart.BaudRate = int.Parse(baudBox.Text);
                    stuff.Serial.uart.Open();
                    stuff.Serial.uart.Write("ping;");
                    pong = stuff.Serial.uart.ReadTo("!");

                    if (pong == "\n\r>pong")                                //if the SK3k responds, great!
                    {
                        MessageBox.Show("Connected to the Serial KILLER 3000!");
                        EnableForms(true);
                        stuff.Serial.RgbledOFF();
                        connected = true;
                    }
                    else                                                    //if not, change button text to retry 
                    {
                        openport.Checked = false;
                        openport.Text = "Retry";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + '\n' + "Is the Serial KILLER 3000 connected in port " + stuff.Serial.uart.PortName + "?");
                    Application.Exit();
                }
            }
            else
            {
                stuff.Serial.uart.Close();
                EnableForms(false);
                portBox.Enabled = true;
                baudBox.Enabled = true;
                openport.Text = "Connect";
                connected = false;
            }
        }

        public void EnableForms(bool b)
        {
            btnNormal.Enabled = b;
            btnNormalPrefs.Enabled = b;
            btnRainbow.Enabled = b;
            //btnRainbowPrefs.Enabled = b;
            btnBreathing.Enabled = b;
            btnBreathingPrefs.Enabled = b;
            btnDualBreathing.Enabled = b;
            btnDualBreathingPrefs.Enabled = b;
            btnSound.Enabled = b;
            btnSoundPrefs.Enabled = b;
            btnStrobe.Enabled = b;
            btnStrobePrefs.Enabled = b;
            btnTemp.Enabled = b;
            btnTempPrefs.Enabled = b;
        }
        public void EnableCustomControls(bool b)
        {
            normalControl1.Enabled = b;
            breathingControl1.Enabled = b;
            strobeControl1.Enabled = b;
            soundControl1.Enabled = b;
            tempControl1.Enabled = b;
        }
        public void CustomControlsAreVisible(bool b)
        {
            normalControl1.Visible = b;
            breathingControl1.Visible = b;
            strobeControl1.Visible = b;
            soundControl1.Visible = b;
            tempControl1.Visible = b;
        }

        #region Mode buttons

        private void btnNormal_CheckedChanged(object sender, EventArgs e)       //normal
        {

        }
        private void btnNormalPrefs_Click(object sender, EventArgs e)           //normal prefs
        {
            SlidePanel(normalControl1);
        }

        private void btnRainbow_CheckedChanged(object sender, EventArgs e)      //rainbow
        {
            int r = 255, g = 0, b = 0;

            if (btnRainbow.Checked)
            {
                stuff.Mode = (int)stuff.ModeStatus.RainbowActive;

                EnableForms(false);
                EnableCustomControls(false);
                btnRainbow.Enabled = true;
                btnRainbowPrefs.Enabled = true;

                stuff.Serial.uart.Write("rgb " + 255 + "," + 0 + "," + 0 + ";");                 //r max 

                while (btnRainbow.Enabled)
                {
                    for (g = 0; g < 255 && btnRainbow.Enabled; g++)                       //g to max
                    {
                        stuff.Serial.uart.Write("rgb " + r + "," + stuff.Gamma.correction[g] + "," + b + ";");
                        Application.DoEvents();
                    }
                    for (r = 255; r >= 1 && btnRainbow.Enabled; r--)                       //r to 0
                    {
                        stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + g + "," + b + ";");
                        Application.DoEvents();
                    }
                    for (b = 0; b < 255 && btnRainbow.Enabled; b++)                       //b to max
                    {
                        stuff.Serial.uart.Write("rgb " + r + "," + g + "," + stuff.Gamma.correction[b] + ";");
                        Application.DoEvents();
                    }
                    for (g = 255; g >= 1 && btnRainbow.Enabled; g--)                       //g to 0
                    {
                        stuff.Serial.uart.Write("rgb " + r + "," + stuff.Gamma.correction[g] + "," + b + ";");
                        Application.DoEvents();
                    }
                    for (r = 0; r < 255 && btnRainbow.Enabled; r++)                       //r to max
                    {
                        stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + g + "," + b + ";");
                        Application.DoEvents();
                    }
                    for (b = 255; b >= 1 && btnRainbow.Enabled; b--)                       //b to 0
                    {
                        stuff.Serial.uart.Write("rgb " + r + "," + g + "," + stuff.Gamma.correction[b] + ";");
                        Application.DoEvents();
                    }
                }
            }
            else
            {
                stuff.Serial.RgbledOFF();
                stuff.Mode = (int)stuff.ModeStatus.off;

                EnableForms(true);
                EnableCustomControls(true);
            }

        }
        private void btnRainbowPrefs_Click(object sender, EventArgs e)          //rainbow prefs
        {

        }

        private void btnBreathing_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBreathing.Checked)
            {
                stuff.Mode = (int)stuff.ModeStatus.breathingModeActive;

                EnableForms(false);
                EnableCustomControls(false);
                btnBreathing.Enabled = true;
                btnBreathingPrefs.Enabled = true;
                breathingControl1.Enabled = true;
                breathingControl1.BreathingStart(this, null);
            }
            else
            {
                breathingControl1.BreathingStop();
                stuff.Mode = (int)stuff.ModeStatus.off;

                EnableForms(true);
                EnableCustomControls(true);
            }
        }   //breathing
        private void btnBreathingPrefs_Click(object sender, EventArgs e)         //breathing prefs
        {
            SlidePanel(breathingControl1);
        }

        private void btnDualBreathing_CheckedChanged(object sender, EventArgs e)    //dual breathing
        {

        }
        private void btnDualBreathingPrefs_Click(object sender, EventArgs e)        //dual breathing prefs
        {
            
        }

        private void btnSound_CheckedChanged(object sender, EventArgs e)            //sound
        {
            if (btnSound.Checked)
            {
                stuff.Mode = (int)stuff.ModeStatus.SoundModeActive;

                EnableForms(false);
                EnableCustomControls(false);
                btnSound.Enabled = true;
                btnSoundPrefs.Enabled = true;
                soundControl1.Enabled = true;
                soundControl1.soundModeStart(null, null);
            }
            else
            {
                soundControl1.soundModeStop(null, null);
                stuff.Mode = (int)stuff.ModeStatus.off;

                EnableForms(true);
                EnableCustomControls(true);
            }
        }
        private void btnSoundPrefs_Click(object sender, EventArgs e)                //sound prefs
        {
            SlidePanel(soundControl1);
        }

        private void btnStrobe_CheckedChanged(object sender, EventArgs e)            //strobe
        {

            if (btnStrobe.Checked)
            {
                stuff.Mode = (int)stuff.ModeStatus.strobeModeActive;

                EnableForms(false);
                EnableCustomControls(false);
                btnStrobe.Enabled = true;
                btnStrobePrefs.Enabled = true;
                strobeControl1.Enabled = true;
                strobeControl1.strobeModeStart(null, null);
            }
            else
            {
                strobeControl1.strobeModeStop(null, null);
                stuff.Mode = (int)stuff.ModeStatus.off;

                EnableForms(true);
                EnableCustomControls(true);
            }

        }
        private void btnStrobePrefs_Click(object sender, EventArgs e)               //strobe prefs
        {
            SlidePanel(strobeControl1);
        }

        private void btnTemp_CheckedChanged(object sender, EventArgs e)             //temp
        {
            if (btnTemp.Checked)
            {
                stuff.Mode = (int)stuff.ModeStatus.TempModeActive;

                EnableForms(false);
                EnableCustomControls(false);

                btnTemp.Enabled = true;
                btnTempPrefs.Enabled = true;
                tempControl1.Enabled = true;


                tempControl1.TempModeInit();
            }
            else
            {
                tempControl1.TempModeStop();
                stuff.Mode = (int)stuff.ModeStatus.off;

                EnableForms(true);
                EnableCustomControls(true);
            }
        }
        private void btnTempPrefs_Click(object sender, EventArgs e)                 //temp prefs
        {
            SlidePanel(tempControl1);
        }

        #endregion

        #region minimize to tray

        void initMinimizeToTrayStuff()
        {
            MenuItem open = new MenuItem("Open");
            MenuItem Leds = new MenuItem("Leds");
            MenuItem exit = new MenuItem("Exit");
            ContextMenu cm = new ContextMenu();

            Leds.MenuItems.Add(new MenuItem("On"));
            Leds.MenuItems.Add(new MenuItem("Off"));

            cm.MenuItems.Add(open);
            cm.MenuItems.Add(Leds);
            cm.MenuItems.Add(exit);

            open.Click += new System.EventHandler(this.open_Click);
            Leds.Click += new System.EventHandler(this.LedsOn_Click);
            Leds.Click += new System.EventHandler(this.LedsOff_Click);
            exit.Click += new System.EventHandler(this.exit_Click);

            taskbarIcon.Visible = false;
            taskbarIcon.ContextMenu = cm;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                taskbarIcon.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                taskbarIcon.Visible = false;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LedsOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("derp");
        }
        private void LedsOff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("derp");
        }

        #endregion

        #region X button

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = SerialKiller3000.Properties.Resources.xMouse;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = SerialKiller3000.Properties.Resources.x;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Minimize button

        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = SerialKiller3000.Properties.Resources._Mouse;
        }
        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = SerialKiller3000.Properties.Resources._;
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Borderless window move

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        #endregion

        private void SlidePanel(Control userControl)
        {
            if (!preferencesOpen)
            {
                this.Width += 265;
                this.CenterToScreen();
                preferencesOpen = true;

                userControl.Visible = true;
            }
            else if (preferencesOpen && !userControl.Visible)
            {
                CustomControlsAreVisible(false);
                userControl.Visible = true;
            }
            else
            {
                this.Width -= 265;
                this.CenterToScreen();
                preferencesOpen = false;

                CustomControlsAreVisible(false);
            }
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            preferencesWindow.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                stuff.Serial.RgbledOFF();
                stuff.Serial.uart.Close();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = SerialKiller3000.Properties.Resources.logoMouse;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = SerialKiller3000.Properties.Resources.logo;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/espilioto/SerialKiller3000");
        }



    }
}