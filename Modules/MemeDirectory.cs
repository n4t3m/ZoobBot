using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class MemeDirectory : ModuleBase
    {
        
        [Command("memelist")]
        [Alias("meme list", "meme directory")]
        public async Task MemeList()
        {
            await ReplyAsync($"**Zoob Bot Memes List**\n" +
                $"Dank\n" +
                $"Memes\n" +
                $"Wholesome\n" +
                $"History\n" +
                $"DeepFried\n" +
                $"HydroHomies\n" +
                $"Me_irl\n" +
                $"Anime\n" +
                $"Garfield\n" +
                $"PCMR\n" +
                $"Discord\n" +
                $"SocialAnxiety\n" +
                $"WPT\n" +
                $"BPT\n" +
                $"phcomments (Pornhub Comments)\n" +
                $"awww\n");
        }

    }
}
