using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Lick : ModuleBase
    {
        [Command("lick")]
        public async Task LickAsync([Remainder] string echo)
        {
            string user = "" + echo + " just got licked!!!! owo ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.giphy.com/media/DNkYWBa2GfCPC/giphy.gif"; ;
                    break;
                case 1:
                    user += "https://media1.tenor.com/images/c4f68fbbec3c96193386e5fcc5429b89/tenor.gif";
                    break;
                case 2:
                    user += "https://i.kym-cdn.com/photos/images/original/000/995/417/60f.gif";
                    break;
                case 3:
                    user += "https://thumbs.gfycat.com/GeneralFarBuckeyebutterfly-size_restricted.gif";
                    break;
                case 4:
                    user += "https://media.giphy.com/media/5cREBFcGOkC2I/giphy.gif";
                    break;
                case 5:
                    user += "https://media1.tenor.com/images/f5e29ec1906958125d443abddc6c1902/tenor.gif";
                    break;
                case 6:
                    user += "https://i.kym-cdn.com/photos/images/original/001/145/832/ed1.gif";
                    break;
                case 7:
                    user += "https://media.giphy.com/media/RQ7jEZTiuNRV6/giphy.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("poke")]
        public async Task RektAsync()
        {
            await ReplyAsync("`That is not a valid (lick-worthy) user! D:`");

        }
    }
}





