

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Dab : ModuleBase
    {
        [Command("dab")]
        public async Task DabAsync()
        {
            string user = "You do a *dab*!\n";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.giphy.com/media/A4R8sdUG7G9TG/giphy.gif"; ;
                    break;
                case 1:
                    user += "https://media1.tenor.com/images/d81af8d4f0a919c7b40e050de47e6eaf/tenor.gif";
                    break;
                case 2:
                    user += "https://media1.tenor.com/images/9b2147e6ad5a8c7f0ae0f39d37230a56/tenor.gif";
                    break;
                case 3:
                    user += "https://static.wixstatic.com/media/391e8b_2048ba790e294870b96bcbee5c846910~mv2.gif";
                    break;
                case 4:
                    user += "https://66.media.tumblr.com/85d88d04cdb4a46f6bfbdce34e80e357/tumblr_pjvtxi09Ik1w0433po1_400.gif";
                    break;
                case 5:
                    user += "https://media1.tenor.com/images/d13c16a8853e3b309db0ec7e573c4c94/tenor.gif";
                    break;
                case 6:
                    user += "http://pa1.narvii.com/6292/502cb42cc86c3dfe7502149466d2978859e3b6ca_00.gif";
                    break;
                case 7:
                    user += "https://media.tenor.com/images/d68b5deb35e8c7ffad2efd182e0d4122/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }

    }
}





