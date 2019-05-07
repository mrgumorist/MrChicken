using Mr.Chicken.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class BotPanel : Page, ServiceReferenceMrChicken.IServiceBotCallback
    {

        ServiceReferenceMrChicken.ServiceBotClient client;

        public BotPanel()
        {
            var instanceContext = new System.ServiceModel.InstanceContext(this);
            client = new ServiceReferenceMrChicken.ServiceBotClient(instanceContext);
            client.StartReceiving();
            InitializeComponent();
        }
        ~BotPanel()
        {
            client.StopReceiving();
        }         

        private void btnPromotion_Click(object sender, RoutedEventArgs e)
        {
            BotPromotion promotion = new BotPromotion();
            promotion.ShowDialog();
        }

        public void AddMessage(string msg)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtStatus.Text += msg;
            }));
          
        }
    }
}
