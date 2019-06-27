using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Copypasta : ModuleBase
    {
        [Command("hola")]
        [Alias("hi", "yo", "sup", "howdy", "nword", "greetings", "Greetings", "Hey", "hey", "Hi", "Konichiwa", "konichiwa")]
        public Task Hello() => ReplyAsync($"Hello There!\n");

        [Command("copypasta")]
        [Alias("copypasta list")]
        public Task CopypastaList() => ReplyAsync($"**Use all Lowercase Letters**\n" +
            $"List:\n" +
            $"Navy Seal\n" +
            $"Airpods\n" +
            $"Bathroom Scale\n" +
            $"Megalovania\n" +
            $"Hit Or Miss\n" +
            $"Family Fued\n" +
            $"Adam\n");

        [Command("copypasta navy seal")]
        public Task NavySeal() => ReplyAsync($"What the fuck did you just fucking say about me, you little bitch? I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla warfare and I’m the top sniper in the entire US armed forces. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life. You’re fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that’s just with my bare hands. Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. If only you could have known what unholy retribution your little “clever” comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldn’t, you didn’t, and now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. You’re fucking dead, kiddo.");

        [Command("copypasta airpods")]
        public Task AirPods() => ReplyAsync($"All right im declaring it apple airpods are no longer for rich people or a flex. The new flex is the 999$ apple monitor stand. You'll be seeing me wearing mine in the hallway you will all have 3 days to acquire one or you will be unfriended\n");

        [Command("copypasta bathroom scale")]
        public Task BathroomScale() => ReplyAsync($"Don’t👏put👏a👏scale👏in👏the👏bathroom👏and👏not👏expect👏me👏to👏weigh👏myself👏before👏and👏after👏pooping👏to👏calculate👏how👏big👏my👏poop👏was👏then👏chart👏those👏findings👏so👏I👏can👏determine👏my👏average👏poop👏size👏\n");

        [Command("copypasta megalovania")]
        public Task Megalovania() => ReplyAsync($"Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna.\n");

        [Command("copypasta adam")]
        public Task Adam() => ReplyAsync($"Hiii! my name is adam xDD im 12 yrs youngg. im takenn (((: happily by my 15 yrs youngg gf amy. shes my everything<33333 but i still flirt with all the girls in my class ;) shh. ;x i go to parties every sat. and party st church on sunday, holaaahh! hahaha, i love jesus, but idk i might be atheist. im bisexual but i’ll never touch another boy because it’s a sin ;( i do weed and i luv lil wayne, and the jonas brothers. i h8 black ppl because they scare me. follow me ok?!!?! =D\n");

        [Command("copypasta hit or miss")]
        public Task HitOrMiss() => ReplyAsync($"To hit, or not to hit. Dost thou ever miss? I suppose it not. You have a male love interest, yet I would wager he does not kiss thee (Ye olde mwah). Furthermore; he will find another lass like he won't miss thee. And at the end of it all. He is going to skrrt, and he will hit that dab, as if he were the man known by the name of Wiz Khalifa\n");

        [Command("copypasta family fued")]
        public Task FamilyFued() => ReplyAsync($"Steve Harvey: We asked 100 people, what is the male reproductive organ ?  Contestant: The penis SH: A WUH... HUH ??  audience erupts into laughter Steve Harvey grabs onto podium to support himself laughter gets even louder SH: O lordy... one man goes into cardiac arrest and many others begin vomiting profusely from laughing too hard SH: YOU PEOPLE NEED HELP the Earth shatters and Satan rises from the underworld to claim unworthy souls the universe begins rapidly closing in on itself SH: (putting on a weary voice) Survey says... the board shows 100 for penis Harvey is able to get off one more shocked look before existence as we know it comes to an end\n");

        //[Command("copypasta coochie")]
        //public Task Coochie() => ReplyAsync($"\n");


    }
}
