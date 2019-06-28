

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeHistory : ModuleBase
    {
        [Command("meme history")]
        public async Task memeHistoryAsync()
        {
            string user = " For the big-brainers ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://preview.redd.it/69lso70efjk21.jpg?width=640&crop=smart&auto=webp&s=6e55f4f57f3b0ffc4c8cef46cf870a73fc0ce8f0 ";
                    break;
                case 1:
                    user += " https://i.redd.it/0vo2k5u6me821.jpg ";
                    break;
                case 2:
                    user += " https://preview.redd.it/z8mqvx63b0e21.jpg?width=640&crop=smart&auto=webp&s=6294a8a74ea59a44dffbb28f6ac5d6e831fb16b7 ";
                    break;
                case 3:
                    user += " https://preview.redd.it/p7zp4qn2qrc21.jpg?width=640&crop=smart&auto=webp&s=ecd69862a97c21916e63cbb17ffaba45d79ff97a ";
                    break;
                case 4:
                    user += " https://i.redd.it/cx98jnhpe0131.png ";
                    break;
                case 5:
                    user += " https://preview.redd.it/cqmfdp5k0p531.png?width=640&crop=smart&auto=webp&s=26d94ea66fb31691be86268609ac4726ec089308 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/hpjx3bhekl521.jpg?width=640&crop=smart&auto=webp&s=c178ef501265a5b01841e0e40f9d1c175a02c3e0 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/26gi1m7f09f21.jpg?width=640&crop=smart&auto=webp&s=3c153b735ff4cfcbd893c218b5fc70f7426817c6 ";
                    break;
                case 8:
                    user += " https://imgur.com/dZxvLtA ";
                    break;
                case 9:
                    user += " https://i.redd.it/xpqm3xt4mf921.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





