using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaehun_Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Calculator(char type)
        {
            decimal Num1 = decimal.Parse(TxtNum1.Text.ToString());
            decimal Num2 = decimal.Parse(TxtNum2.Text.ToString());
            decimal Result = 0;

            try
            {
                if (type == '+')
                {
                    Result = Num1 + Num2;

                    TxtResult.Text = Result.ToString();
                }
                else if (type == '-')
                {
                    Result = Num1 - Num2;

                    TxtResult.Text = Result.ToString();
                }
                else if (type == '*')
                {
                    Result = Num1 * Num2;

                    TxtResult.Text = Result.ToString();
                }
                else
                {
                    Result = Num1 / Num2;

                    TxtResult.Text = Result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 { ex.Message}");
            }
        }
        
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Calculator('+');
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Calculator('-');
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            Calculator('*');
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            Calculator('/');
        }
    }
}
