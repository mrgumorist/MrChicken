using IService.EntitiesReturn;
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
    /// Interaction logic for MyAvaliableRecepts.xaml
    /// </summary>
    public partial class MyAvaliableRecepts : Page
    {
        int UserId;
        
        ServiceReferenceMrChicken.ProgrammServiceClient client =
            new ServiceReferenceMrChicken.ProgrammServiceClient();
        private DishS[] rec;

        public MyAvaliableRecepts(int id)
        {
            UserId = id;
            InitializeComponent();            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {            
                rec = await client.GetUseAvailableReceptAsync(UserId);
                dataGridDishes.ItemsSource = rec;            
        }

        private void dataGridDishes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(client.GetRecipesBot(rec));
        }
    }
}
