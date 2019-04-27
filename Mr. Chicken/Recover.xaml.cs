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

namespace Mr.Chicken
{
    /// <summary>
    /// Interaction logic for Recover.xaml
    /// </summary>
    public partial class Recover : Window
    {
        public Recover()
        {
            InitializeComponent();
        }
        bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool IsEmail = IsValidEmail(email.Text);
            if(IsEmail)
            {
                //TODO recover
                MessageBox.Show("Email is sended. Please wait few seconds if letter is not received yet");
                Close();
            }
            else
            {
                MessageBox.Show("Invalid email");
            }
        }
    }
}
