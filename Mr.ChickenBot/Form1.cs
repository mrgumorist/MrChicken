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
    public partial class Form1 : Form
    {
        private static ITelegramBotClient botClient;
        private string BotToken = "826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE";
            //ServiceReferenceMrChickenBot.ProgrammServiceClient client =
            //    new ServiceReferenceMrChickenBot.ProgrammServiceClient();

        public Form1()
        {
            InitializeComponent();
        }                
        
        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "STATUS ON";
           
            botClient = new TelegramBotClient(BotToken) { Timeout = TimeSpan.FromSeconds(10) };

            var me = botClient.GetMeAsync().Result;
            txtStatus.Text += $"Bot id: {me.Id}. Bot name: {me.FirstName}" + Environment.NewLine;

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }

        

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var text = e?.Message?.Text;

            var UserId = e.Message.From.Id.ToString();
            if (text == null)
            {
                return;
            }
            txtStatus.Text += $"Отримане повідомлення: {text} "
                + $" ID користувача : {UserId}" + Environment.NewLine;

            await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat,
                text: $"Будь ласка не надсилайте повідомлення, це може зламати бота xD!"
            ).ConfigureAwait(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "STATUS OFFED";
            botClient.StopReceiving();
            
        }
    }
}
