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
            MessageBox.Show(dataGrid.SelectedIndex.ToString());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dataGrid.SelectedIndex.ToString());
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            if (e.NewItem != null)
            {
                MessageBox.Show(((ProductS)e.NewItem).Name);
            }
        }
    }
}
