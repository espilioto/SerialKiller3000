using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialKiller3000
{
    public partial class SoundControl : UserControl
    {
        public SoundControl()
        {
            InitializeComponent();
        }

        int soundLevel = 0;
        public void SoundControl_Load(object sender, EventArgs e)
        {
            stuff.CoreAudio.FindDevices();

            for (int i = 0; i < stuff.CoreAudio.devs.Count; i++)
            {
                deviceBox.Items.Add(stuff.CoreAudio.devs[i].FriendlyName);
            }

            deviceBox.SelectedIndex = 0;
            radioRed.Select();
        }

        private void timerSound_Tick(object sender, EventArgs e)
        {
            if (stuff.Mode == (int)stuff.ModeStatus.SoundModeActive)
            {
                soundLevel = (int)(stuff.CoreAudio.device.AudioMeterInformation.MasterPeakValue * trackBar1.Value);
                
                Application.DoEvents();
                
                if (radioRed.Checked)
                    stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[(soundLevel * 2)] + "," + 0 + "," + 0 + ";");
                else if (radioGreen.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + stuff.Gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioBlue.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + 0 + "," + stuff.Gamma.correction[(soundLevel * 2)] + ";");
                else if (radioRG.Checked)
                    stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[(soundLevel * 2)] + "," + stuff.Gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioRB.Checked)
                    stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[(soundLevel * 2)] + "," + 0 + "," + stuff.Gamma.correction[(soundLevel * 2)] + ";");
                else if (radioGB.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + stuff.Gamma.correction[(soundLevel * 2)] + "," + stuff.Gamma.correction[(soundLevel * 2)] + ";");
                else if (radioWhite.Checked)
                    stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[(soundLevel * 2)] + "," + stuff.Gamma.correction[(soundLevel * 2)] + "," + stuff.Gamma.correction[(soundLevel * 2)] + ";");

                soundBar.Value = soundLevel;
            }
        }

        public void soundModeStart(object sender, EventArgs e)
        {
            if (stuff.CoreAudio.devs == null)
                stuff.CoreAudio.device = stuff.CoreAudio.DevEnum.GetDefaultAudioEndpoint(CoreAudioApi.EDataFlow.eRender, CoreAudioApi.ERole.eMultimedia);

            timerSound.Start();
        }
        public void soundModeStop(object sender, EventArgs e)
        {
            timerSound.Stop();

            stuff.Serial.RgbledOFF();
            
            soundBar.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            stuff.CoreAudio.device = stuff.CoreAudio.devs[(int)deviceBox.SelectedIndex];
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }
    }

    }

