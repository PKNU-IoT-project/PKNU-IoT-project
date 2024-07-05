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
    }
}
