using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace DishMasterBot
{
    class Program
    {
        private static ITelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE") { Timeout = TimeSpan.FromSeconds(10) };

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Bot id: {me.Id}. Bot name: {me.FirstName}");

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Console.ReadKey();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var text = e?.Message?.Text;
            var UserId = e.Message.From.Id.ToString();
            if (text == null)
            {
                return;
            }
            Console.WriteLine($"recieved message: {text} in chat {e.Message.Chat.Id}"
                + $" User id = {UserId}");

            await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat,
                text: $"Idi naxyi"
            ).ConfigureAwait(false);
        }
    }
}
