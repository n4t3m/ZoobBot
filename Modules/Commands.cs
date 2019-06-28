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
            var botUser = Context.Client.CurrentUser;

            var embedBuilder = new EmbedBuilder()
                .WithTitle("__About me__")
                .WithDescription("Welcome to Zoob Bot. Zoob Bot is a bot made for Discord Hack Week 2019 and features 1000 commands for shitty memes, jokes, and pop culture references.")
                .WithColor(100, 180, 255)
                .WithThumbnailUrl(botUser.GetAvatarUrl(size: 64))
                .AddField("Need to know what commands there are?", $"Check out or [Github page](https://github.com/NateM135/ZoobBot \"GitHub\") for the full list of commands that we offer!.")
                .AddField("Who?", " [Zoob Bot](https://github.com/NateM135/ZoobBot \"GitHub\") is made by Nathan Melwani, Patrick Aveninto, Jinsu Hwang, and Aurora Yin.");

            await ReplyAsync("", embed: embedBuilder.Build());
        }
    }
}

