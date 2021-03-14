using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtHeight.Text) || string.IsNullOrEmpty(TxtWeight.Text))
            {
                TxtResult.Text = "키와 몸무게를 입력하세요.";
                return;
            }

            double height = double.Parse(TxtHeight.Text) / 100.0;
            double weight = double.Parse(TxtWeight.Text);
            double bmi = weight / (height * height);
            TxtResult.Text = $"당신의 BMI는 {bmi:F2} 입니다.";

            if (bmi >= 35)
            {
                TxtResult.Text = "고도 비만 운동 ㄱㄱ";
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                TxtResult.Text = "중(重)도 비만(2단계 비만)";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                TxtResult.Text = "경도 비만(1단계 비만)";
            }
            else if (bmi >= 23 && bmi <= 24.9)
            {
                TxtResult.Text = "과체중";
            }
            else if (bmi >= 18.5 && bmi <= 22.9)
            {
                TxtResult.Text = "정상";
            }
            else if (bmi >= 0 && bmi <= 18.5)
            {
                TxtResult.Text = "저체중";
            }

        }
    }
}
