

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeDiscord : ModuleBase
    {
        [Command("meme discord")]
        public async Task memeDiscordAsync()
        {
            string user = " _dank._ ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += "https://preview.redd.it/epskxu3zeak21.png?width=640&crop=smart&auto=webp&s=d41dbe2bf3a6979f5ea008b5767bbfcfc01390f1  ";
                    break;
                case 1:
                    user += "https://preview.redd.it/we3ugds3m9921.jpg?width=640&crop=smart&auto=webp&s=d6f530c7ec6b78dd408190db878b33ba3f800422 ";
                    break;
                case 2:
                    user += "https://external-preview.redd.it/nzB0EPSxfF1GbKONNDx2bi9Ze5qloFkVkTiGMUp9AEI.jpg?width=640&crop=smart&auto=webp&s=ef5b5aa55008a811f43a13b3242e35a40925ea25 ";
                    break;
                case 3:
                    user += "https://preview.redd.it/1pdx72nfl9n21.jpg?width=640&crop=smart&auto=webp&s=7ebc7b438372149d5a817a5168a19993a154c6c1 ";
                    break;
                case 4:
                    user += "https://preview.redd.it/4hm1g798eqa11.jpg?width=640&crop=smart&auto=webp&s=6e72e8fda1e0fa91e038604692eb37539342f88a ";
                    break;
                case 5:
                    user += "https://preview.redd.it/w9oh4o2g5ci21.jpg?width=640&crop=smart&auto=webp&s=38f0f9c009569b130848ef9d7f70754bc3cb8581";
                    break;
                case 6:
                    user += "https://preview.redd.it/3vde6k6t0yk21.jpg?width=640&crop=smart&auto=webp&s=8bdee238fd68f45a4403e88fe9b03e46a9db8399 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/pkbqnnhrrv821.png?width=640&crop=smart&auto=webp&s=0355a7279a613e085b3990b95bf812c804eebb04 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/hiouph77kkw21.png?width=640&crop=smart&auto=webp&s=21d10da8c8892ab794ded86a2107c0b26b920928";
                    break;
                case 9:
                    user += "https://i.ytimg.com/vi/3WcG34XUo9E/hqdefault.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





