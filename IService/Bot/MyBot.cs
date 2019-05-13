using IService.Entities;
using IService.EntitiesReturn;
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
        public delegate void GetStatus(string message);
        public event GetStatus GetStatusMessage;
        Context context = new Context();
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

        public async void SendMsgToUser(string UserID,string msg)
        {
            try
            {
            await botClient.SendTextMessageAsync(Int32.Parse(UserID), msg);
            }
            catch (Exception)
            {
            }
        }

        private async void button_clickGetMyID(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Your ID: {e.Message.From.Id}");
        }
        private async void button_clickGetRecipe(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Looking for recipe in DB...");
            try
            {
                string id = e.Message.Chat.Id.ToString();
            var user = context.users.FirstOrDefault(u => u.TelegramID == id);
           
                var recipes =  GetUseAvailableReceptBot(Int32.Parse(user.TelegramID));
                GetRecipesBot(recipes,e);
                //await botClient.SendTextMessageAsync(e.Message.Chat.Id,"RECIPES: "+Environment.NewLine+ recps +Environment.NewLine);
          
            }
            catch (Exception)
            {
             await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Cant find recipe, maybe you are not registred!!!");
            }


        }
        //private async void button_clickAddProduct(MessageEventArgs e)
        //{
        //    await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки AddProduct");
        //}
        //private async void button_clickDeleteProduct(MessageEventArgs e)
        //{
        //    await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Вітаю Обробка кнопки DelleteProduct");
        //}


        private async void BotClient_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data;
            string name = $"{e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName}";
            GetStatusMessage($"{name} нажав на кнопку {buttonText}" + Environment.NewLine);
            if (buttonText == "Button1")
            {
                await botClient.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id, "Puts1");
            }
            if (buttonText == "Button2")
            {
                await botClient.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id, "Puts1");
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
            //if (e.Message.Text == "Add product" + "\U0001F4E6")//Обробка кнопки
            //{
            //    button_clickAddProduct(e);
            //}
            //if (e.Message.Text == "Delete product" + "")//Обробка кнопки
            //{
            //    button_clickDeleteProduct(e);
            //}

            if (message.Type != MessageType.Text || UserMsg == null)
            {
                return;
            }
            string UserName = $"{message.From.FirstName} {message.From.LastName}";
            GetStatusMessage($"{UserName} відправив: {UserMsg}" 
                + $" ID користувача : {UserId}" + Environment.NewLine);

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
                            InlineKeyboardButton.WithUrl("Some web","http://google.com"),
                            InlineKeyboardButton.WithUrl("Some web2","http://google.com")
                        },
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("Button1"),
                            InlineKeyboardButton.WithCallbackData("Button2")

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
                            //new KeyboardButton("Add product"+"\U0001F4E6")
                        },
                        new[]
                        {
                            new KeyboardButton("Get my id "+"\U0001F194") ,
                            //new KeyboardButton("Delete product"+"")
                        }


                    });
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Повідомлення",
                        replyMarkup: replyKeyboard);
                    break;
                case "/created":
                    await botClient.SendTextMessageAsync(message.Chat.Id, "©Mr.Chicken");
                    break;
                default:
                    
                    break;
            }

            //await botClient.SendTextMessageAsync(
            //    chatId: e.Message.Chat,
            //    text: $"Будь ласка не надсилайте повідомлення, це може зламати бота xD!"
            //).ConfigureAwait(false);
        }

        private List<DishS> GetUseAvailableReceptBot(int UserId)
        {
            List<DishS> dishes = new List<DishS>();
            var userproducts = context.userProducts.Where(t => t.UserID == context.users.FirstOrDefault(u=>u.TelegramID == UserId.ToString()).ID).ToList();

            foreach (var item in userproducts)
            {
                try
                {
                    var dishestemp = item.ProductV.intermediate.Distinct(new IntermediateEqualityComparer()).Select(t => t.DishV);
                    dishes.Add(dishestemp.Select(t => new DishS()
                    {
                        ID = t.ID,
                        LittleDescription = t.LittleDescription,
                        Name = t.Name,
                        Recept = t.Recept,
                        TypeID = t.TypeID
                    }).FirstOrDefault());
                }
                catch (Exception)
                {


                }
            }
            var b = dishes.Distinct(new DishesEqualityComparer());

            //dishes = new List<DishS>();



            return b.ToList();
        }

        public async void GetRecipesBot(List<DishS> recipes, MessageEventArgs e)
        {
            string recipe = "";
            foreach (var item in recipes)
            {
                recipe = item.Name+Environment.NewLine +item.Recept + Environment.NewLine;
                await botClient.SendTextMessageAsync(e.Message.Chat.Id, "RECIPES: " + Environment.NewLine + recipe + Environment.NewLine);
            }

            //return recipe;
        }

        public void Stop()
        {
            isStarted = false;
            botClient.StopReceiving();       
        }
    }
}
