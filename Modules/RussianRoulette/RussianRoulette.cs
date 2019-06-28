using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class RussianRoulette : ModuleBase
    {
        [Command("Ply_Rus")]
        public async Task Ply_Rus(SocketGuildUser mention, string num = null)
        {
            String reason = "";
            var UpperBounds = Int32.Parse(num);
            UpperBounds = UpperBounds + 1;
            int bullet = new Random().Next(0, UpperBounds);
            if (bullet == 1)
            {
                var channel = await mention.GetOrCreateDMChannelAsync();
                await channel.SendMessageAsync(reason == null ? $"You've been kicked from {Context.Guild.Name}. You've died in a game of Russian Roulette." : $"You've been kicked from {Context.Guild.Name}. You've died in a game of Russian Roulette. Return if you dare.");
                await Task.Delay(2000);
                await mention.KickAsync();

                await ReplyAsync(reason == null ? $"{mention.Username} died." : $"{ mention.Username} died");
            }
            else
            {
                await ReplyAsync(reason == null ? $"{mention.Username} has survived" : $"{mention.Username} has survived");
            }

        }




    }
}
