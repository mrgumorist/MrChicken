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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
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
        bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(email.Text!="" && name.Text != "" && surname.Text != ""&& login.Text != "" && password.Password != ""&& birth.Text != "")
            {
                if (IsValidEmail(email.Text))
                {
                    if (!Regex.Match(surname.Text, "^[A-Z][a-zA-Z]*$").Success)
                    {
                        Console.WriteLine("Invalid Surname");
                    }
                    else
                    {
                        if (!Regex.Match(name.Text, "^[A-Z][a-zA-Z]*$").Success)
                        {
                            Console.WriteLine("Invalid Name");
                            var User;
                        }
                        else
                        {

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid email");
                }
            }
            else
            {
                MessageBox.Show("One or more of these textboxes are empty, please check and change it!");
            }
        }
    }
}
