using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Hug : ModuleBase
    {
        [Command("hug")]
        public async Task HugAsync([Remainder] string echo)
        {
            string user = "" + echo + " got hugged! <3 uwu ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://tenor.com/5ZCA.gif"; ;
                    break;
                case 1:
                    user += "https://tenor.com/5ZCA.gif";
                    break;
                case 2:
                    user += "https://tenor.com/PM3W.gif";
                    break;
                case 3:
                    user += "https://tenor.com/zXMi.gif";
                    break;
                case 4:
                    user += "https://tenor.com/Rw9D.gif";
                    break;
                case 5:
                    user += "https://tenor.com/1oGd.gif";
                    break;
                case 6:
                    user += "https://tenor.com/HQ8k.gif";
                    break;
                case 7:
                    user += "https://tenor.com/zEgl.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("hug")]
        public async Task RektAsync()
        {
            await ReplyAsync("`You Must Enter a valid user to hug! T_T`");

        }
    }
}





