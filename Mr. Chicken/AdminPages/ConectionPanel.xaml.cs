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
        List<TempProduct> products = new List<TempProduct>();

        static int ID = -1;
        public ConectionPanel()
        {
            InitializeComponent();
            GetAsync();
        }
        void OnChecked(object sender, RoutedEventArgs e)
        {
            TempProduct classObj = Displaying.SelectedItem as TempProduct;
            if (products.Where(t => t.ProdID == classObj.ProdID).First().IsCheked == false)
            {
                products.Where(t => t.ProdID == classObj.ProdID).First().IsCheked = true;
            }
            else
            {
                products.Where(t => t.ProdID == classObj.ProdID).First().IsCheked = false;
            }
            Displaying.ItemsSource = null;
            Displaying.ItemsSource = products;
        }
        private async void GetAsync()
        {
            dishes.Clear();
            products.Clear();
            Displaying.ItemsSource = null;
            Displayy.ItemsSource = null;
            var list = await client.GetDishesSAsync();
            foreach (var item in list)
            {
                dishes.Add(item);
            }
          //  MessageBox.Show(dishes.Count.ToString());
            Displayy.ItemsSource = dishes;
            var prod = await client.GetProductSSAsync();
            foreach (var item in prod)
            {
                products.Add(new TempProduct() { ProdID = item.ID, Name = item.Name });
            }
            Displaying.ItemsSource = products;
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
            //Cancel checking
            Displaying.IsEnabled = true;
            foreach (var item in products)
            {
                item.IsCheked = false;
            }
            Displaying.ItemsSource = products;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Add Products
            List<IntermediateS> intermediateS = new List<IntermediateS>();
            foreach (var item in (List<TempProduct>)Displaying.ItemsSource)
            {
                if (item.IsCheked == true)
                    intermediateS.Add(new IntermediateS() { DishID = ID, ProductID = item.ProdID });
            }
            var arr = intermediateS.ToArray();
            client.AddIntermidiatef(arr);
            Displayy.IsEnabled = true;
            Displaying.IsEnabled = true;
            foreach (var item in products)
            {
                item.IsCheked = false;
            }

            MessageBox.Show("Succesfull aded");
            Displayy.ItemsSource = dishes;
            Displaying.ItemsSource = products;
        }

    }
    public class TempProduct
    {
        public TempProduct()
        {

        }
        public int ProdID { get; set;  }
        public bool IsCheked { get; set; } = false;
        public string Name { get; set; }
    }
}
