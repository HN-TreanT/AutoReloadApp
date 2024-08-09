using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
namespace AutoReloadApp
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        int totalSeconds; 
        int remainingSeconds;

        [DllImport("user32.dll")]
        static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
            inputDuration.KeyPress += new KeyPressEventHandler(inputDuration_KeyPress);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Elapsed += OnTimerEvent;
        }

        private void OnTimerEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(async () =>
            {
                if (remainingSeconds > 0)
                {
                    remainingSeconds -= 1; // Decrease by 1 second
                    UpdateLabel(remainingSeconds);
                }
                else
                {
                    string[] browserProcesses = { "msedge", "chrome", "firefox" };

                    foreach (var processName in browserProcesses)
                    {
                        Process[] processes = Process.GetProcessesByName(processName);

                        if (processes.Length > 0)
                        {
                            SetForegroundWindow(processes[0].MainWindowHandle);
                            SendKeys.SendWait("{F5}");
                            await Task.Delay(1000);
                            SendKeys.SendWait("{F11}");
                            break;
                        }
                    }

                    remainingSeconds = totalSeconds;
                    UpdateLabel(totalSeconds);
              
                }
            }));
        }

        private void UpdateLabel(int seconds)
        {
            int h = seconds / 3600;
            int m = (seconds % 3600) / 60;
            int s = seconds % 60;

            label1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer.Start();
            start.Enabled = false;
            start.BackColor = Color.FromArgb(169, 169, 169); 
            start.ForeColor = Color.FromArgb(128, 128, 128);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            start.Enabled = true;
            start.BackColor = Color.FromArgb(0, 205, 151);
            start.ForeColor = Color.White;
        }

        private void inputDuration_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inputDuration.Text, out remainingSeconds))
            {
                totalSeconds = remainingSeconds;
                UpdateLabel(remainingSeconds);
            }
        }

        private void inputDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the keypress
            }
        }

    }

}
