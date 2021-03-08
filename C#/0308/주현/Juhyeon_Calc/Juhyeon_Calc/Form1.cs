using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juhyeon_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc(char type)
        {
            int Num1 = int.Parse(TxtNum1.Text.ToString());
            int Num2 = int.Parse(TxtNum2.Text.ToString());
            int Result = 0;

            try
            {
                if (type == '+')
                {
                    Result = Num1 + Num2;
                    TxtResult.Text = Num1 + " + " + Num2 + " = " + Result;
                }
                else if (type == '-')
                {
                    Result = Num1 - Num2;
                    TxtResult.Text = Num1 + " - " + Num2 + " = " + Result;
                }
                else if (type == '*')
                {
                    Result = Num1 * Num2;
                    TxtResult.Text = Num1 + " * " + Num2 + " = " + Result;
                }
                else if (type == '/')
                {
                    Result = Num1 / Num2;
                    TxtResult.Text = Num1 + " / " + Num2 + " = " + Result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "예외 발생");
            }
            
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Calc('+');
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calc('-');
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            Calc('*');
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Calc('/');
        }
    }
}
