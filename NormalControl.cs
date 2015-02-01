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
    public partial class NormalControl : UserControl
    {

        public static bool normalMode = false;
        public int r = 0, g = 0, b = 0;

        public NormalControl()
        {
            InitializeComponent();
        }

        private void NormalControl_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;

            UpdateUIValues();
        }

        #region bars and updowns

        private void redbar_Scroll(object sender, EventArgs e)
        {
            redupdown.Value = redbar.Value;
            r = redbar.Value;
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            greenupdown.Value = greenbar.Value;
            g = greenbar.Value;
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            blueupdown.Value = bluebar.Value;
            b = bluebar.Value;
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }
        private void redupdown_ValueChanged(object sender, EventArgs e)
        {
            redbar.Value = int.Parse(redupdown.Value.ToString());
            r = int.Parse(redupdown.Value.ToString());
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }
        private void greenupdown_ValueChanged(object sender, EventArgs e)
        {
            greenbar.Value = int.Parse(greenupdown.Value.ToString());
            g = int.Parse(greenupdown.Value.ToString());
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }
        private void blueupdown_ValueChanged(object sender, EventArgs e)
        {
            bluebar.Value = int.Parse(blueupdown.Value.ToString());
            b = int.Parse(blueupdown.Value.ToString());
            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
        }

        private void UpdateUIValues()
        {
            redupdown.Value = r;
            greenupdown.Value = g;
            blueupdown.Value = b;

            redbar.Value = r;
            greenbar.Value = g;
            bluebar.Value = b;

        }

        #endregion  

        private void btnOff_Click(object sender, EventArgs e)
        {
            stuff.Serial.RgbledOFF();

            redbar.Value = 0;
            bluebar.Value = 0;
            greenbar.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            r = (int)colorDialog1.Color.R;
            g = (int)colorDialog1.Color.G;
            b = (int)colorDialog1.Color.B;

            redupdown.Value = r;
            greenupdown.Value = g;
            blueupdown.Value = b;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NormalControl_r = r;
            Properties.Settings.Default.NormalControl_g = g;
            Properties.Settings.Default.NormalControl_b = b;
            Properties.Settings.Default.Save();
        }

        public void LoadSettingsNormalControl()
        {
            r = Properties.Settings.Default.NormalControl_r;
            g = Properties.Settings.Default.NormalControl_g;
            b = Properties.Settings.Default.NormalControl_b;
        }

    }
}
