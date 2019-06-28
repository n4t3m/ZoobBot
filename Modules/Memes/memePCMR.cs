

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memePCMR : ModuleBase
    {
        [Command("meme pcmr")]
        public async Task memePCMRAsync()
        {
            string user = " **PC IS THE BEST** ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += "https://preview.redd.it/zaark51onkq11.jpg?width=640&crop=smart&auto=webp&s=b182c1cf6f1e448ef58538b703db1bfb81f548a5 ";
                    break;
                case 1:
                    user += "https://preview.redd.it/01rsih96j0921.jpg?width=640&crop=smart&auto=webp&s=636e6c6f42f9a635a0947a0f48768fdd202fdafe ";
                    break;
                case 2:
                    user += " https://preview.redd.it/k39n91ja9ei21.png?width=640&crop=smart&auto=webp&s=aa899475bc04e5b9a612e1f908f18d1c360f477c ";
                    break;
                case 3:
                    user += " https://external-preview.redd.it/p2GBkHbfsCCbK3xqLvqmZORytHGSychauq0NBRm7osk.jpg?width=640&crop=smart&auto=webp&s=13a11d170b69b2b9403e9cfadae9813d2668206c ";
                    break;
                case 4:
                    user += " https://external-preview.redd.it/44PafFE41Tx3sX0MwRkvVesJpd-d7oY9xPhcxwM7Q9s.jpg?width=640&crop=smart&auto=webp&s=8121ee78396d8956c37bbd4b2ee1b1b899e3693d ";
                    break;
                case 5:
                    user += " https://preview.redd.it/pbg62s7q1c631.jpg?width=640&crop=smart&auto=webp&s=cdb541687188aca85c19e78b1b81ae6593cc443b";
                    break;
                case 6:
                    user += " https://preview.redd.it/5vp06u5qo6l21.jpg?width=640&crop=smart&auto=webp&s=7c642c9ec87c7923d62a3b421b1600069eb42d1a ";
                    break;
                case 7:
                    user += " https://i.redd.it/voiw7vrxief01.jpg ";
                    break;
                case 8:
                    user += " https://preview.redd.it/wjiqbbyxuns21.png?width=640&crop=smart&auto=webp&s=aaadf37fc6da7d6a7e00418fe58914968f1f0625 ";
                    break;
                case 9:
                    user += " https://preview.redd.it/7nhzh1l2jzz21.jpg?width=640&crop=smart&auto=webp&s=514894cb40f7780cc16b799e17e2885a41689c4d ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





