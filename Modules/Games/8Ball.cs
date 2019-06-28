using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class EightBall : ModuleBase
    {

        [Command("8ball")]
        [Alias("fortune")]
        public async Task RektAsync()
        {
            string user = "";

            int part1 = new Random().Next(1, 21);

            switch (part1)
            {
                case 1:
                    user += "It is certain";
                    break;
                case 2:
                    user += "It is decidedly so.";
                    break;
                case 3:
                    user += " Without a doubt.";
                    break;
                case 4:
                    user += " Yes - definitely.";
                    break;
                case 5:
                    user += " You may rely on it.";
                    break;
                case 6:
                    user += " As I see it, yes.";
                    break;
                case 7:
                    user += "Most likely.";
                    break;
                case 8:
                    user += "Outlook good.";
                    break;
                case 9:
                    user += "Yes.";
                    break;
                case 10:
                    user += "The signs point to yes.";
                    break;
                case 11:
                    user += "Reply hazy, try again.";
                    break;
                case 12:
                    user += "Ask again later.";
                    break;
                case 13:
                    user += "Better not tell you now.";
                    break;
                case 14:
                    user += "I cannot predict now.";
                    break;
                case 15:
                    user += "Concentrate and ask again";
                    break;
                case 16:
                    user += "Don't count on it.";
                    break;
                case 17:
                    user += "My reply is no.";
                    break;
                case 18:
                    user += "My sources say no.";
                    break;
                case 19:
                    user += "Outlook not so good";
                    break;
                case 20:
                    user += "Very doubtful.";
                    break;

            }
            await ReplyAsync(user + "");

        }
    

    [Command("8ball")]
    [Alias("fortune")]
    public async Task RektAsync(String str)
    {
        string user = "";

        int part1 = new Random().Next(1, 21);

        switch (part1)
        {
            case 1:
                user += "It is certain";
                break;
            case 2:
                user += "It is decidedly so.";
                break;
            case 3:
                user += " Without a doubt.";
                break;
            case 4:
                user += " Yes - definitely.";
                break;
            case 5:
                user += " You may rely on it.";
                break;
            case 6:
                user += " As I see it, yes.";
                break;
            case 7:
                user += "Most likely.";
                break;
            case 8:
                user += "Outlook good.";
                break;
            case 9:
                user += "Yes.";
                break;
            case 10:
                user += "Signs point to yes.";
                break;
            case 11:
                user += "Reply hazy, try again.";
                break;
            case 12:
                user += "Ask again later.";
                break;
            case 13:
                user += "Better not tell you now.";
                break;
            case 14:
                user += "Cannot predict now.";
                break;
            case 15:
                user += "Concentrate and ask again";
                break;
            case 16:
                user += "Don't count on it.";
                break;
            case 17:
                user += "My reply is no.";
                break;
            case 18:
                user += "My sources says no.";
                break;
            case 19:
                user += "Outlook not so good";
                break;
            case 20:
                user += "Very doubtful.";
                break;

        }
        await ReplyAsync(user + "");

    }
}

    }
