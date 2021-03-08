using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumin_calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calc(char type)
        {
            int Num1 = int.Parse(TxtNum1.Text.ToString());
            int Num2 = int.Parse(TxtNum3.Text.ToString());
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
                MessageBox.Show(e.Message, "오류 발생!");
            }


        }

            
            private void BtnPlus_Click(object sender, EventArgs e)
            {
                Calc('+');
            }

            private void Btnsub_Click(object sender, EventArgs e)
            {
               Calc('-');
            }

            private void BtnMutp_Click(object sender, EventArgs e)
            {
               Calc('*');
            }

            private void BtnDivi_Click(object sender, EventArgs e)
            {
               Calc('/');
            }
     }
}

