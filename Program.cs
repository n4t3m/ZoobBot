using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using ShitpostBot.Helpers;

namespace ShitpostBot
{
    class Program
    {
        public DiscordSocketClient Client;
        public CommandHandler Handler;
        static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            Client = new DiscordSocketClient();

            Console.WriteLine("Patrick is cute");

            Handler = new CommandHandler();

            await Client.LoginAsync(Discord.TokenType.Bot, "", true);

            await Client.StartAsync();

            await Handler.Install(Client);

            Client.MessageReceived += MessageReceived;
            Client.UserJoined += UserJoined;
            Client.Log += Log;
            Client.UserIsTyping += UserIsTyping;
            //Client.MessageUpdated += MessageUpdated;

            Client.Ready += Client_Ready;
            await Task.Delay(-1);

        }

        private async Task Client_Ready()
        {
            Console.WriteLine("SHITPOST BOT REPORTING FOR DUTY!");
            await Client.SetGameAsync("Discord Hack Week!");
            return;

        }


        private async Task MessageReceived(SocketMessage message)
        {
            Console.WriteLine("Method Called");
            string str = message.Content;

            if (message.Content == "hi")
            {
                await message.Channel.SendMessageAsync("Hello!");
            }

            if (str.Contains("fuck") || str.Contains("shit") || str.Contains("tits") || str.Contains("dick") || str.Contains("bitch") || str.Contains("bastard") || str.Contains("damn") || str.Contains("cunt") || str.Contains("wanker") || str.Contains("cunt") || str.Contains("wanker")  || str.Contains("penis") || str.Contains("frick")  || str.Contains("cock") || str.Contains("Brian Liu")  || str.Contains("hell") || str.Contains("nigga") || str.Contains("pussy"))
            {
                await message.Channel.SendMessageAsync("**THERE WILL BE NO FUCKING CURSING ON THIS MINECRAFT. DISCORD. SERVER.** \nhttps://tenor.com/YG43.gif");
            }

            if (str.Contains("I'm"))
            {
                Console.WriteLine(str.IndexOf("I'm"));
                String Name = "";
                int temp = str.IndexOf("I'm");
                if(temp+5<str.Length)
                {
                    for(int i=temp+4; i<str.Length; i++)
                    {
                        Name += str[i];
                    }

                    if (!Name.Contains("I'm"))
                    {
                        await message.Channel.SendMessageAsync("Hello " + Name + ", I am Zoob Bot!");
                    }

                }

            }
        }

        private async Task UserJoined(SocketGuildUser user)
        {
            string username = user.Username;
            await user.SendMessageAsync("Welcome to Zoob Bot " + username);
        }

        private async Task UserIsTyping(SocketUser u, ISocketMessageChannel m)
        {
            int random = new Random().Next(0, 10);
            string username = u.Username;
            if (random == 5)
            {
                await m.SendMessageAsync("*Watcha typin " + username + "? ( ͡° ͜ʖ ͡°)*");
            }
        }


        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }



    }
}


