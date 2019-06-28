using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Kiss : ModuleBase
    {
        [Command("kiss")]
        public async Task KissAsync([Remainder] string echo)
        {
            string user = "" + echo + " has been kissed! ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.tenor.com/images/39fe167bdab90223bcc890bcb067b761/tenor.gif";
                    break;
                case 1:
                    user += "https://media.tenor.com/images/c674ba98c40f6793eaf10a1356c1c36a/tenor.gif";
                    break;
                case 2:
                    user += "https://media.tenor.com/images/7709345e06d06256965591bcce4d8e38/tenor.gif";
                    break;
                case 3:
                    user += "https://tenor.com/view/anime-sword-art-online-sao-gif-13862432";
                    break;
                case 4:
                    user += "https://media.tenor.com/images/c7abe0981045a2241ae24bb9dcb7ab8f/tenor.gif";
                    break;
                case 5:
                    user += "https://media.tenor.com/images/7333cc9f6751611ea06874ef8f654cb1/tenor.gif";
                    break;
                case 6:
                    user += "https://media.tenor.com/images/4b75a7e318cb515156bb7bfe5b3bbe6f/tenor.gif";
                    break;
                case 7:
                    user += "https://media.tenor.com/images/26aaa1494b424854824019523c7ba631/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("kiss")]
        public async Task RektAsync()
        {
            await ReplyAsync("`You Must Enter a valid user to kiss!`");

        }
    }
}





