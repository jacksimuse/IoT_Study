using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButton
{
    public partial class StopWatch : Form
    {
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;

        public StopWatch()
        {
            InitializeComponent();
        }


        private void StopWatchTick(object sender, EventArgs e)
        {
            ShowTime();

            IncreaseSecond();
        }

        private void ShowTime()
        {
            Hour.Text = hours.ToString("00");
            Minute.Text = minutes.ToString("00");
            Second.Text = seconds.ToString("00");
        }

        private void IncreaseSecond()
        {
            if (seconds > 59)
            {
                seconds = 0;
                IncreaseMinute();
            }
            else
                seconds++;

        }

        private void IncreaseMinute()
        {
            if (minutes > 59)
            {
                minutes = 0;
                IncreaseHour();
            }
            else
                minutes++;
        }

        private void IncreaseHour()
        {
            hours++;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += StopWatchTick;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            ShowTime();
        }
    }
}
