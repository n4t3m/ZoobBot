

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeGarfield : ModuleBase
    {
        [Command("meme garfield")]
        public async Task memeGarfieldAsync()
        {
            string user = " *I am Sorry Jon*\n ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://i.ytimg.com/vi/fC_npX4fsjk/hqdefault.jpg ";
                    break;
                case 1:
                    user += " https://preview.redd.it/i9v64swuzp631.jpg?width=640&crop=smart&auto=webp&s=a816d36082531a221163a81b5a29d45af8b73c6f ";
                    break;
                case 2:
                    user += " https://preview.redd.it/556kpn993k631.png?width=640&crop=smart&auto=webp&s=e2ef3560db29be6b26f09e0073ce2e176728adc0 ";
                    break;
                case 3:
                    user += " https://preview.redd.it/x8b68icukn631.jpg?width=640&crop=smart&auto=webp&s=e889567201cda3a773846ea437ad213bd65db93d ";
                    break;
                case 4:
                    user += " https://preview.redd.it/qme897bod6431.png?width=640&crop=smart&auto=webp&s=712c9ecd65790ef5de61763e15068953fa33e640 ";
                    break;
                case 5:
                    user += " https://preview.redd.it/pwb0pc60r6231.jpg?width=640&crop=smart&auto=webp&s=45819d4f22b3ac1f9c4753216b94a64c65d175a3 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/vg1pxvhq2sz21.jpg?width=640&crop=smart&auto=webp&s=19f8d12cc820684ae085c7427b057a12e79f1845 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/j1gcxez8ox131.jpg?width=640&crop=smart&auto=webp&s=5d59c68ab29a56ea761a2bbb5a022c05dcc8c6a1 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/kb21uzz9wr031.jpg?width=640&crop=smart&auto=webp&s=31dd30ff0ea5556ed3687a31a0261f23ec05ed13 ";
                    break;
                case 9:
                    user += " https://imgur.com/gallery/1cZoyFU ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





