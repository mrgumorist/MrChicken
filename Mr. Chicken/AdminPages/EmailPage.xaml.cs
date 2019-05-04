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
    /// Interaction logic for EmailPage.xaml
    /// </summary>
    public partial class EmailPage : Page
    {
       ProgrammServiceClient client = new ProgrammServiceClient();
        ObservableCollection<EmailAcceptS> emails = new ObservableCollection<EmailAcceptS>();
        public EmailPage()
        {
            InitializeComponent();
            Download();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Download();
        }
        private async void Download()
        {
            var list = await client.GetEmailAcceptSAsync();
            emails.Clear();
            foreach (var item in list)
            {
                emails.Add(item);
            }
            Gridd.ItemsSource = null;
        }
    }
}
