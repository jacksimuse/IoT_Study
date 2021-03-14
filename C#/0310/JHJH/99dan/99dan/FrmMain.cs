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
            var str = textBox1.Text;
            int num = int.Parse(str);
            try
            {
                if (str == "")
                {
                    MessageBox.Show("숫자를 입력해주세요");
                }
                else if (listBox1.Items.Count != 0)
                {
                    listBox1.Items.Clear();
                }
                else
                {
                    for (int i = 1; i < 10; i++)
                    {
                        listBox1.Items.Add($"{num} * {i} = {num * i}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
