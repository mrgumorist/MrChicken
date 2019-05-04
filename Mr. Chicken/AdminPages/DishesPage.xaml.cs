using IService.EntitiesReturn;
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

namespace Mr.Chicken.AdminPages
{
    /// <summary>
    /// Interaction logic for DishesPage.xaml
    /// </summary>
    /// 
    
    public partial class DishesPage : Page
    {
        ObservableCollection<DishS> dishes = new ObservableCollection<DishS>();
        ProgrammServiceClient client = new ProgrammServiceClient();
        public DishesPage()
        {
            InitializeComponent();
        }
        private async void Updload()
        {
            var dish = await client.GetDishesSAsync();
            dishes.Clear();
            foreach (var item in dish)
            {
                dishes.Add(item);
            }
            Display.ItemsSource = dishes;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Change info
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Delete
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add new
            NewDish newDish = new NewDish();
            newDish.ShowDialog();
        }
    }
}
