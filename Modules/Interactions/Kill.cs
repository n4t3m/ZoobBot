

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Kill : ModuleBase
    {
        [Command("kill")]
        public async Task KillAsync([Remainder] string echo)
        {
            string user = "" + echo + " has been killed. ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://gifimage.net/wp-content/uploads/2017/09/anime-kill-gif.gif"; ;
                    break;
                case 1:
                    user += "https://image.myanimelist.net/ui/OK6W_koKDTOqqqLDbIoPAqAL7aLc1CsrqkPLU0FGwlg";
                    break;
                case 2:
                    user += "https://i.gifer.com/Jsg.gif";
                    break;
                case 3:
                    user += "https://i.giphy.com/media/vlxoP09DNc8QU/giphy.webp";
                    break;
                case 4:
                    user += "https://thumbs.gfycat.com/InferiorGentleDoctorfish-small.gif";
                    break;
                case 5:
                    user += "https://thumbs.gfycat.com/SimplisticMadeupGander-size_restricted.gif";
                    break;
                case 6:
                    user += "https://i.giphy.com/media/zv3wgk0j5Bz2M/giphy.webp";
                    break;
                case 7:
                    user += "https://media1.tenor.com/images/45bfaa7338d566d6cd0e0911af8162c0/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("kill")]
        public async Task KillAsync()
        {
            await ReplyAsync("`That is not a valid (lick-worthy) user! D:`");

        }
    }
}





