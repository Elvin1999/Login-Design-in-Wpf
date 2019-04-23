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

namespace LoginS
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

   

        private void MailTxtB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mailTxtB.Text == "E-mail Address")
            {
                mailTxtB.Text = String.Empty;
            }
        }

        private void MailTxtB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mailTxtB.Text == String.Empty)
            {
                mailTxtB.Text = "E-mail Address";
            }
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == "yourpassword")
            {
                Password.Password = String.Empty;
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == String.Empty)
            {
                Password.Password = "yourpassword";
            }
        }
    }
}
