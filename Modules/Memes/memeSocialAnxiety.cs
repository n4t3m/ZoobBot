

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class SocialAnxiety : ModuleBase
    {
        [Command("meme socialanxiety")]
        public async Task SocialAnxietyMemes()
        {
            string user = "*WPT GANG* ";

            int part1 = new Random().Next(0, 11);

            switch (part1)
            {
                case 0:
                    user += "https://i.redd.it/7andvj7kg4711.jpg";
                    break;
                case 1:
                    user += "https://i.redd.it/5y800xnxl2121.jpg";
                    break;
                case 2:
                    user += "https://i.redd.it/x65b41wmr4j11.jpg";
                    break;
                case 3:
                    user += "https://i.redd.it/vl2b70r4n6k21.png";
                    break;
                case 4:
                    user += "https://i.redd.it/jj551h1pl6531.jpg";
                    break;
                case 5:
                    user += "https://i.redd.it/xh58rj5zkx231.jpg";
                    break;
                case 6:
                    user += "https://i.redd.it/cr62j14phr631.jpg";
                    break;
                case 7:
                    user += "https://i.redd.it/mhef00s7qo631.png";
                    break;
                case 8:
                    user += "https://img.buzzfeed.com/buzzfeed-static/static/2017-03/20/19/asset/buzzfeed-prod-fastlane-03/anigif_sub-buzz-9915-1490051424-3.gif";
                    break;
                case 9:
                    user += "https://i.chzbgr.com/full/8455219712/h1253FC82/";
                    break;
                case 10:
                    user += "https://i.redd.it/7l6f89kcsnv21.png";
                    break;
            }
            await ReplyAsync(user + "");

        }



    }
}





