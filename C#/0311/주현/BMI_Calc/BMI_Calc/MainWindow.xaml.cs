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

namespace BMI_Calc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, RoutedEventArgs e)
        {
            if (txtHeight.Text == "" || txtWeight.Text == "")
            {
                lblResult.Content = "키 또는 체중을 입력하세요";
                return;
            }
            double h = Convert.ToDouble(txtHeight.Text) / 100.0;
            double w = Double.Parse(txtWeight.Text);
            double bmi = Math.Round( w / (h * h), 2);

            // Form에서는 Label.Text 인데, WPF에서는 label.Content 
            if (bmi >= 35) 
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 고도 비만 입니다");
            else if (bmi >= 30)
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 중도 비만(2단계 비만) 입니다");
            else if (bmi >= 25)
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 경도 비만(1단계 비만) 입니다");
            else if (bmi >= 23)
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 과체중 입니다");
            else if (bmi >= 18.5)
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 정상체중 입니다");
            else
                lblResult.Content = string.Format($"당신의 BMI는 {bmi}, 저체중 입니다");
        }
    }
}
