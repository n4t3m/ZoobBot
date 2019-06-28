using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Slap : ModuleBase
    {
        [Command("slap")]
        public async Task SlapAsync([Remainder] string echo)
        {
            string user = "" + echo + " has been slapped! ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media1.tenor.com/images/49de17c6f21172b3abfaf5972fddf6d6/tenor.gif?itemid=10206784";
                    break;
                case 1:
                    user += "https://media1.tenor.com/images/70914dd178c949c9f6d887ef3c1f1da4/tenor.gif?itemid=4517373";
                    break;
                case 2:
                    user += "https://media1.tenor.com/images/0861f08d774be11c986629109c380a80/tenor.gif?itemid=11458265";
                    break;
                case 3:
                    user += "https://cdn.discordapp.com/attachments/507803417532694528/593126118459179008/slap-Sk0RmyYvb.gif";
                    break;
                case 4:
                    user += "https://cdn.discordapp.com/attachments/507803417532694528/593127565619625984/slap-SkNimyKvZ.gif";
                    break;
                case 5:
                    user += "https://cdn.discordapp.com/attachments/507803417532694528/593127801192972291/slap-SJx7M0Ft-.gif";
                    break;
                case 6:
                    user += "https://cdn.discordapp.com/attachments/507803417532694528/593127873599242243/slap-SJzT7JKP-.gif";
                    break;
                case 7:
                    user += "https://tenor.com/view/penguins-butt-slap-spank-ooh-penguins-of-madagascar-gif-10549466";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("slap")]
        public async Task RektAsync()
        {
            await ReplyAsync("`You Must Enter a valid user to slap`");

        }



    }
}





