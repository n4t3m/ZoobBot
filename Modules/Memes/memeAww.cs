

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class memeAwwwDiscord : ModuleBase
    {
        [Command("meme awww")]
        public async Task AwwAsync()
        {
            string user = "Awwww!\n ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += "https://i.imgur.com/uUOwoQU.jpg";
                    break;
                case 1:
                    user += "https://preview.redd.it/psoryq2wvhm21.jpg";
                    break;
                case 2:
                    user += "https://external-preview.redd.it/Z7jFJ9KC3SrmDIia7IgwXB1C83guhjB3a59idE5-Eic.jpg";
                    break;
                case 3:
                    user += "https://external-preview.redd.it/a6ynFz_86YNeM2-I3e3XDaakn5lJL48RQN2zVeoqik8.jpg";
                    break;
                case 4:
                    user += "https://external-preview.redd.it/LgcI_DQqDQ3cNFIawnDH0PJ49cziSGvRDdXNxu__NAs.jpg";
                    break;
                case 5:
                    user += "https://preview.redd.it/fxqfz6w62v821.jpg";
                    break;
                case 6:
                    user += "https://i.redd.it/1lz2ulmmaej21.jpg";
                    break;
                case 7:
                    user += "https://i.redd.it/0l78k9pfu6d21.jpg";
                    break;
                case 8:
                    user += "https://preview.redd.it/un44882dvyj21.jpg";
                    break;
                case 9:
                    user += "https://preview.redd.it/g9w2q9iq3ok11.jpg";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





