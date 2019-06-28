

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeMe_irl : ModuleBase
    {
        [Command("meme me_irl")]
        public async Task memeMeIRLAsync()
        {
            string user = " _Selfies of the soul_ ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://preview.redd.it/2rp4nazmt4021.jpg?width=640&crop=smart&auto=webp&s=5d26cbc9fb2085c615f5f32bd87a4abe9fa58c3b ";
                    break;
                case 1:
                    user += " https://i.redd.it/avuep95dtct11.jpg ";
                    break;
                case 2:
                    user += " https://preview.redd.it/pz9hawp7lo801.jpg?width=640&crop=smart&auto=webp&s=cd97217f19e53e304b21e2e363512290e2cd833e ";
                    break;
                case 3:
                    user += " https://preview.redd.it/x364exhxph631.jpg?width=640&crop=smart&auto=webp&s=c0bba133a97aab1ac2cf8f348f7503e9b367bd99 ";
                    break;
                case 4:
                    user += " https://preview.redd.it/r5md6hhw53n21.jpg?width=640&crop=smart&auto=webp&s=3cf67a1dd6b3be32c1a826cac595be70335a7b9a ";
                    break;
                case 5:
                    user += " https://preview.redd.it/zz9bnuaqg6l21.png?width=640&crop=smart&auto=webp&s=74f39b6757a2681d235c680c94d171d840df3bb6 ";
                    break;
                case 6:
                    user += " https://external-preview.redd.it/Vg1NIi6aoZZBVo3vwZN_GVH3pdOz56z7ZME-A9zhVa0.png?auto=webp&s=f2f429c10888c08a8232c7762c31aedf4079ee32 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/ictjfm10uj231.jpg?width=640&crop=smart&auto=webp&s=fed14edf82f038fd4a3b6e185bb494ad80a9ed40 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/jaxzxqw1uz021.jpg?width=640&crop=smart&auto=webp&s=70d3f914d785d9297b9d980b92bdd9d8f215f200 ";
                    break;
                case 9:
                    user += " https://i.redd.it/tkw2g97pgvl21.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





