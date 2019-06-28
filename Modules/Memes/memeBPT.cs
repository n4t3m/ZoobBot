

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class BPT : ModuleBase
    {
        [Command("meme bpt")]
        public async Task memeBPTAsync()
        {
            string user = "*BPT GANG* ";

            int part1 = new Random().Next(0, 11);

            switch (part1)
            {
                case 0:
                    user += "https://i.redd.it/5j9pzzsg3m631.jpg";
                    break;
                case 1:
                    user += "https://i.redd.it/u5le7n73hq631.jpg";
                    break;
                case 2:
                    user += "https://i.redd.it/5a723mlotq631.jpg";
                    break;
                case 3:
                    user += "https://i.redd.it/m1inf6fwmq631.jpg";
                    break;
                case 4:
                    user += "https://i.redd.it/8sae1dhfcm631.jpg";
                    break;
                case 5:
                    user += "https://i.redd.it/rpfmqhkxrq631.jpg";
                    break;
                case 6:
                    user += "https://i.redd.it/wwgw16cvgr631.jpg";
                    break;
                case 7:
                    user += "https://i.redd.it/8sz6q5ilia631.jpg";
                    break;
                case 8:
                    user += "https://i.redd.it/h2et37u2im531.jpg";
                    break;
                case 9:
                    user += "https://i.redd.it/qx8tzoj2g0631.jpg";
                    break;
                case 10:
                    user += "https://i.redd.it/3p90t6dmkp531.jpg";
                    break;
            }
            await ReplyAsync(user + "");

        }



    }
}





