using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Roasts : ModuleBase
    {
        [Command("roast")]
        [Alias("insult")]
        public async Task RoastsAsync([Remainder] string echo)
        {
            string user = "" + echo;

            int part1 = new Random().Next(0, 41);

            switch (part1)
            {
                case 0:
                    user += " has a micropenis.";
                    break;
                case 1:
                    user += " has an IQ of 6. ";
                    break;
                case 2:
                    user += " needs serious help.";
                    break;
                case 3:
                    user += " is awake past his bedtime.";
                    break;
                case 4:
                    user += " plays Fortnite.";
                    break;
                case 5:
                    user += " is so cheap he won't even tip his hat.";
                    break;
                case 6:
                    user += " 's birth certificate is an apology from the condom factory.";
                    break;
                case 7:
                    user += " uses a sniper rifle in GTA";
                    break;
                case 8:
                    user += " listens to nightcore unironically. ";
                    break;
                case 9:
                    user += "'s dad's condom broke. ";
                    break;
                case 10:
                    user += " eats nachos without any dip. ";
                    break;
                case 11:
                    user += " has a 3Head.";
                    break;
                case 12:
                    user += " can't even lift. ";
                    break;
                case 13:
                    user += " thinks Hitler is cool. ";
                    break;
                case 14:
                    user += " plays with hot wheels on weekends for fun. ";
                    break;
                case 15:
                    user += " doesn't look both ways when they cross the street. ";
                    break;
                case 16:
                    user += " can not count to 10. ";
                    break;
                case 17:
                    user += " failed preschool. ";
                    break;
                case 18:
                    user += " plays the Wii without a safety strap. ";
                    break;
                case 19:
                    user += " plays AP Yasuo support. ";
                    break;
                case 20:
                    user += " digs straight down. ";
                    break;
                case 21:
                    user += " leaves angry youtube comments. ";
                    break;
                case 22:
                    user += " spams 'I NEED HEALING' ";
                    break;
                case 23:
                    user += " is a teemo main. ";
                    break;
                case 24:
                    user += " thinks minecraft is scary. ";
                    break;
                case 25:
                    user += " is so ugly that face scanners can't recognize their face. ";
                    break;
                case 26:
                    user += " uses Skype instead of Discord. ";
                    break;
                case 27:
                    user += " prefers light mode. ";
                    break;
                case 28:
                    user += " blasts their speakers in public on max volume. ";
                    break;
                case 29:
                    user += " adds an uncomfortable amount of ranch on their pizzas. ";
                    break;
                case 30:
                    user += " is stuck in the nether ";
                    break;
                case 31:
                    user += " can't speak our language. They only speak idiot. ";
                    break;
                case 32:
                    user += " has a 10$ laptop and lags in minesweeper. ";
                    break;
                case 33:
                    user += " still uses internet explorer. ";
                    break;
                case 34:
                    user += "'s password is 123. ";
                    break;
                case 35:
                    user += " has a brain smaller than an ant. ";
                    break;
                case 36:
                    user += " uses a spongebob night light. ";
                    break;
                case 37:
                    user += " does not know the alphabet. ";
                    break;
                case 38:
                    user += " is so dumb they get lost in supermarkets. ";
                    break;
                case 39:
                    user += " went to the zoo recently, as the animal. ";
                    break;
                case 40:
                    user += " has the body of a 70 year old, but the brain of a 7 year old. ";
                    break;
                case 41:
                    user += " uses their hands to wipe their shit. ";
                    break;
            }
            await ReplyAsync(user + "");

        }
        [Command("roast")]
        public async Task RektAsync()
        {
            await ReplyAsync("I can't roast this guy because he doesn't exist.");

        }
    }



}