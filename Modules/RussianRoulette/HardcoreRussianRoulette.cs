using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class HardcoreRussianRoulette : ModuleBase
    {
        [Command("HPly_Rus")]
        public async Task HPly_Rus(SocketGuildUser mention, string num = null)
        {
            String reason = "";
            int bullet = new Random().Next(0, 7);
            if (Context.User.Username == mention.Username)
            {

                if (bullet == 1)
                {
                    var channel = await mention.GetOrCreateDMChannelAsync();
                    await channel.SendMessageAsync(reason == null ? $"You've been banned from {Context.Guild.Name} for losing a game of Russian Roulette." : $"You've been banned from {Context.Guild.Name} for losing a gqame of Russian Roulette.");
                    await Task.Delay(2000);
                    await mention.BanAsync();

                    await ReplyAsync(reason == null ? $"{mention.Username} died." : $"{ mention.Username} died");
                }
                else
                {
                    await ReplyAsync(reason == null ? $"{mention.Username} has survived" : $"{mention.Username} has survived");
                }
            }
            else
            {
                await ReplyAsync(reason == null ? $"{Context.User.Username} you can't shoot someone. Thats illegal." : $"{Context.User.Username} you can't shoot someone. Thats illegal.");
            }
        }




    }
}