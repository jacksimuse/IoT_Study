using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace gugudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var btn = sender as Button;
            var str = btn.Text;

            int num = int.Parse(str);

            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add( $"{num} X {i} = {num * i}\n");
            }

        }
    }
}