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
            this.NumTxtBox_2.Text += "1";
        }

        private void Btn2_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "2";
        }

        private void Btn3_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "3";
        }

        private void Btn4_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "4";
        }

        private void Btn5_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "5";
        }

        private void Btn6_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "6";
        }

        private void Btn7_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "7";
        }

        private void Btn8_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "8";
        }

        private void Btn9_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "9";
        }

        private void Btn11_2_Click(object sender, RoutedEventArgs e)
        {
            this.NumTxtBox_2.Text += "0";
        }
    }
}
