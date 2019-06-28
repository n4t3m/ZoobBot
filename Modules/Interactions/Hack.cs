using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class Hack : ModuleBase
    {
        [Command("hack")]
        public async Task HackAsync([Remainder] string echo)
        {
            string user = "" + echo + " has been hAcKeD!\n";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.giphy.com/media/6OrCT1jVbonHG/giphy.gif";
                    break;
                case 1:
                    user += "https://media.giphy.com/media/hJ2BmdBT1IF7q/giphy.gif";
                    break;
                case 2:
                    user += "https://i.gifer.com/7RS5.gif";
                    break;
                case 3:
                    user += "https://data.whicdn.com/images/57986871/original.gif";
                    break;
                case 4:
                    user += "https://i.pinimg.com/originals/c5/17/b4/c517b4e261b09415335fe133d497b87c.gif";
                    break;
                case 5:
                    user += "https://thumbs.gfycat.com/CompleteSkinnyHuia-size_restricted.gif";
                    break;
                case 6:
                    user += "https://media.giphy.com/media/137EaR4vAOCn1S/giphy.gif";
                    break;
                case 7:
                    user += "https://media.giphy.com/media/xTcnSWYZvafyhEACBO/giphy.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("hack")]
        public async Task RektAsync()
        {
            await ReplyAsync("`That is not a valid (hack-worthy) user! D:`");

        }
    }
}





