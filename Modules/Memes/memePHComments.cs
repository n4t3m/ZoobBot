

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class phComments : ModuleBase
    {
        [Command("meme phcomments")]
        public async Task PHCommentsAsync()
        {
            string user = "*juicy*\n";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += "https://i.redd.it/2gwtsoeaes631.jpg";
                    break;
                case 1:
                    user += "https://i.redd.it/dqoc9nmwcn631.jpg";
                    break;
                case 2:
                    user += "https://i.redd.it/lfr6lmbyan631.jpg";
                    break;
                case 3:
                    user += "https://i.redd.it/fnlznhlv2q631.jpg";
                    break;
                case 4:
                    user += "https://i.redd.it/9elka5lndn631.jpg";
                    break;
                case 5:
                    user += "https://i.redd.it/lkxzpdcgdn631.jpg";
                    break;
                case 6:
                    user += "https://preview.redd.it/54qqiphpxn631.jpg";
                    break;
                case 7:
                    user += "https://external-preview.redd.it/cqzaY9znYQLJmSuLnQI0ofHRlTlCKx5VfCpo6YF1LvY.jpg";
                    break;
                case 8:
                    user += "https://preview.redd.it/95dkepnf5p631.jpg";
                    break;
                case 9:
                    user += "https://preview.redd.it/zz1a3zlafr631.jpg";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





