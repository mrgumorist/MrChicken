using IService.EntitiesReturn;
using Microsoft.VisualBasic;
using Mr.Chicken.ServiceReferenceMrChicken;
//using Mr.Chicken.ServiceReferenceMrChicken;
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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {

        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
        ObservableCollection<ProductS> productS = new ObservableCollection<ProductS>();
        // ObservableCollection<> users = new ObservableCollection<User>();
        //return from client ListObservalseColection
        // ObservableCollection<ProductS> products = new ObservableCollection<ProductS>();
        public ProductsPage()
        {
            InitializeComponent();
            Load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
        private async void Load()
        {
           
            //TODO LOADING PRODUCTS FROM LIST
            var products = await client.GetProductSSAsync();
            productS.Clear();

            foreach (var item in products)
            {
                productS.Add(item);
            }
           // MessageBox.Show(products.Count().ToString());
           // var prod= products.ToList();
            dataGrid.ItemsSource = productS;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(dataGrid.SelectedIndex.ToString());
            // MessageBox.Show(productS[dataGrid.SelectedIndex].Name);
            var res = Interaction.InputBox("Enter name of product","Enter", $"{productS[dataGrid.SelectedIndex].Name}");
            if (res != "")
            {
               //productS[dataGrid.SelectedIndex].Name = res;
                client.ChangeProduct(productS[dataGrid.SelectedIndex].ID, res);
                MessageBox.Show(productS[dataGrid.SelectedIndex].ID.ToString());
                Load();
                MessageBox.Show("Succesfull changed");
            }
          
                //MessageBox.Show(res);
            }
            
           

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(dataGrid.SelectedIndex.ToString());
            client.DeleteProduct(productS[dataGrid.SelectedIndex].ID);
            Load();
            MessageBox.Show("Succesfull deleted");
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            //if (e.NewItem != null)
            //{
            //    MessageBox.Show(((ProductS)e.NewItem).Name);
            //}
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Create
            var res = Interaction.InputBox("Enter name of product", "Product", "");
            if (res != "")
            {
                var Product = await client.GetEmptyProductAsync();
                Product.Name = res;
                client.AddProduct(Product);
                MessageBox.Show("Succesfull added");
                //MessageBox.Show(res);
            }
            Load();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str = Text.Text;
            bool finded = false;
            foreach (var item in productS)
            {
                if (item.Name.ToLower().Contains(Text.Text.ToLower()))
                {
                    finded = true;
                    break;
                }
            }
            if(finded!=false)
            {
                MessageBox.Show("This item already exist");
            }
        }
    }
}
