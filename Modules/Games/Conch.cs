

using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class MagicConch : ModuleBase
    {


        [Command("conch")]
        public async Task Conch(string choice)
        {
            if (choice.Contains("?"))
            {
                int answer = new Random().Next(1, 9);
                if (answer == 1)
                {
                    await ReplyAsync("Maybe someday.");

                }
                if (answer == 2)
                {
                    await ReplyAsync("Nothing.");
                }

                if (answer == 3)
                {
                    await ReplyAsync("Neither.");
                }

                if (answer == 4)
                {
                    await ReplyAsync("Follow the seahorse.");
                }

                if (answer == 5)
                {
                    await ReplyAsync("I don't think so.");
                }
                if (answer == 6)
                {
                    await ReplyAsync("No.");
                }
                if (answer == 7)
                {
                    await ReplyAsync("Yes");
                }
                if (answer == 8)
                {
                    await ReplyAsync("Try asking again!");

                }

            }
            else
            {
                await ReplyAsync("");
            }
        }


    }



}

