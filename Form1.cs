﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Exam_Window
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Timer timer;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            DisplayInfo();

            //timer 
            timer = new Timer();
            timer.Interval = 5000; // 5 sec
            timer.Tick += Timer_Tick;
            timer.Start();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void DisplayInfo()
        {
            labelCurrentUser.Text = Environment.UserName;

            if (SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.NoSystemBattery)
            {
                int batteryPercent = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);
                labelBatteryPercent.Text = "Battery: " + batteryPercent.ToString() + "%";

                if (batteryPercent > 50)
                    this.BackColor = Color.LightGreen;
                else if (batteryPercent < 50 && batteryPercent > 25)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Red;

                TimeSpan batteryLifeRemaining = TimeSpan.FromSeconds(SystemInformation.PowerStatus.BatteryLifeRemaining);
                labelBatteryLifeRemaining.Text = "~" + batteryLifeRemaining.ToString(@"hh\:mm\:ss") + "est.";
            }
            else
            {
                labelBatteryPercent.Text = "Battery: N/A";
                labelBatteryLifeRemaining.Text = "No battery detected...";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        //tricks program into thinking tool bar is clicked for draggability
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        //stops alt+f4
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void labelBatteryPercent_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void labelCurrentUser_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelBatteryLifeRemaining_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void labelBatteryPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
