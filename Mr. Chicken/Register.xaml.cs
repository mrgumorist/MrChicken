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

namespace Mr.Chicken
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            surname.Text = "";
            login.Text = "";
            password.Password = "";
            email.Text = "";
            birth.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(email.Text!="" && name.Text != "" && surname.Text != ""&& login.Text != "" && password.Password != ""&& birth.Text != "")
            {

            }
            else
            {
                MessageBox.Show("One or more of these textboxes are empty, please check and change it!");
            }
        }
    }
}
