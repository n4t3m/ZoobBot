using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShitpostBot
{
    public class Conversation : ModuleBase
    {
        [Command("info")]
        public Task Info()
            => ReplyAsync(
$"Hello, I am a bot called {Context.Client.CurrentUser.Username} written in Discord.Net 2.1 for Discord Hack Week.\n");


        [Command("hello")]
        [Alias("hi", "yo", "sup", "howdy", "nword", "greetings", "Greetings", "Hey", "hey", "Hi", "Konichiwa", "konichiwa")]
        public Task Hello() => ReplyAsync($"Hello There!\n");

        [Command("copypasta")]
        [Alias("copypasta list")]
        public Task CopypastaList() => ReplyAsync($"List:\n" +
            $"Coochie (Trans Pussy)\n" +
            $"Navy Seal\n" +
            $"Airpods\n" +
            $"Bathroom Scale\n" +
            $"Megalovania\n");

        [Command("copypasta coochie")]
        public Task Coochie() => ReplyAsync($"I'm trying😢 to get me some trans🤖 pussy 😺💦. Like shit💩 it ain't natural🌱but that coochie😛💦 be custom👌built🤖. Probably got some 🤟velvet 😍heated🔥interiors. Auto 😤lavender-scented🌸 lube dispensers💦 so that coochie😺 staying wet🌊 but not smelling🤢 like a zoo. Little robo🤖 hands🙌 that reach👋out and cradle🤲😍 your balls🏀⚾ while you hamming🔨 on that pseudo-snatch. A drain💧 vacuum for all👍the nuts🍆💦 you blast💥in there so you ain't🌀🌪️stirring your own porridge🥣 for round 2🤢. You guys🙎‍♂️be hating😪on trans🌈 people, even😮during their own🌗month, but there's all🌟kinds of potential there. Fuck💢all that normal🤢sloppy coochie, get yourself some trans🤖super💥 coochie. They're called🌈 trans because that😺 pussy be transforming👾your life.\n");

        [Command("copypasta navy seal")]
        public Task NavySeal() => ReplyAsync($"What the fuck did you just fucking say about me, you little bitch? I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla warfare and I’m the top sniper in the entire US armed forces. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life. You’re fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that’s just with my bare hands. Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. If only you could have known what unholy retribution your little “clever” comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldn’t, you didn’t, and now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. You’re fucking dead, kiddo.");

        [Command("copypasta airpods")]
        public Task AirPods() => ReplyAsync($"All right im declaring it apple airpods are no longer for rich people or a flex. The new flex is the 999$ apple monitor stand. You'll be seeing me wearing mine in the hallway you will all have 3 days to acquire one or you will be unfriended\n");

        [Command("copypasta bathroom scale")]
        public Task BathroomScale() => ReplyAsync($"Don’t👏put👏a👏scale👏in👏the👏bathroom👏and👏not👏expect👏me👏to👏weigh👏myself👏before👏and👏after👏pooping👏to👏calculate👏how👏big👏my👏poop👏was👏then👏chart👏those👏findings👏so👏I👏can👏determine👏my👏average👏poop👏size👏\n");

        [Command("copypasta megalovania")]
        public Task Megalovania() => ReplyAsync($"Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun dunna. Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun Dun dun da dun, dun dun dun dun dunna.Dun dun da dun, dun Dun dun da dun, dun dun dun dun dunna.dun dun Dun dun da dun, dun Dun dun da dun, dun dun dun dun Dun dun da dun, dun dun dun dun dunna.\n");

        //[Command("copypasta coochie")]
        //public Task Coochie() => ReplyAsync($"\n");


    }
}
