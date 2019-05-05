using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace IService.MyBott
{
    public class MyBot
    {
        private static ITelegramBotClient botClient;
        string statusMsg;
        string botToken;
        bool isStarted;
        public bool IsStarted
        {
            get { return isStarted; }
        }
        static Telegram.Bot.Types.User me;
        public string StatusMsg
        {
            get { return statusMsg; }
        }
        public string BotToken
        {
            get { return botToken; }
            set { botToken = value; }
        }
        public int ID
     {
         get { return me.Id; }
     }
     public string Name
     {
         get { return me.FirstName; }
     }
     public MyBot(string botToken)
     {
         this.botToken = botToken;
         botClient = new TelegramBotClient(botToken) { Timeout = TimeSpan.FromSeconds(10) };
         me = botClient.GetMeAsync().Result;
         //StartBot();
     }
     
    
     public void StartBot()
     {
         isStarted = true;
         botClient.OnMessage += Bot_OnMessage;
         botClient.OnCallbackQuery += BotClient_OnCallbackQuery;
    
         botClient.StartReceiving();
     }
    
     private async void button_clickGetMyID(MessageEventArgs e)
     {           
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Your ID: {e.Message.From.Id}");
        }
        private async void button_clickGetRecipe(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки GET_RECIPE");
        }
        private async void button_clickAddProduct(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки AddProduct");
        }
        private async void button_clickDeleteProduct(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки DelleteProduct");
        }


        private async void BotClient_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data;
            string name = $"{e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName}";
            statusMsg += $"{name} нажав на кнопку {buttonText}" + Environment.NewLine;

            if (buttonText == "Puts1")
            {
                await botClient.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id, "Fuck you");
            }
            await botClient.AnswerCallbackQueryAsync(e.CallbackQuery.Id, $"Ви нажали на кнопку {buttonText}");
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var UserMsg = e?.Message?.Text;
            var message = e.Message;
            int UserId = e.Message.From.Id;

            if (e.Message.Text == "Get the recipe" + "\U0001F34F")//Обробка кнопки
            {
                button_clickGetRecipe(e);
            }
            if (e.Message.Text == "Get my id " + "\U0001F194")//Обробка кнопки
            {
                button_clickGetMyID(e);
            }
            if (e.Message.Text == "Add product" + "\U0001F4E6")//Обробка кнопки
            {
                button_clickAddProduct(e);
            }
            if (e.Message.Text == "Delete product" + "")//Обробка кнопки
            {
                button_clickDeleteProduct(e);
            }

            if (message.Type != MessageType.Text || UserMsg == null)
            {
                return;
            }
            string UserName = $"{message.From.FirstName} {message.From.LastName}";
            statusMsg += $"{UserName} відправив: {UserMsg} "
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
                            new KeyboardButton("Get the recipe"+"\U0001F34F"),
                            new KeyboardButton("Add product"+"\U0001F4E6")
                        },
                        new[]
                        {
                            new KeyboardButton("Get my id "+"\U0001F194") ,
                            new KeyboardButton("Delete product"+"")
                        }


                    });
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Повідомлення",
                        replyMarkup: replyKeyboard);
                    break;
                case "/created":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "©Mr.Chicken");
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


        public void Stop()
        {
            isStarted = false;
            botClient.StopReceiving();       
        }
    }
}
