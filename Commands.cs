using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Commands : ModuleBase
    {
        [Command("ping")]
        public async Task Ping()
        {
            var msg = await ReplyAsync("***Calculating ping...***");
            await ReplyAsync($"Pong! ***{msg.Timestamp.Millisecond - DateTime.Now.Millisecond}***ms");
            await msg.DeleteAsync();
        }

        [Command("kick")]
        public async Task Kick(SocketGuildUser mention, string reason = null)
        {
            if (mention != null)
            {
                var channel = await mention.GetOrCreateDMChannelAsync();

                await channel.SendMessageAsync(reason == null ? $"You've been kicked from {Context.Guild.Name} for no reason." : $"You've been kicked from {Context.Guild.Name} for the reason {reason}.");
                await Task.Delay(2000);
                await mention.KickAsync();

                await ReplyAsync(reason == null ? $"I've successfully kicked the user {mention.Username} for no reason." : $"I've successfully kicked the user { mention.Username} for the reason {reason}.");

            }
            else
            {

            }
        }

        [Command("ban")]
        public async Task Ban(SocketGuildUser mention, string reason = null)
        {
            if (mention != null)
            {
                var channel = await mention.GetOrCreateDMChannelAsync();

                await channel.SendMessageAsync(reason == null ? $"You've been banned from {Context.Guild.Name} for no reason." : $"You've been banned from {Context.Guild.Name} for the reason {reason}.");
                await Task.Delay(2000);
                await mention.BanAsync();

                await ReplyAsync(reason == null ? $"I've successfully banned the user {mention.Username} for no reason." : $"I've successfully banned the user { mention.Username} for the reason {reason}.");

            }
            else
            {

            }
        }

        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync($"**Zoob Bot Commnands List\n" +
                $"!ping : Checks Zoom Bot's Ping.\n" +
                $"!info : Provides Information About Zoom Bot\n" +
                $"!kick : Kicks a user from the server.\n" +
                $"!ban  : Bans a user from the server.\n" +
                $"!copypasta : Shows a list of copypastas. Open a copypasta by typing !copypasta <name of copypasta> **Make sure the letters are lowercase!\n" +
                $"!kiss <user> : Kiss a friend!\n" +
                $"!slap <user> : Slaps a bruh!\n" +
                $"!hug <user> : Hugs a friend!\n" +
                $"!poke <user> : Pokes a dood!\n");
        }

    }
}
