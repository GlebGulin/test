using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WebR.Models.Telegram
{
    public static class AppTelegram
    {
        private static TelegramBotClient botclient;
        private static async Task<TelegramBotClient> Get()
        {
            if (botclient!=null)
            {
                return botclient;
            }
            botclient = new TelegramBotClient(Configuration.ApiKEY);
            await botclient.SetWebhookAsync("");
            return botclient;
        }
    }
}
