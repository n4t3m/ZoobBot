using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        [Command("shout")]
        public async Task Shout(string phrase)
        {
            String str = phrase.ToUpper();
            await ReplyAsync($"" + str);
        }

        [Command("whisper")]
        public async Task Whisper(string phrase)
        {
            String str = phrase.ToLower();
            await ReplyAsync($"" + str);
        }

        [Command("getzoobbot")]
        public async Task GetZoobBot()
        {
            await ReplyAsync($"Want to add **ZOOB BOT** to your server? Welllllll now you can! Click this link to add Zoob: https://discordapp.com/oauth2/authorize?client_id=592952933327437828&scope=bot&permissions=8");
        }


        [Command("owo")]
        public async Task OWO(string phrase)
        {
            String str = phrase.Replace("r", "w");
            str = str.Replace("l", "w");
            await ReplyAsync($"*" + str + " uwu*");
        }

        [Command("MarryMeWith")]
        public async Task MarryMe(SocketGuildUser mention, string num = null)
        {
            String reason =  "";
            await ReplyAsync(reason == null ? $"{mention.Username} You are now married to {Context.User.Username}." : $"{mention.Username} You are now married to {Context.User.Username}.");


        }

        [Command("botinfo")]
        [Alias("binfo")]
        public async Task Info()
        {
            var botUser = Context.Client.CurrentUser;

            var embedBuilder = new EmbedBuilder()
                .WithTitle("__About me__")
                .WithDescription("Welcome to Zoob Bot. Zoob Bot is a bot made for Discord Hack Week 2019 and features 500 commands for shitty memes, jokes, and pop culture references.")
                .WithColor(100, 180, 255)
                .WithThumbnailUrl(botUser.GetAvatarUrl(size: 64))
                .AddField("Want to know what commands?", $"Type !help for more information about our hundreds of commands.")
                .AddField("Who?", " [Zoob Bot](https://github.com/NateM135/ZoobBot \"GitHub\") is made by Nathan Melwani, Patrick Aveninto, Jinsu Hwang, and Aurora Yin.");

            await ReplyAsync("", embed: embedBuilder.Build());
        }


        [Command("say")]
        public async Task Say(string choice)
        {

            await ReplyAsync("*" + choice + "*");

        }
    


    [Command("help")]
        public async Task Help()
        {
            await ReplyAsync($"**Zoob Bot Commnands List**\n" +
                $"!ping : Checks Zoom Bot's Ping.\n" +
                $"!info : Provides Information About Zoom Bot\n" +
                $"!kick : Kicks a user from the server.\n" +
                $"!ban  : Bans a user from the server.\n" +
                $"!copypasta : Shows a list of copypastas. Open a copypasta by typing !copypasta <name of copypasta> **Make sure the letters are lowercase!**\n" +
                $"!kiss <user> : Kiss a friend!\n" +
                $"!slap <user> : Slaps a bruh!\n" +
                $"!hug <user> : Hugs a friend!\n" +
                $"!poke <user> : Pokes a dood!\n" +
                $"!roast <user> : Roasts a user!\n" +
                $"!Ply_Rus <user> <number> : Play Russian Roulette with your friends! Use the command, tag a friend you want to put under preasure, and a number. This number will be used as the roof, or a high number, from a random selection which will determine which number is hte bullet. The smallest number and highest chance to die that you can enter is 1. The higher the number, the more about of blanks, and a higher chance to live!\n");
        }

    }
}

