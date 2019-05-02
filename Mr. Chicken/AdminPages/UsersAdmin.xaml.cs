using Mr.Chicken.ServiceReferenceMrChicken;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
      //  ObservableCollection<UserS> users = new ObservableCollection<UserS>();
        public UsersAdmin()
        {
            InitializeComponent();
          
            var Users = client.GetUsers();
            //foreach (var item in Users)
            //{
            //    users.Add(item);
            //}
            var Users_ = Users.Select(u => new
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
           // MessageBox.Show(dataGrid.Columns.Count.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
        private void Update()
        {
            var Users = client.GetUsers();
            dataGrid.ItemsSource = null;
            var Users_ = Users.Select(u => new
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
            text.Text = "";
            dataGrid.ItemsSource = Users_;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // var user = client.GetEmptyUser();
            AddNew addNew = new AddNew();
            addNew.ShowDialog();
            Update();
            //UsersAdmin();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //DELETE
            var Users = client.GetUsers();
            var rowView = dataGrid.SelectedItem as DataRowView;
            if (rowView != null)
            {
                DataRow row = rowView.Row;
                
                for (int i = 0; i < Users.Count(); i++)
                {
                    if (Users[i].ID == int.Parse(row["ID"].ToString()))
                    {
                        //remote method
                        client.RemoveUserS(Users[i]);
                        MessageBox.Show("Succesfull deleted. Press update button");
                        break;

                    }
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //ChangeInfo
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Find by all propertys
            var Users = client.FindUsersByProp(text.Text);
            if(Users.Count()!=0)
            {
                dataGrid.ItemsSource = null;
                var Users_ = Users.Select(u => new
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
                text.Text = "";
                dataGrid.ItemsSource = Users_;
            }
            else
            {
                MessageBox.Show("Nothing finded with this property");
            }
        }
    }
}
