using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialKiller3000
{
    public partial class PreferencesWindow : Form
    {

        public PreferencesWindow()
        {
            InitializeComponent();
        }

        private void PreferencesWindow_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            checkBoxWithWindoze.Checked = Properties.Settings.Default.Preferences_runWithWindows;
            checkBoxStartMinimized.Checked = Properties.Settings.Default.Preferences_startMinimized;
            autorunModeCheckbox.Checked = Properties.Settings.Default.Preferences_autostart;
            autorunModeComboBox.SelectedIndex = Properties.Settings.Default.Preferences_autostart_mode;

            if (Properties.Settings.Default.Preferences_autoconnect)
            {
                autorunModeCheckbox.Enabled = true;
            }
            else
            {
                autorunModeCheckbox.Enabled = false;
                autorunModeComboBox.Enabled = false;
            }

            if (Properties.Settings.Default.Preferences_autostart)
            {
                autorunModeCheckbox.Enabled = true;
                autorunModeComboBox.Enabled = true;
            }
            else
            {
                autorunModeCheckbox.Enabled = false;
                autorunModeComboBox.Enabled = false;
            }

            richTextBox1.Text = "Hello and welcome to the Serial KILLER 3000 help menu!" +
                                "\n\nAvailable commands:" +
                                "\noff;                All outputs go LOW, PWM to 0% duty cycle." +
                                "\nrst;                Soft reset." +
                                "\nping;             The Serial KILLER 3000 replies accordingly." +
                                "\nrgb r,g,b;       RGB mode, acceptable values 0 - 255." +
                                "\nbit x,y;           Port 1 GPIO control." +
                                "\nman;/help;     Prints this screen.";
        }

        private void checkBoxWithWindoze_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (checkBoxWithWindoze.Checked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
                Properties.Settings.Default.Preferences_runWithWindows = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
                Properties.Settings.Default.Preferences_runWithWindows = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnIdle_Click(object sender, EventArgs e)
        {
            stuff.Serial.RgbledOFF();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            stuff.Serial.RgbledRST();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\r•08/2014: beta3 - Semi-implemented sound mode (CoreAudio). Some UI changes." +
                            "\r•05/2014: beta2 - Minor UI and stability improvements." +
                            "\r•04/2014: beta1 - Main functionality achieved." +
                            "\r•03/2014: Rewrote the entire core code for the uC, it now tokenizes and parses strings." +
                            "\r•Early 2014: Rewrote in C#" +
                            "\r•Even later: Minor improvements" +
                            "\r•A bit later: It's alive!" +
                            "\r•Winter 2013: Started the project in VB.net" +
                            "\r\rMore Updates here https://github.com/espilioto/SerialKiller3000");
        }

        private void checkBoxStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartMinimized.Checked)
            {
                Properties.Settings.Default.Preferences_startMinimized = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Preferences_startMinimized = checkBoxStartMinimized.Checked;
                Properties.Settings.Default.Save();
            }

        }


        private void autoconnectCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.Preferences_autoconnect = autoconnectCheckBox.Checked;
            Properties.Settings.Default.Save();

            if (autoconnectCheckBox.Checked)
            {
                autorunModeCheckbox.Enabled = true;
            }
            else
            {
                autorunModeCheckbox.Enabled = false;
                autorunModeComboBox.Enabled = false;
            }
        }
        private void autorunModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Preferences_autostart = autorunModeCheckbox.Checked;
            Properties.Settings.Default.Save();

            autorunModeComboBox.Enabled = autorunModeCheckbox.Checked;
        }
        private void autorunModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Preferences_autostart_mode = autorunModeComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        



    }
}
