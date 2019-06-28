

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class BirthdayWish : ModuleBase
    {
        [Command("bdaywish")]
        public async Task BdayWishAsync([Remainder] string echo)
        {
            string user = "Happy Birthday " + echo + " ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.tenor.com/images/e185b18d55f729471a824c605f7789cb/tenor.gif"; ;
                    break;
                case 1:
                    user += "https://thumbs.gfycat.com/FrayedGrimColt-size_restricted.gif";
                    break;
                case 2:
                    user += "https://data.whicdn.com/images/299405277/original.gif";
                    break;
                case 3:
                    user += "https://i.redd.it/7yqwmqhrm7r11.gif";
                    break;
                case 4:
                    user += "https://66.media.tumblr.com/fe9d312fb9f129143b878d7cfc96a914/tumblr_p11iwjj6nN1wn2b96o1_400.gif";
                    break;
                case 5:
                    user += "https://media.giphy.com/media/LRCZEnOZRmAOE1MEWM/giphy.gif";
                    break;
                case 6:
                    user += "https://media1.tenor.com/images/61bfef3930c2e3991ec97123567deefa/tenor.gif";
                    break;
                case 7:
                    user += "https://media1.tenor.com/images/32547ace7ad1508169366fdfb6e80bd0/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("bdaywish")]
        public async Task RektAsync()
        {
            await ReplyAsync("`That is not a valid (cake-worthy) user! D:`");

        }
    }
}





