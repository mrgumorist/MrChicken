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

namespace Mr.Chicken.AdminPages
{
    /// <summary>
    /// Interaction logic for BotPanel.xaml
    /// </summary>
    public partial class BotPanel : Page
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = 
            new ServiceReferenceMrChicken.ProgrammServiceClient();

        public BotPanel()
        {
            InitializeComponent();
        }

       
        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            await client.StartBotAsync();
            txtStatus.Text += "BOT STARTED "+DateTime.Now + Environment.NewLine;
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {           
                txtStatus.Text += "Status: "+ await client.GetStatusMsgAsync() +Environment.NewLine;
            await client.StopBotAsync();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            //await client.StopBotAsync();
            BotPromotion promotion = new BotPromotion();
            promotion.ShowDialog();
        }

        private async void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
