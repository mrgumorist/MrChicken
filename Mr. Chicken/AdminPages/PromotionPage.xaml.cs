using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Interaction logic for PromotionPage.xaml
    /// </summary>
    /// Gridd
    public partial class PromotionPage : Page
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = new ServiceReferenceMrChicken.ProgrammServiceClient();
        public PromotionPage()
        {
            InitializeComponent();
        }

        private void StaticMethod()
        {
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Start promotion
            List <string> emails = (await client.GetEmailsAsync()).ToList();
            string textToSend = PromotionText.Text;


            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("mrgumor@gmail.com", "zxcv42177");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            for (int i = 0; i < emails.Count; i++)
            {

                MailMessage mail = new MailMessage();
                mail.To.Add(emails[i]);
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("mrgumor@gmail.com", "Mr.Chicken", System.Text.Encoding.UTF8);

                //mail.Subject = richTextBox1.Text;
                string Mesage = PromotionText.Text;
                mail.Body = Mesage;
                smtp.Send(mail);
            }
        }

    }
}
