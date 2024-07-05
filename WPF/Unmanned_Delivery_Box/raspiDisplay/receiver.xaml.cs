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
    /// receiver.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class receiver : Window
    {
        public receiver()
        {
            InitializeComponent();
        }

        private void AppendTextToTextBox(string text)
        {
            this.NumTxtBox_2.Text += text;
            NumTxtBox_2.Focus();
            NumTxtBox_2.CaretIndex = NumTxtBox_2.Text.Length; // 커서를 맨 뒤로 이동
        }

        private void backBtn_2_Click(object sender, RoutedEventArgs e)
        {
            raspiDisplay.userType usertype = new raspiDisplay.userType();
            usertype.Show();
            this.Close();
        }

        private void homeBtn_2_Click(object sender, RoutedEventArgs e)
        {
            raspiDisplay.MainWindow main = new raspiDisplay.MainWindow();
            main.Show();
            this.Close();
        }

        private void Btn1_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("1");
        }

        private void Btn2_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("2");
        }

        private void Btn3_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("3");                   
        }

        private void Btn4_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("4");
        }

        private void Btn5_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("5");
        }

        private void Btn6_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("6");
        }

        private void Btn7_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("7");
        }

        private void Btn8_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("8");
        }

        private void Btn9_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("9");
        }

        private void Btn11_2_Click(object sender, RoutedEventArgs e)
        {
            AppendTextToTextBox("0");
        }

        private void Btn10_2_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.NumTxtBox_2.Text)) 
            {
                this.NumTxtBox_2.Text = this.NumTxtBox_2.Text.Substring(0, this.NumTxtBox_2.Text.Length - 1);
                NumTxtBox_2.Focus();
                NumTxtBox_2.CaretIndex = NumTxtBox_2.Text.Length;
            }
        }

        // 버튼을 누르면 텍스트박스 활성화가 안됨..;;
        private void NumTxtBox_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NumTxtBox_2.Text.Length > 6)
            {
                NumTxtBox_2.Text = NumTxtBox_2.Text.Substring(0, 6);
            }
        }
    }
}
