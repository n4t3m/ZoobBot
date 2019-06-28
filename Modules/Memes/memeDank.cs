

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeDank : ModuleBase
    {
        [Command("meme dank")]
        public async Task memeDankAsync()
        {
            string user = " Definitely dank ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://preview.redd.it/87ufbmuwzdw21.png?width=640&crop=smart&auto=webp&s=07ff25803b4d92664cc01294c5d16e46a930019e ";
                    break;
                case 1:
                    user += " https://preview.redd.it/3nqbihfosuo21.jpg?width=640&crop=smart&auto=webp&s=b587ba5e664982438a6ea1c4d92500a7ca6ecb18 ";
                    break;
                case 2:
                    user += " https://preview.redd.it/hr2kdk49pjh21.jpg?width=640&crop=smart&auto=webp&s=8af0b4accecd7ad6e03f29ae77dd218e966680ba ";
                    break;
                case 3:
                    user += " https://preview.redd.it/2x4tu0x9nmv21.jpg?width=640&crop=smart&auto=webp&s=9ff2309274552043bfffc9347d99bfd45b02de21 ";
                    break;
                case 4:
                    user += " https://preview.redd.it/9q7r48kd2dh21.jpg?width=960&crop=smart&auto=webp&s=f03b882cd22fe558554ca01413718fe7950618df ";
                    break;
                case 5:
                    user += " https://preview.redd.it/f1mbmhlzgb131.jpg?width=960&crop=smart&auto=webp&s=650f3223986096c8a2bbe691d50a61c4ce3962e2 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/pba4v7ouhcy21.png?width=640&crop=smart&auto=webp&s=b275d46206cc222222fee762ac1bb6cd191887d7 ";
                    break;
                case 7:
                    user += " https://i.redd.it/dmjd4i3wa5e21.jpg ";
                    break;
                case 8:
                    user += " https://preview.redd.it/o0xgcuhxjb531.jpg?width=960&crop=smart&auto=webp&s=74bc3197f293e6c0a7603c41b7deed9e105919e0 ";
                    break;
                case 9:
                    user += " https://i.redd.it/9dkgbezmi3531.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





