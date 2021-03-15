using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void StopWatchTick(object sender, EventArgs e)
        {
            IncreaseSecond();
            ShowTime();
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
            timer1.Enabled ^= true;
            // timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled ^= true;
            // timer1.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            ShowTime();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 타이머 세팅
            timer1.Interval = 1000;
            timer1.Tick += StopWatchTick;
        }
    }
}
