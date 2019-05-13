using IService.Entities;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mr.Chicken.UserPages
{
    /// <summary>
    /// Interaction logic for MyProducts.xaml
    /// </summary>
    public partial class MyProducts : Page
    {
        ProgrammServiceClient client = new ProgrammServiceClient();
        int UserID_;
        public MyProducts(int id)
        {
            InitializeComponent();
            UserID_ = id;
            GetAsync();
            showUserProducts();


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
                     
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private async void GetAsync()
        {
            dataGridProd.ItemsSource = null;
            var prod = await client.GetProductSSAsync();
            dataGridProd.ItemsSource = prod;
            //try
            //{
            //var UsProd = await client.GetUserProductsAsync(UserID_);
            //dataGridUProd.ItemsSource = UsProd;
            //}
            //catch (Exception)
            //{
            //}
        }
        private async void showUserProducts()
        {
            try
            {
            List<ProductS> productUser = new List<ProductS>();
            ProductS p = new ProductS();
            var Us_prod = await client.GetUserProductsAsync(UserID_);
            var products = await client.GetProductSSAsync();
            

                foreach (var item in Us_prod)
                {
                    var pr = (products.FirstOrDefault(p1 => p1.ID == item.ProductID));
                    productUser.Add(pr);
                }
            dataGridUProd.ItemsSource = productUser;

            }
            catch (Exception)
            {
                MessageBox.Show("Empty!");
            }
            
        }

        private async void dataGridProd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {           
            if (MessageBox.Show("Do you want to add this product?", "ADD MENU", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (dataGridProd.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    var selectedProduct = dataGridProd.SelectedItem as ProductS;
                    await client.AddUserProductsAsync(new UserProductsS { UserID = UserID_, ProductID = selectedProduct.ID });
                    List<ProductS> p = new List<ProductS>();
                    p.Add(selectedProduct);
                    showUserProducts();
                    MessageBox.Show(string.Format("Succesfull!", "MENU"));
                }
            }
        }

        private async void dataGridUProd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product?", "DELETE MENU", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (dataGridUProd.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    var selectedProduct = dataGridUProd.SelectedItem as ProductS;
                    await client.DeleteProductByNameAsync(selectedProduct.Name);                    
                    showUserProducts();
                    MessageBox.Show(string.Format("Succesfull!", "MENU"));
                }
            }


        }
    }
}
