using Mr.Chicken.AdminPages;
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
using System.Windows.Shapes;

namespace Mr.Chicken
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        ServiceReferenceMrChicken.ServiceBotClient client;
        public AdminPanel()
        {
            var instanceContext = new System.ServiceModel.InstanceContext(this);
            client = new ServiceReferenceMrChicken.ServiceBotClient(instanceContext);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            MainFrame.Content = null;
            MainFrame.Content = new UsersAdmin();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new ProductsPage();
            //MainFrame.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new EmailPage();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new PromotionPage();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new DishesPage();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new ConectionPanel();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new BotPanel();
        }                 
    }
}
