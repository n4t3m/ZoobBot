using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Bite : ModuleBase
    {
        [Command("bite")]
        public async Task BiteAsync([Remainder] string echo)
        {
            string user = "" + echo + " was bitten! :O ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://tenor.com/tT3R.gif ";
                    break;
                case 1:
                    user += "https://tenor.com/W89N.gif ";
                    break;
                case 2:
                    user += "https://tenor.com/unYO.gif ";
                    break;
                case 3:
                    user += "https://tenor.com/L8Tt.gif ";
                    break;
                case 4:
                    user += "https://tenor.com/7P1I.gif ";
                    break;
                case 5:
                    user += "https://tenor.com/0mEP.gif ";
                    break;
                case 6:
                    user += "https://tenor.com/uYLP.gif ";
                    break;
                case 7:
                    user += "https://tenor.com/JkRM.gif ";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("bite")]
        public async Task RektAsync()
        {
            await ReplyAsync("`I can't bite that user`");

        }
    }
}





