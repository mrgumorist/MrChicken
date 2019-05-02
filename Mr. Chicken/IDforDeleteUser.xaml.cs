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
    /// Interaction logic for IDforDeleteUser.xaml
    /// </summary>
    public partial class IDforDeleteUser : Window
    {
        public int GetID()
        {
            return Int32.Parse(txtId.Text);
        } 
        public IDforDeleteUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            this.Close();
        }
    }
}
