

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeMemes : ModuleBase
    {
        [Command("meme normie")]
        public async Task memeNormieAsync()
        {
            string user = " The default collection ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://preview.redd.it/4tmvornxuyi21.jpg?width=640&crop=smart&auto=webp&s=fd24b633155942f902e0629255a5c2e284211478 ";
                    break;
                case 1:
                    user += " https://preview.redd.it/z3un0qtxa4331.jpg?width=640&crop=smart&auto=webp&s=12ba4a152be631bdabd3b46c98bd89e82f91639d ";
                    break;
                case 2:
                    user += " https://preview.redd.it/7q922vtlbfq21.jpg?width=640&crop=smart&auto=webp&s=cb9b57c059e75aba51f16633768192d2a0b97c97 ";
                    break;
                case 3:
                    user += " https://preview.redd.it/oiqysa28dx131.jpg?width=640&crop=smart&auto=webp&s=d6c99d79b7544de05f4571122337b0f101e1ce0e ";
                    break;
                case 4:
                    user += " https://preview.redd.it/txgo9qmvd0f21.jpg?width=640&crop=smart&auto=webp&s=9fa862f56bafcd5128fa69e8efeb2df3d213bc1d ";
                    break;
                case 5:
                    user += " https://preview.redd.it/q5plki7lqe431.jpg?width=640&crop=smart&auto=webp&s=327901e95a1f77495d8e8c639705f84ee8282c9f ";
                    break;
                case 6:
                    user += " https://preview.redd.it/4g19cur6f3531.jpg?width=640&crop=smart&auto=webp&s=e8a50ab5400ff1802e42b0337f46e81b2e910099 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/n09weillijl21.jpg?width=640&crop=smart&auto=webp&s=874b6c76aa7fddef72de98bc701a3aa01ed13095 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/s2692nr8jp131.jpg?width=640&crop=smart&auto=webp&s=b923d8b7cc2409bf6b97be723672a9c81dcc6a18 ";
                    break;
                case 9:
                    user += " https://preview.redd.it/wlfvzaftdtm21.jpg?width=640&crop=smart&auto=webp&s=6b07d830421190e6e36106a0f1c4b8df011e8151 ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





