using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuguWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 선택 초기화
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트박스 초기화
            listBox1.Items.Clear();

            var comboItem = (ComboBox) sender;
            int dan = int.Parse((String) comboItem.SelectedItem);

            for(int i = 1; i <= 9; i++)
                listBox1.Items.Add($"{dan} × {i} = {dan * i,2}");
        }
    }
}
