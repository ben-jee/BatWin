using System;
using System.Windows.Forms;

namespace Exam_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            // show current user
            labelCurrentUser.Text = "Logged in as: " + Environment.UserName;

            //show battery
            if (SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.NoSystemBattery)
            {
                int batteryPercent = (int)(SystemInformation.PowerStatus.BatteryLifePercent  * 100);
                labelBatteryPercent.Text = "Battery: " + batteryPercent.ToString() + "%";
            }
            else
            {
                labelBatteryPercent.Text = "Battery: N/A";
            }
        }

        //prevent user closing form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        //make form movable
        private void Form1_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int WM_NCLBUTTONDOWN = 0XA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
    }
}
