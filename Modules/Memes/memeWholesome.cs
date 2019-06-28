

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeWholesome : ModuleBase
    {
        [Command("meme wholesome")]
        public async Task memWholesomeAsync()
        {
            string user = " (> ^-^ )>~~~ <3 ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://i.redd.it/5wyehherasv11.jpg ";
                    break;
                case 1:
                    user += " https://preview.redd.it/vldvdxp8zjz11.jpg?width=640&crop=smart&auto=webp&s=1c84614a715b0622f176bae18072d90d702fc814 ";
                    break;
                case 2:
                    user += " https://preview.redd.it/e2sp8gx4mxi21.jpg?width=640&crop=smart&auto=webp&s=bbe629c3dddd17a4cd968f95203de24f48f8014e ";
                    break;
                case 3:
                    user += " https://preview.redd.it/075f5q0f9vu21.jpg?width=640&crop=smart&auto=webp&s=8715797d6e99180bce01b800a433b992b4259259 ";
                    break;
                case 4:
                    user += " https://preview.redd.it/eacemuyjfi231.jpg?width=640&crop=smart&auto=webp&s=c54a40e184f8f4c31cec3b642cd8e7ec1fb12ae3 ";
                    break;
                case 5:
                    user += " https://preview.redd.it/g2uhrlvji0y11.jpg?width=640&crop=smart&auto=webp&s=142d7f4c79bd4e9ee1ffde3521075a73038a8191 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/9662gteeukj21.jpg?width=640&crop=smart&auto=webp&s=2c583617ba36e75f03cde565598597aff42bd69c ";
                    break;
                case 7:
                    user += " https://preview.redd.it/3ttko3ylnvc01.jpg?width=640&crop=smart&auto=webp&s=16f2f54fb77c52496f941a1c93ec42d0b1f91252 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/m78csxbblqj21.jpg?width=640&crop=smart&auto=webp&s=2b14a9e4bc3eef66738e3c70091e23d13e34ce7d ";
                    break;
                case 9:
                    user += " https://preview.redd.it/5vfoqqc6aar21.jpg?width=640&crop=smart&auto=webp&s=ae73d1ca0027614733e780946f3e2e48d0cdd938 ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





