using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebR.Sender.Telegram
{
    public abstract class Comand
    {
        public abstract string Name { get; }
        public abstract void Execute(Message message, TelegramBotClient botClient);
        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(Configuration.Name);
        }
    }
}
