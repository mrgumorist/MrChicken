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

namespace Mr.Chicken.AdminPages
{
    /// <summary>
    /// Interaction logic for BotPromotion.xaml
    /// </summary>
    public partial class BotPromotion : Window
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client =  new ServiceReferenceMrChicken.ProgrammServiceClient();
        public BotPromotion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TO DO client.StartPromotionBot(string message);

        }
    }
}
