

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Dance : ModuleBase
    {
        [Command("dance")]
        public async Task DanceAsync()
        {
            string user = "You do a *dance*!\n";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://i.imgur.com/qAJfaa5.gif"; ;
                    break;
                case 1:
                    user += "https://thumbs.gfycat.com/AccurateEsteemedEasternnewt-max-1mb.gif";
                    break;
                case 2:
                    user += "https://i.kym-cdn.com/photos/images/newsfeed/001/115/816/936.gif";
                    break;
                case 3:
                    user += "https://66.media.tumblr.com/93a8499e09c26c22990964804c1903eb/tumblr_nfjpkgwTJT1tfilc6o1_400.gif";
                    break;
                case 4:
                    user += "https://media.giphy.com/media/xT9DPhEIWztxt13Otq/giphy.gif";
                    break;
                case 5:
                    user += "https://media.giphy.com/media/dUyHxzWUJX8Ri/giphy.gif";
                    break;
                case 6:
                    user += "https://i.gifer.com/aW2.gif";
                    break;
                case 7:
                    user += "https://media.tenor.com/images/028d5d4019f46a46f03f5bac3902bf40/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }

    }
}





