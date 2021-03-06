﻿using IService;
using IService.EntitiesReturn;
using Mr.Chicken.ServiceReferenceMrChicken;
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
    /// Interaction logic for EditUserInfo.xaml
    /// </summary>
    public partial class EditUserInfo : Window
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
        List<UserS> userS = new List<UserS>();
        int userID;
        
        public EditUserInfo(int ID)
        {
            userID = ID;
            InitializeComponent();
            ShowInfo();
        }
        void ShowInfo()
        {
            var user = client.GetUser(userID);
            txtEmail.Text = user.Email;
            txtLogin.Text = user.Login;
            txtName.Text = user.Name;
            txtPassword.Text = user.Password;
            txtSurname.Text = user.Surname;
            txtTelegramID.Text = user.TelegramID;
            datePickerBirth.Text = user.DateOfBirth.ToString();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            var user = new UserS();
            user.DateOfBirth = datePickerBirth.SelectedDate.Value;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.Surname = txtSurname.Text;
            user.Name = txtName.Text;
            user.TelegramID = txtTelegramID.Text;

            client.UpdateUserInfo(userID, user);
            MessageBox.Show("Editing saved","Edit Menu");
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
