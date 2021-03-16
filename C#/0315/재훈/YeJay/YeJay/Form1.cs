using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeJay
{
    public partial class Form1 : Form
    {
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;
        public Form1()
        {
            InitializeComponent();

            // 버튼에 클릭이벤트를 선언
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

        }

        /// <summary>
        /// 초 증가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void IncreaseSecond()
        {
            if (seconds > 59)
            {
                seconds = 0;
                IncreaseMinute();
            }
            else
            {
                seconds++;
            }
        }

        private void IncreaseMinute()
        {
            if (minutes > 59)
            {
                minutes = 0;
                IncreaseHour();
            }
            else
            {
                minutes++;
            }
        }

        private void IncreaseHour()
        {
            hours++;
        }

        public void StopWatch_Tick(object sender, EventArgs e)
        {
            
            IncreaseSecond();
            ShowTime();
        }

        private void ShowTime()
        {
            label1.Text = hours.ToString("00");
            label2.Text = minutes.ToString("00");
            label3.Text = seconds.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            ShowTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000; // interval이 ms단위이므로 1000해주면 1초
            // Timer Tick 이벤트
            timer1.Tick += StopWatch_Tick;
        }
    }
}
