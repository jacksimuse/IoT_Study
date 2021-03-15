using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtonApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // this.Load += DynamicButtonLoad;
        }

        private void DynamicButtonLoad(object sender, EventArgs e)
        {
            DynamicButtonLoad();
        }

        private void DynamicButtonLoad()
        {
            Control[] BTN = new Control[30];
            FlowLayoutPanel FLP = new FlowLayoutPanel();

            this.Text = "동적 생성 예제";
            this.Width = 10;
            this.Height = 10;

            for (int idx = 0; idx < 20; idx++)
            {
                BTN[idx] = new Button();
                BTN[idx].Name = idx.ToString();
                BTN[idx].Parent = this;
                BTN[idx].Size = new Size(75, 30);

                int x = idx;
                BTN[idx].Text = "동적버튼" + x.ToString();
                this.Width = 400;
                this.Height += 10;

                FLP.Controls.Add(BTN[idx]);
            }

            this.Controls.Add(FLP);
            FLP.Dock = DockStyle.Fill;
        }
    }
}
