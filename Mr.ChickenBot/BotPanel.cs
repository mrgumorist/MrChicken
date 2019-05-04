using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Mr.ChickenBot
{
    public partial class BotPanel : Form
    {
        private static MyBot myBotCLient;       
        private string BotToken = "826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE";
            ServiceReferenceMrChickenBot.ProgrammServiceClient client =
                new ServiceReferenceMrChickenBot.ProgrammServiceClient();

        public BotPanel()
        {
            InitializeComponent();
            myBotCLient = new MyBot(BotToken);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "STATUS ON";
            if (myBotCLient.IsStarted == false)
            {
                myBotCLient.StartBot();
                txtStatus.Text += $"Bot id: {myBotCLient.ID}. Bot name: {myBotCLient.Name}" + Environment.NewLine;
            }
            else
            {
                txtStatus.Text += "Bot is started!!!" + Environment.NewLine;
            }
        }    
        
        private void button2_Click(object sender, EventArgs e)
        {

            if (myBotCLient.IsStarted == true)
            {
                myBotCLient.Stop();
                lblStatus.Text = "STATUS OFFED";
                txtStatus.Text += Environment.NewLine + "BOT STOPED" + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Bot if offed!", "Bot Panel");
            }
                     
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                txtStatus.Text += myBotCLient.StatusMsg;
            }
            catch (Exception){}
        }
    }
}
