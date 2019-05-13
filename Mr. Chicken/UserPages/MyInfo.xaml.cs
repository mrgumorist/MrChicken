using IService.EntitiesReturn;
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

namespace Mr.Chicken.UserPages
{
    /// <summary>
    /// Interaction logic for MyInfo.xaml
    /// </summary>
    public partial class MyInfo : Page
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
        int UserId;
        public MyInfo(int id)
        {
            UserId = id;
            InitializeComponent();
            LoadInfo(id);
        }
        private async void LoadInfo(int id)
        {

            var Users = await client.GetUsersAsync();
            var UserInfo = Users.FirstOrDefault(u => u.ID == id);
            List<UserS> users = new List<UserS>();
            users.Add(UserInfo);
            dataGrid.ItemsSource = null;
            var Users_ = users.Select(u => new
            {
                u.ID,
                u.Name,
                u.Surname,
                u.Login,
                u.Password,
                u.TelegramID,
                u.Email,
                u.ISConfirmed,
                u.DateOfRegister,
                u.DateOfBirth,
                u.DoesWantRecomendations
            }
          );
            dataGrid.ItemsSource = Users_;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditUserInfo editUserInfo = new EditUserInfo(UserId);
            editUserInfo.ShowDialog();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await client.SetTelegramIDAsync(UserId, txtTelegramId.Text);
                MessageBox.Show("Telegram id added!");
            }
            catch (Exception)
            {
                MessageBox.Show("WRONG ID!!!");
            }
        }
    }
}
