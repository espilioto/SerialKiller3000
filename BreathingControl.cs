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
    public partial class BreathingControl : UserControl
    {

        public static bool breathingMode = false;
        bool rising;
        int pwm = 0;

        public BreathingControl()
        {
            InitializeComponent();
        }

        private void BreathingControl_Load(object sender, EventArgs e)
        {
            breathRed.Select();
        }

        public void BreathingStart(object sender, EventArgs e)
        {

            if (stuff.Mode == (int)stuff.ModeStatus.breathingModeActive)

                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 20;

            {
                if (pwm < 10)        //this looks better than turning the led completely off
                    rising = true;
                else if (pwm > 199)
                    rising = false;

                if (pwm < 200 && rising)
                    if (trackBar1.Value == 1)
                    {
                        pwm++;
                    }
                    else if (trackBar1.Value == 2)
                    {
                        pwm += 2;
                    }
                    else if (trackBar1.Value == 3)
                    {
                        pwm += 3;
                    }
                    else if (trackBar1.Value == 4)
                    {
                        pwm += 4;
                    }
                    else
                    {
                        pwm += 5;
                    }
                else
                    if (trackBar1.Value == 1)
                        pwm--;
                    else if (trackBar1.Value == 2)
                        pwm -= 2;
                    else if (trackBar1.Value == 3)
                        pwm -= 3;
                    else if (trackBar1.Value == 4)
                        pwm -= 4;
                    else
                        pwm -= 5;

                if (breathRed.Checked)
                    stuff.Serial.uart.Write("rgb " + pwm + "," + 0 + "," + 0 + ";");
                else if (breathGreen.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + pwm + "," + 0 + ";");
                else if (breathBlue.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + 0 + "," + pwm + ";");
                else if (breathRG.Checked)
                    stuff.Serial.uart.Write("rgb " + pwm + "," + pwm + "," + 0 + ";");
                else if (breathRB.Checked)
                    stuff.Serial.uart.Write("rgb " + pwm + "," + 0 + "," + pwm + ";");
                else if (breathGB.Checked)
                    stuff.Serial.uart.Write("rgb " + 0 + "," + pwm + "," + pwm + ";");
                else
                    stuff.Serial.uart.Write("rgb " + pwm + "," + pwm + "," + pwm + ";");
            }
        }

        public void BreathingStop()
        {
            timer1.Stop();
            timer1.Enabled = false;
            stuff.Serial.RgbledOFF();
            pwm = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                label2.Text = "Very slow";
            }
            else if (trackBar1.Value == 2)
            {
                label2.Text = "Slow";
            }
            else if (trackBar1.Value == 3)
            {
                label2.Text = "Normal";
            }
            else if (trackBar1.Value == 4)
            {
                label2.Text = "Fast";
            }
            else
            {
                label2.Text = "Very fast";
            }
        }

    }
}
