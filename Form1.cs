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
            System.Windows.Forms.PowerStatus ps = SystemInformation.PowerStatus;
            int batteryPercent = (int)(ps.BatteryLifePercent * 100);
            labelBatteryPercent.Text = "Battery: " + batteryPercent.ToString() + "%";
        }
    }
}
