using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class RPS : ModuleBase
    {


        [Command("RPS")]
        public async Task RockRPS(string choice)
        {
            if (choice.Contains("paper") || choice.Contains("scissors") || choice.Contains("rock"))
            {
                int winner = new Random().Next(1, 4);
                if (winner == 1)
                {
                    await ReplyAsync($"You Win!");
                }
                else
                {
                    await ReplyAsync($"You Lost :(");
                }
            }
            else
            {
                await ReplyAsync("Please select 'rock', 'paper' or 'scissors'.");
            }
        }


    }



}

