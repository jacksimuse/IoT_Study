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
using System.Windows.Threading;

namespace BmiWpfApp
{

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Bmi { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            // MessageBox.Show("Sample");
        }
        

        private void TxtHeight_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtHeight.Text = "";
            TxtHeight.Foreground = Brushes.Black;
        }

        private void TxtWeight_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtWeight.Text = "";
            TxtWeight.Foreground = Brushes.Black;
        }

        private void TxtHeight_LostFocus(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TxtHeight.Text))
            {
                TxtHeight.Text = "키 입력";
                TxtHeight.Foreground = Brushes.Gray;
            }
        }

        private void TxtWeight_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtWeight.Text))
            {
                TxtWeight.Text = "몸무게 입력";
                TxtWeight.Foreground = Brushes.Gray;
            }
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(TxtHeight.Text, out double H) && double.TryParse(TxtWeight.Text, out double W)
                && H > 0.0d)
            {

                H /= 100;
                Bmi = W / (H * H);

                // 새 윈도우창 말고 팝업창을 쓴다!!
                // Result r = new Result();
                // r.ShowDialog();
                // PopupPanel.Background = Brushes.Red;

                if (!(ResultPopup.IsOpen ^= true))
                    return;
                
                if (Bmi >= 35)
                { // 고도 비만
                    PopupPanel.Background = Brushes.DarkRed;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n고도 비만 입니다.";
                }
                else if(Bmi >= 30)
                { // 중도 비만
                    PopupPanel.Background = Brushes.IndianRed;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n중도 비만 입니다.";
                }
                else if(Bmi >= 25)
                { // 경도 비만
                    PopupPanel.Background = Brushes.OrangeRed;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n경도 비만 입니다.";
                }
                else if(Bmi >= 23)
                { // 과체중
                    PopupPanel.Background = Brushes.Red;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n과체중 입니다.";
                }
                else if(Bmi >= 18.5)
                { // 정상
                    PopupPanel.Background = Brushes.ForestGreen;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n정상 입니다.";
                    // this.Close();
                }
                else
                { // 저체중
                    PopupPanel.Background = Brushes.GreenYellow;
                    PopupLabel.Content = $"[BMI : {Bmi:#.##}]\n저체중 입니다.";
                }
            }
        }

        private void BtnTable_Click(object sender, RoutedEventArgs e)
        {
            // 목록 리스트 보여주기
            TablePopup.IsOpen ^= true;
        }

        private void BackPopupBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultPopup.IsOpen ^= true;
        }

        private void TablePopup_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TablePopup.IsOpen ^= true;
        }
    }
}
