using ApiAiSDK;
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
        private static ApiAi apiAi;
        private string BotToken = "826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE";
        private string DialogFlowToken = "dfe5887f46c54f69bb6da15ce1b67da5";
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
            AIConfiguration config = new AIConfiguration(DialogFlowToken, SupportedLanguage.Russian);
            apiAi = new ApiAi(config);
            var me = botClient.GetMeAsync().Result;
            txtStatus.Text += $"Bot id: {me.Id}. Bot name: {me.FirstName}" + Environment.NewLine;

            botClient.OnMessage += Bot_OnMessage;
            botClient.OnCallbackQuery += BotClient_OnCallbackQuery;
           
            botClient.StartReceiving();
        }       
        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var UserMsg = e?.Message?.Text;
            var message = e.Message;           
            int UserId = e.Message.From.Id;

            if (e.Message.Text.ToLower() == "hello")//Обробка кнопки
            {
                await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки:)");
            }
            

            if (message.Type != MessageType.Text || UserMsg == null)
            {
                return;
            }           
            string UserName = $"{message.From.FirstName} {message.From.LastName}";

            txtStatus.Text += $"{UserName} відправив: {UserMsg} "
                + $" ID користувача : {UserId}" + Environment.NewLine;

            switch (message.Text)
            {
                
                case "/start":
                    string text =
                        @"Список команд:
                          /start - запуск бота
                          /inline - вивід меню
                          /keyboard - вивід клавіатури";
                    await botClient.SendTextMessageAsync(message.Chat.Id, text); 
                    break;
                case "/inline":
                    var InlineKeyboard = new InlineKeyboardMarkup(new[]
                    {
                        new[]
                        {
                            InlineKeyboardButton.WithUrl("Porn Hub","http://pornhub.com"),
                            InlineKeyboardButton.WithUrl("Porn Hub2","http://pornhub.com")
                        },
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("Puts1"),
                            InlineKeyboardButton.WithCallbackData("Puts2")

                        }
                    });
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть пункт меню", 
                        replyMarkup: InlineKeyboard);
                    break;
                case "/keyboard":
                    var replyKeyboard = new ReplyKeyboardMarkup(new[]
                    {
                        new[]
                        {
                            new KeyboardButton("hello"),
                            new KeyboardButton("Як справи")
                        },
                        new[]
                        {
                            new KeyboardButton("Контакт") { RequestContact = true},
                            new KeyboardButton("Геолокація") {RequestLocation = true}
                        }
                        
                        
                    });                    
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Повідомлення",
                        replyMarkup: replyKeyboard);                             
                    break;
                case "/created":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Створено поцами");
                    break;
                default:                   
                    //var responce = apiAi.TextRequest(message.Text);
                    //string answer = responce.Result.Fulfillment.Speech;
                    //if (answer == "")
                    //{
                    //    answer = "Вибач, я тебе не розумію";
                    //}
                    //await botClient.SendTextMessageAsync(message.Chat.Id, answer);
                    break;
            }

            //await botClient.SendTextMessageAsync(
            //    chatId: e.Message.Chat,
            //    text: $"Будь ласка не надсилайте повідомлення, це може зламати бота xD!"
            //).ConfigureAwait(false);
        }

        

        private async void BotClient_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data;
            string name = $"{e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName}";
            txtStatus.Text += $"{name} нажав на кнопку {buttonText}";

            if(buttonText == "puts1")
            {
                await botClient.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id, "Fuck you");
            }
            await botClient.AnswerCallbackQueryAsync(e.CallbackQuery.Id, $"Ви нажали на кнопку {buttonText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "STATUS OFFED";
            botClient.StopReceiving();
            
        }
    }
}
