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
    /// Interaction logic for ConectionPanel.xaml
    /// </summary>
    public partial class ConectionPanel : Page
    {
        ObservableCollection<DishS> dishes = new ObservableCollection<DishS>();
        ProgrammServiceClient client = new ProgrammServiceClient();

        static int ID = -1;
        public ConectionPanel()
        {
            InitializeComponent();
            GetAsync();
        }
        
        private async void GetAsync()
        {
            dishes.Clear();
            Displaying.ItemsSource = null;
            Displayy.ItemsSource = null;
            var list = await client.GetDishesSAsync();

            var prod = await client.GetProductSSAsync();
            Displaying.ItemsSource = prod;

            

            foreach (var item in list)
            {
                dishes.Add(item);
            }
            Displayy.ItemsSource = dishes;
          
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DishS classObj = Displayy.SelectedItem as DishS;
            ID = classObj.ID;
            Displayy.IsEnabled = false;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Displayy.IsEnabled = true;
            ID = -1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Displaying.IsEnabled = true;
            GetAsync();
            

        }

        
        private async void Displaying_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Do you want to add this product?", "ADD MENU", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (Displaying.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    var selectedProduct = Displaying.SelectedItem as ProductS;

                    List<IntermediateS> intermediateS = new List<IntermediateS>();

                    intermediateS.Add(new IntermediateS() { DishID = ID, ProductID = selectedProduct.ID });
                    var arr = intermediateS.ToArray();
                    await client.AddIntermidiatefAsync(arr);
                    Displaying.IsEnabled = true;
                                       
                    MessageBox.Show(string.Format("Succesfull!", "MENU"));
                    showInerProducts();
                    

                }
            }
            
        }

        private async void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product?", "DELETE MENU", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (Displaying.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    var selectedProduct = Displaying.SelectedItem as ProductS;
                    await client.DeleteProductIntermediateByIDAsync(selectedProduct.Name);
                    
                    showInerProducts();
                    MessageBox.Show(string.Format("Succesfull!", "MENU"));
                }
            }
        }
        private async void showInerProducts()
        {
            try
            {
                List<ProductS> productUser = new List<ProductS>();
                ProductS p = new ProductS();
                var Us_prod = await client.GetRecipeProdByNameAsync(ID);

                var products = await client.GetProductSSAsync();


                foreach (var item in Us_prod)
                {
                    var pr = (products.FirstOrDefault(p1 => p1.ID == item.ProductID));
                    productUser.Add(pr);
                }
                Displaying.ItemsSource = productUser;

            }
            catch (Exception)
            {
                MessageBox.Show("Empty!");
            }

        }

        private void Displayy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DishS classObj = Displayy.SelectedItem as DishS;
            ID = classObj.ID;
            showInerProducts();
        }
    }
    
}
