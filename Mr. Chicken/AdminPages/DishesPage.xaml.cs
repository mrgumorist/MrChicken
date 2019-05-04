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
//using System.Windows.Forms;
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
            Updload();
        }
        private async void Updload()
        {
            var dish = await client.GetDishesSAsync();
            Display.ItemsSource = null;
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
            DishS classObj = Display.SelectedItem as DishS;
            int id = classObj.ID;

            EditDish newDish = new EditDish(id);
            newDish.ShowDialog();
            Updload();
            //MessageBox.Show(id);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Delete
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("You realy want delete item?", "Deleting", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                DishS classObj = Display.SelectedItem as DishS;
                int id = classObj.ID;
                client.DeleteDishByIDAsync(id);
            }
            else if (dialogResult == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Deleting canceled");
            }
            Updload();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add new
            NewDish newDish = new NewDish();
            newDish.ShowDialog();
            Updload();
            Updload();
        }
    }
}
