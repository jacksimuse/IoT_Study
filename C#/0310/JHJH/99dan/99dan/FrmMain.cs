using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99dan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int.Parse(textBox1.Text);
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }
            else if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    textBox1.Text * i
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
