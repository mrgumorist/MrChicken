using Mr.Chicken.UserPages;
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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private int UserId;
        public UserWindow(int id)
        {
            UserId = id;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new MyAvaliableRecepts(UserId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new MyInfo(UserId);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.Content = new MyProducts(UserId);
        }
    }
}
