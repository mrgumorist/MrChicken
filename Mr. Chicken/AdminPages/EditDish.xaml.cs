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
   
    public partial class EditDish : Window
    {
        byte[] Bytes;
        int ID;
        ProgrammServiceClient client = new ProgrammServiceClient();
        public EditDish(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Updates();

        }
        private async void Updates()
        {
            var dish = await client.GetDishSByIdAsync(ID);
            Name.Text = dish.Name;
            Littledescription.Text = dish.LittleDescription;
            Bytes = dish.Image;
            Image.Source = Helper.ByteToImage(Bytes);
            Recept.Text = dish.Recept;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File dialog
            System.Windows.Forms.OpenFileDialog choofdlog = new System.Windows.Forms.OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
                FilterIndex = 1,
                Multiselect = true
            
            };
            Bytes = null;
            choofdlog.ShowDialog();

            if (File.Exists(choofdlog.FileName))
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
            if(Name.Text!=""&&Recept.Text!= "" && Littledescription.Text!= "" && Bytes!=null)
            {
                var dish = await client.GetDishSByIdAsync(ID);
                dish.Image = Bytes;
                dish.LittleDescription = Littledescription.Text;
                dish.Name = Name.Text;
                dish.Recept = Recept.Text;
                dish.TypeID = 4;
                await client.UpdateDishAsync(dish);
                MessageBox.Show("Succesfull updated!");
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
            Name.Text = "";
            Recept.Text = "";
            Littledescription.Text = "";
            Bytes = null;
            Image.Source = null;
        }
    }
}
