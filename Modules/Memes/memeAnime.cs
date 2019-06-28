

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class memeAnime : ModuleBase
    {
        [Command("meme anime")]
        public async Task MemeAnimeAsync()
        {
            string user = " Uwu!~ ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://i.redd.it/ix4p3x722ls21.png ";
                    break;
                case 1:
                    user += " https://preview.redd.it/d4suwlts1y221.png?width=640&crop=smart&auto=webp&s=989c68f2e5ca7c5b527da30fb17f9716bd40e600 ";
                    break;
                case 2:
                    user += " https://preview.redd.it/oze99o5m7c631.jpg?width=640&crop=smart&auto=webp&s=ab7e68f401d41e4e46a4183f59c8efc81127c07c ";
                    break;
                case 3:
                    user += " https://preview.redd.it/f2l3r8blvo331.jpg?width=640&crop=smart&auto=webp&s=0c2158f03f8426a8bd503d82ded66875e5765c3a ";
                    break;
                case 4:
                    user += " https://preview.redd.it/q9o1awxiae031.jpg?width=640&crop=smart&auto=webp&s=1440586fe50027500f7a1860470b5efe14e11253 ";
                    break;
                case 5:
                    user += " https://preview.redd.it/aqpcj84wsbe21.png?width=640&crop=smart&auto=webp&s=d0a133153e9f1bd2ee7e562550307dd7c0836f57 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/o2j2g8fpixj21.jpg?width=640&crop=smart&auto=webp&s=7dc4dee69df5e5991b4d6ed6d7582f314682606b ";
                    break;
                case 7:
                    user += " https://preview.redd.it/kntra7bvg1a21.png?width=640&crop=smart&auto=webp&s=626b693d3cfbd038841259af9bfe8579438c0341 ";
                    break;
                case 8:
                    user += " https://external-preview.redd.it/mDuWePyqkleZA0x2LIxzhkZy_VvTfLR4rsyExK2TiAo.png?width=640&crop=smart&auto=webp&s=efd892572968705570fa137c612f53877e08d2b7 ";
                    break;
                case 9:
                    user += " https://i.ytimg.com/vi/hNfA7bAPZxA/maxresdefault.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





