

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeDeepFried : ModuleBase
    {
        [Command("meme deepfried")]
        public async Task memeDeepFriedAsync()
        {
            string user = " Memes drowned in the deep fryer. ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://preview.redd.it/8lst980ibs531.jpg?width=640&crop=smart&auto=webp&s=614c9d07b56db9f858dc47048670e5faba523b64 ";
                    break;
                case 1:
                    user += " https://preview.redd.it/2wnk03hbq2411.jpg?width=640&crop=smart&auto=webp&s=38cfbbe0b430a4f93f4dc441eb8948917fb3d5dd ";
                    break;
                case 2:
                    user += " https://preview.redd.it/pay4s41lrnt21.jpg?width=640&crop=smart&auto=webp&s=6bb20ab5e6f10cae8cdb56b43ab36db8c713b863 ";
                    break;
                case 3:
                    user += " https://preview.redd.it/yjgufvef7f721.jpg?width=640&crop=smart&auto=webp&s=8fa63b7cd530925f1718d4543394e0d6003a433a ";
                    break;
                case 4:
                    user += " https://preview.redd.it/q32pgj6838q21.jpg?width=640&crop=smart&auto=webp&s=7547d6294dc33b7616d93ec1129b94ddd8a6797b ";
                    break;
                case 5:
                    user += " https://preview.redd.it/vhag0n0hbv521.jpg?width=640&crop=smart&auto=webp&s=56b2869f4a20600f8c160c6452a54cb553b81877 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/ytdn5uokb0j11.jpg?width=640&crop=smart&auto=webp&s=715dd902b92cfb9cf6f634752056466ac92cdf56 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/lvxbhhy3q9u11.jpg?width=640&crop=smart&auto=webp&s=cac20839554f8420ca25a7bcb4405da430a5bef2 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/nqr45k9wvys11.jpg?width=640&crop=smart&auto=webp&s=9c785537b7b783e666c31f66e0ae322581c5c71c ";
                    break;
                case 9:
                    user += " https://preview.redd.it/00tupgu1fos21.jpg?width=640&crop=smart&auto=webp&s=53ae42f4a34eb8fca0a53fedba844e54725e8cff ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





