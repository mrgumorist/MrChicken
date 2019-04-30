using Mr.Chicken.ServiceReferenceMrChicken;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Mr.Chicken
{
    /// <summary>
    /// Interaction logic for UsersAdmin.xaml
    /// </summary>
    public partial class UsersAdmin : Page
    {
        ObservableCollection<UserS> users = new ObservableCollection<UserS>();
        public UsersAdmin()
        {
            InitializeComponent();
            ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
            var Users = client.GetUsers();
            foreach (var item in Users)
            {
                users.Add(item);
            }
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
                u.DoesWantRecomendations
            }
            );
            //var Users = client.GetUsers();
            dataGrid.ItemsSource = Users_;

            //TO DO! HIDE FIRST COLUMN
            //dataGrid.Columns.Remove(dataGrid.Columns.First());
            //dataGrid.Columns[$"{dataGrid.Columns.First().Header.ToString()}"].Visibility = Visibility.Hidden;
            MessageBox.Show(dataGrid.Columns.Count.ToString());
        }

    }
}
