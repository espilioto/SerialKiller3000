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
    public partial class StrobeControl : UserControl
    {
        public StrobeControl()
        {
            InitializeComponent();
        }

        int r = 0, g = 0, b = 0;
        bool on = false;

        private void StrobeControl_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            label2.Text = (trackBar1.Value * 10 + "ms").ToString();

            timerStrobe.Interval = trackBar1.Value * 10;
        }


        #region bars and number stuff

        private void redbar_Scroll(object sender, EventArgs e)
        {
            redupdown.Value = redbar.Value;
            r = redbar.Value;
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            greenupdown.Value = greenbar.Value;
            g = greenbar.Value;
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            blueupdown.Value = bluebar.Value;
            b = bluebar.Value;
        }
        private void redupdown_ValueChanged(object sender, EventArgs e)
        {
            redbar.Value = int.Parse(redupdown.Value.ToString());
            r = int.Parse(redupdown.Value.ToString());
        }
        private void greenupdown_ValueChanged(object sender, EventArgs e)
        {
            greenbar.Value = int.Parse(greenupdown.Value.ToString());
            g = int.Parse(greenupdown.Value.ToString());
        }
        private void blueupdown_ValueChanged(object sender, EventArgs e)
        {
            bluebar.Value = int.Parse(blueupdown.Value.ToString());
            b = int.Parse(blueupdown.Value.ToString());
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            r = (int)colorDialog1.Color.R;
            g = (int)colorDialog1.Color.G;
            b = (int)colorDialog1.Color.B;

            redupdown.Value = r;
            redbar.Value = r;
            greenupdown.Value = g;
            greenbar.Value = g;
            blueupdown.Value = b;
            bluebar.Value = b;

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timerStrobe.Interval = trackBar1.Value * 10;
            label2.Text = (trackBar1.Value * 10 + "ms").ToString();
        }

        public void strobeModeStart(object sender, EventArgs e)
        {
            timerStrobe.Enabled = true;
            timerStrobe.Start();
        }
        public void strobeModeStop(object sender, EventArgs e)
        {
            timerStrobe.Stop();
            timerStrobe.Enabled = false;
            stuff.Serial.RgbledOFF();
        }

        private void timerStrobe_Tick(object sender, EventArgs e)
        {
            if (Form1.connected && stuff.Mode == (int)stuff.ModeStatus.strobeModeActive)
            {
                if (!on)
                {
                    stuff.Serial.uart.Write("rgb " + r + "," + g + "," + b + ";");
                    on = !on;
                }
                else
                {
                    stuff.Serial.uart.Write("rgb " + 0 + "," + 0 + "," + 0 + ";");
                    on = !on;
                }
            }
        }

    }
}
