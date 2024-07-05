using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace raspiDisplay
{
    /// <summary>
    /// sender.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class sender : Window
    {
        public sender()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            raspiDisplay.userType usertype = new raspiDisplay.userType();
            usertype.Show();
            this.Close();
        }


        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            raspiDisplay.MainWindow main = new raspiDisplay.MainWindow();
            main.Show();
            this.Close();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "9";
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox.Text += "0";
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.NumTxtBox.Text)) // string.IsNullOrEmpty -> 문자열이 비어있거나 null일때 + !연산자(ex. !true == False)
            {
                this.NumTxtBox.Text = this.NumTxtBox.Text.Substring(0, this.NumTxtBox.Text.Length - 1); // substring -> 문자열 추출
            }
        }

        private void NumTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
