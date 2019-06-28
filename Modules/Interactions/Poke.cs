using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Poke : ModuleBase
    {
        [Command("poke")]
        public async Task PokeAsync([Remainder] string echo)
        {
            string user = "" + echo + " just got poked!!!! owo ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://tenor.com/xsRA.gif"; ;
                    break;
                case 1:
                    user += "https://tenor.com/0BCE.gif ";
                    break;
                case 2:
                    user += "https://tenor.com/XiDr.gif";
                    break;
                case 3:
                    user += "https://tenor.com/UY9o.gif";
                    break;
                case 4:
                    user += "https://tenor.com/Z8Tr.gif ";
                    break;
                case 5:
                    user += "https://tenor.com/P42U.gif ";
                    break;
                case 6:
                    user += "https://tenor.com/XL3o.gif";
                    break;
                case 7:
                    user += "https://tenor.com/5f4F.gif ";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("poke")]
        public async Task RektAsync()
        {
            await ReplyAsync("`That is not a valid (poke-worthy) user! D:`");

        }
    }
}





