using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WebR.Sender.Telegram
{
    public class TelegramerTwo
    {
        public static readonly TelegramBotClient telegram2 = new TelegramBotClient(Configuration.ApiKEY2);
    }
}
