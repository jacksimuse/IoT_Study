using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int WIDTH = 0;
        public int HEIGHT = 0;
        public Form1()
        {
            InitializeComponent();

            this.Load += DynamicButton_Load;
        }

        private void DynamicButton_Load(object sender, EventArgs e)
        {
            DynamicButton();
        }

        private void DynamicButton()
        {
            Control[] BTN = new Control[10];
            FlowLayoutPanel flp = new FlowLayoutPanel();

            for (int idx = 0; idx < 10; idx++)
            {
                BTN[idx] = new Button();
                BTN[idx].Name = idx.ToString();
                BTN[idx].Parent = this;
                BTN[idx].Size = new Size(90, 30);
                int x = idx + 1;
                BTN[idx].Text = "Dynamic_" + x.ToString();

                Width += 80;
                Height += 30;

                flp.Controls.Add(BTN[idx]);
            }

            this.Controls.Add(flp);
            flp.Dock = DockStyle.Fill; 
        }
    }
}
