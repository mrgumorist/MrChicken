using IService.EntitiesReturn;
using Mr.Chicken.ServiceReferenceMrChicken;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mr.Chicken.AdminPages
{
    /// <summary>
    /// Interaction logic for NewDish.xaml
    /// </summary>
   
    public partial class NewDish : Window
    {
        byte[] Bytes;
        ProgrammServiceClient client = new ProgrammServiceClient();
        public NewDish()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File dialog
           System.Windows.Forms.OpenFileDialog choofdlog = new System.Windows.Forms.OpenFileDialog();
            choofdlog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            choofdlog.FilterIndex = 1;
            Bytes = null;
            choofdlog.Multiselect = true;
            choofdlog.ShowDialog();

            if(File.Exists(choofdlog.FileName))
            {
                using (FileStream fs = new FileStream(choofdlog.FileName, FileMode.Open, FileAccess.Read))
                {
                    // Create a byte array of file stream length
                    byte[] bytes = System.IO.File.ReadAllBytes(choofdlog.FileName);
                    //Read block of bytes from stream into the byte array
                    fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                    //Close the File Stream
                    fs.Close();
                    Bytes = bytes;
                    Image.Source = Helper.ByteToImage(Bytes);
                }
            }
            else
            {
                MessageBox.Show("Please, Choose file");
            }
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Create
            if(Name!=null&&Recept!=null&&Littledescription!=null&& Bytes!=null)
            {
               DishS dish =  (await client.GetEmptyDishSAsync());
                dish.Image = Bytes;
                dish.LittleDescription = Littledescription.Text;
                dish.Name = Name.Text;
                dish.Recept = Recept.Text;
                dish.TypeID = 4;
                await client.AddDishSAsync(dish);
                MessageBox.Show("Succesfull added!");
                Close();
            }
            else
            {
                MessageBox.Show("Please check data! Error");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Clear all
            
        }
    }
}
