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
        [Alias("meme list")]
        public async Task MemeList()
        {
            await ReplyAsync($"**Zoob Bot Memes List**\n" +
                $"Dank Memes\n" +
                $"Memes\n" +
                $"Wholesome\n" +
                $"History\n" +
                $"DeepFried\n" +
                $"HydroHomies\n" +
                $"MeIRL\n" +
                $"Anime\n" +
                $"Garfield\n" +
                $"PCMR\n" +
                $"Discord\n");
        }

    }
}
