using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

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
            Client.Log += Log;

            Client.Ready += Client_Ready;
            await Task.Delay(-1);

        }

        private async Task Client_Ready()
        {
            Console.WriteLine("SHITPOST BOT REPORTING FOR DUTY!");
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

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }



    }
}


