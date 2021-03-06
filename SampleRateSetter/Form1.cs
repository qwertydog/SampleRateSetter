﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SampleRateSetter
{
    public partial class Form1 : Form
    {
        private enum Device { Schiit, ASUS };

        private enum SampleRate { FourtyFourOneHunded, FourtyEightThousand };

        public Form1()
        {
            InitializeComponent();

            contextMenuStrip1.Items.Insert(0, new ToolStripLabel("Set Sample Rate") { Enabled = false });
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();

                notifyIcon1?.Dispose();
                notifyIcon1 = null;
            }

            base.Dispose(disposing);
        }

        private void asus44100Button_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyFourOneHunded, Device.ASUS);

        private void asus48000Button_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyEightThousand, Device.ASUS);

        private void schiit44100Button_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyFourOneHunded, Device.Schiit);

        private void schiit48000Button_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyEightThousand, Device.Schiit);

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = Icon;
                Hide();
            }

            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void schiit44100ToolStripItem_Click(object sender, EventArgs e) 
            => SetSampleRate(SampleRate.FourtyFourOneHunded, Device.Schiit);

        private void schiit48000ToolStripItem_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyEightThousand, Device.Schiit);

        private void aSUS44100ToolStripMenuItem_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyFourOneHunded, Device.ASUS);

        private void aSUS48000ToolStripMenuItem_Click(object sender, EventArgs e)
            => SetSampleRate(SampleRate.FourtyEightThousand, Device.ASUS);

        private void notifyIcon1_Click(object sender, EventArgs e) => Activate();

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void SetSampleRate(SampleRate sampleRate, Device device)
        {
            Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL mmsys.cpl");
            Thread.Sleep(1000);
            NativeMethods.FindWindow(IntPtr.Zero, "Sound");

            // Select device
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");

            if (device == Device.Schiit)
            {
                SendKeys.SendWait("{DOWN}");
                SendKeys.SendWait("{DOWN}");
                SendKeys.SendWait("{DOWN}");
                SendKeys.SendWait("{DOWN}");
            }

            // Set default
            SendKeys.SendWait("%S");

            // Open properties
            SendKeys.SendWait("%P");

            // Select Advanced tab
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");

            if (device == Device.ASUS)
                SendKeys.SendWait("{RIGHT}");

            // Select sample rate combo box
            SendKeys.SendWait("{TAB}");

            // Change sample rate
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{DOWN}");
            SendKeys.SendWait("{UP}");

            if (device == Device.Schiit)
                SendKeys.SendWait("{UP}");

            if (sampleRate == SampleRate.FourtyFourOneHunded)
                SendKeys.SendWait("{UP}");

            // Confirm changes
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{ENTER}");
        }
    }
}
