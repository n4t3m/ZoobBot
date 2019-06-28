

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class WPT : ModuleBase
    {
        [Command("meme wpt")]
        public async Task MemeWPTAsync()
        {
            string user = "*WPT GANG* ";

            int part1 = new Random().Next(0, 11);

            switch (part1)
            {
                case 0:
                    user += "https://i.redd.it/nuvlf1vfpr631.jpg";
                    break;
                case 1:
                    user += "https://i.redd.it/qf7k358fkl631.jpg";
                    break;
                case 2:
                    user += "https://external-preview.redd.it/7mKwiJ1jCarnW5-yecSCbSjLFotVemGm8O8T_tXKedk.jpg?auto=webp&s=ce908442016d6a43ebe5f72eb36f29b0ea863308";
                    break;
                case 3:
                    user += "https://i.redd.it/gx7b45czqr631.jpg";
                    break;
                case 4:
                    user += "https://i.redd.it/84njpni37r631.jpg";
                    break;
                case 5:
                    user += "https://i.redd.it/e2ombkjh7k631.jpg";
                    break;
                case 6:
                    user += "https://i.redd.it/62tc5bvl5e631.jpg";
                    break;
                case 7:
                    user += "https://i.redd.it/mp6w000amb631.png";
                    break;
                case 8:
                    user += "https://i.redd.it/xy6kuic9mr631.jpg";
                    break;
                case 9:
                    user += "https://i.redd.it/2d65g2lnhq631.jpg";
                    break;
                case 10:
                    user += "https://i.redd.it/srrery43po631.png";
                    break;
            }
            await ReplyAsync(user + "");

        }



    }
}





