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
    public partial class AddNew : Window
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
        public AddNew()
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
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(email.Text!="" && name.Text != "" && surname.Text != ""&& login.Text != "" && password.Password != ""&& birth.Text != "")
            {
                if (IsValidEmail(email.Text))
                {
                    if (await client.IsEmailUniqueAsync(email.Text))
                    {
                        if (!Regex.Match(surname.Text, "^[A-Z][a-zA-Z]*$").Success)
                        {
                            Console.WriteLine("Invalid Surname");
                        }
                        else
                        {
                            if (Regex.Match(name.Text, "^[A-Z][a-zA-Z]*$").Success)
                            {
                                Console.WriteLine("Invalid Name");
                                var user = client.GetEmptyUser();
                                user.DateOfBirth = birth.SelectedDate.Value;
                                user.Name = name.Text;
                                user.Surname = surname.Text;
                                user.Login = login.Text;
                                user.Password = password.Password;
                                user.DateOfRegister = DateTime.Now;
                                user.DoesWantRecomendations = true;
                                user.Email = email.Text;
                                user.ISConfirmed = false;
                                user.TelegramID = "-";
                                await client.AddUserAsync(user);
                                MessageBox.Show("Succesfull added. Insert data to text boxes");
                                Close();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Name");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This email is already in use. Change it or recover password");
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
