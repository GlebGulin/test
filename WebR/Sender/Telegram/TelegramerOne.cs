using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WebR.Sender
{
    public static class TelegramerOne
    {
        public static readonly TelegramBotClient telegram = new TelegramBotClient(Configuration.ApiKEY);
       
    }
}
