

![Discord Hack Week Banner](https://cdn-images-1.medium.com/max/2600/1*lh6NS8hx0pu5mlZeSqnu5w.jpeg)


### Zoob Bot

Have you every thought "Hey, how many memes can be crammed into a single discord bot over the course of 4 days?"  Probably not.... But we did! 

Our creation, Zoob Bot, was developed during Discord Hack Week 2019 and features over **1,000 commands**, yes, **ONE THOUSAND COMMANDS** filled with fun and cancerous memes, jokes, pop culture references, and games.

Zoob Bot was developed by Nathan Melwani, Patrick Aventino, Jinsu Hwang, and Aurora Yin.

[![ServerInvite](https://img.shields.io/badge/Join%20Test%20Server-Click%20here-success.svg "This is where you can test the bot")](https://discord.gg/AYRbJgT) [![BotInvite](https://img.shields.io/badge/Invite%20bot-Click%20here-ff69b4.svg "Invite the bot to your server")](https://discordapp.com/oauth2/authorize?client_id=592952933327437828&scope=bot&permissions=8)

**The buttons above are outdated as the bot is no longer being hosted since the competition is long over.**

#### Setup/Install
 1. Download .NET Core Runtime from [here](https://dotnet.microsoft.com/download).
 2. Download .NET Core SDK from [here](https://dotnet.microsoft.com/download).
 3. Unpack and install both of these. 
 4. Restart your computer.
 5. Go to our [Github Repository](https://github.com/NateM135/ZoobBot) and find the Green button that says clone or download. Click it and select Download Zip.
 6. Extract the contents of the zip to a folder of your choosing. You will need to know the path to this file later.
 7. Open the Program.cs file in a text editor of your choosing, I suggest [Notepad++](https://notepad-plus-plus.org/).
 8. Find the line Client.LoginAsync, and in the middle parameter after Discord.TokenType.Bot, place your Discord Bot token. If you do not know what a token is, you can search up a guide on Google. I suggest that you use [this guide.](https://github.com/reactiflux/discord-irc/wiki/Creating-a-discord-bot-&-getting-a-token)
 9. Save your Program.cs file and close out of it.
 10. Open up a command prompt with Administrator permissions (In Windows 10, click the Cortana Search bar on the bottom left hand corner and type Command Prompt, right click on it and click Run as Administrator. 
 11. Open the folder that the bot files were unzipped to. Double click the folder name in the upper bar and copy the file path. 
 12. In the Command Prompt type cd and then paste in the file path. Note: You cannot paste a filepath using Control + V, you HAVE TO RIGHT CLICK AND SELECT PASTE.
 13. Type <code>dotnet run</code>.
 14. The bot should now run! Once you see the message "patrick is cute" then the bot is starting to initialize. Once the second gateway message is sent, the bot is online! 
 


#### Non-Command Features

 - Whenever you say I'm ___, Zoob will respond with Hi ___, I'm Zoob!
 - There is a 10% chance when you type that Zoob will say "Watcha Typin <@user>
 - If you say hello/hi/greeting/etc, Zoob says hello back. Just some *common decency.*
 - Advanced curse world filter. Zoob will remind you about his Christian values whenever a naughty, naughty curse word is said in his chatroom.

#### Commands

*When typing out commands exclude <>, as <> simply shows that there needs to be a user input, such as a sentence or tagging a user (Ex: !8ball "Zoob Ball will win Hack Week"  or !lick @pittypot#3945).*

| General Commands| |
| -- |-- |
|!botinfo | Provides info about bot.|
|!binfo | Provides info about bot!|
|!ping| Checks ZoobBot Ping!|
|!help| Shows the main commands the bot can use.|
|!getzoobbot| Invite Zoob Bot to YOUR SERVER!|

|Games||
|--|--|
|!8ball @user| Ask the magic 8ball any question and get a *dank* response!|
|!fortune @user| Get a dank fortune from the Zoob himself!|
|!conch<"question">| The magic conch from Spongebob! Ask it your questions and get responses similar to the cartoon!|
|!rps <"rock, paper, or scissors">| Rock, Paper, Scissors game you play with the bot. You must choose between rock, paper, and scissors to play against the bot! This MAY OR MAY NOT BE RIGGED!!
|!ply_rus <@user> <#> |Play Russian Roulette with your friends! Use the command and tag a friend you want to play with as well as a number. This number will be used to specify the number of bullets in the chamber of the gun. The higher the number, the smaller the chance you have of being kicked.
|!hply_rus <@user>|Russian Roulette, although the bot bans you instead of kicking. Due to the destructive nature of this command, there will always be six bullets in the chamber and thus a 1/6 chance of being banned from the server, and to ensure that people don't spam and ban randos, the command can only be used on the command caller.

|Interactions||
|-|-|
|!bdaywish <@user>|Wishes the user a happy birthday!
|!bite <@user>|Bites an user!
|!dab <@user|Dabs on an user!
|!dance <@user>|You do a dance!
|!kill <@user>|You yeet on a user in true anime style ;)
|!hug <@user>|Hugs a user!
|!kiss <@usere>|Kiss a user!
|!lick <@user>|Licks a user!
|!poke <@user>|Pokes a user!
|!roast <@user>|Roasts a user! (There are ~FIFTY ROASTS!)
|!slap <@user>|Slaps a user!
|!say <""> |The bot repeats what you say 
|!shout <""> |Takes what he user puts into the quatations then replys with what they said but in all capital letters.
|!whisper <""> |Takes what he user puts into the quatations then replys with what they said but in all lowecase letters.
|!marrymewith <@user>|Marrys the user with the person specified in the command.
|!owo <"">|Turns what the user puts in quotations in *owo* speak. (r->w, l->w)
|!hola|Say *hola* to Zoob!

|List of SFW Copypastas||
|-|-|
|!copypasta or !copypasta list|Obtains a list of copypastas that the user can use.
|!copypasta navy seal|Replys with the navy seal copypasta
|!copypasta airpods|Replys with the airpods copypasta
|!copypasta bathroom scale|Replys with the poop scale copypasta
|!copypasta meglovania|Replys with meglovania
|!copypasta adam|Replys with the adam copypasta
|!copypasta hit or miss|Replys with hit or miss
|!copypasta family feud|Replys with steve harvey copypasta.

|List of Meme Commands||
|-|-|
|!meme list or !meme directory or !meme|Shows a list of sources you can obtain a random meme from.
|!meme aww|Displays a random meme orginating from the aww subreddit.
|!meme anime|Displays a random meme orginating from the anime subreddit.
|!meme bpt|Displays a random meme orginating from the BPT subreddit.
|!meme wpt|Displays a random meme orginating from the WPT subreddit.
|!meme dank|Displays a random meme orginating from the Dank subreddit.
|!meme deepfried|Displays a random meme orginating from the Deepfried subreddit.
|!meme discord|Displays a random meme that is of discord theme.
|!meme garfield|Displays a random meme orginating from the imsorryjon subreddit.
|!meme history|Displays a random meme orginating from the historymemes subreddit.
|!meme meirl|Displays a random meme orginating from the me_irl subreddit.
|!meme meme|Displays a random normie meme.
|!meme phcomments|Displays a random meme orginating from the pornhub comments subreddit. (Everything is 100% SFW and intended for comedic purposes)
|!meme socialanxiety|Displays a random meme orginating from the social anxiety meme subreddit.
|!meme wholesome|Displays a random meme orginating from the wholesome subreddit.
|!meme hydrohomies|Displays a random meme orginating from the hydro hommie subreddit.

|General Gaming/Memes (GAMERS ONLY)
|-
|!nintendo slogan      
|!shigeru miyamoto     
|!toad says      
|!reggie       
|!mario says      
|!youngster says      
|!shigeru miyamoto says
|!end of mario    
|!ssbu waluigi 
|!stop reset
|!hey listen      
|!super mario galaxy
|!satoru iwata      
|!Wii U slogan       
|!dangerous      
|!jokers     
|!nintendo ds slogan      
|!stay off   
|!sega saturn
|!turbografx-16     
|!intellivision       
|!xbox one      
|!neo-geo aes      
|!ps3    
|!magnavox odyssey       
|!sega master system       
|!nintendo wii      
|!sega dreamcast      
|!ps4      
|!sega genesis     
|!xbox 360      
|!nintendo 64      
|!ps2     
|!snes     
|!atari 2600
|!NES
|!nintendo switch
|!gameboy advance
|!nintendo 3ds
|!cuphead  
|!celeste        
|!super meat boy       
|!hollow knight     
|!terraria      
|!enter the gundeon
|!papers, please      
|!the binding of issac      
|!don't starve together       
|!axiom verge      
|!return of the obra dinn       
|!machinarium     
|!moonlighter       
|!hzd
|!horizon zero dawn      
|!gow 
|!god of war  
|!sekiro
|!sekiro shadows die twice
|!BOI 
|!sick flying
|!lickingwounds
|!advice
|!ladyinareflectivejacket
|!seetheabove
|!crying babys
|!Arin and dan
|!jinsu
|!one punch man
|!dingo
|!bango
|!congo
|!kangaroo
|!did you know
|!sound proof bots
|!baby seats
|!triangle
|!square
|!pentagon
|!septagon
|!octogon
|!cockpit
|!dirtysecret
|!funtimes
|!common man is
|!I'm bad on planes
|!water
|!cactus juice
|!lose
|!soleanna
|!flight
|!bee movie
|!drugs
|!dummy thicc
|!old spice
|!aot
|!mikasa
|!rem
|!todoroki
|!bakugou
|!uraraka
|!ed
|!al
|!avatar
|!hyperbeam
|!fireblast
|!shadowclonejutsu
|!nani
|!baka
|!fresh
|!drip
|!micdrop
|!heartshaker
|!likey
|!yesoryes
|!fancyyou
|!woah
|!yeet
|!stare
|!bruh
|!thicc
|!spin
|!02
|!ricardo
|!gachi
|!shit
|!die
|!outplayed
|!okay
|!lul
|!omegalul
|!aqua
|!explosion
|!unravel
|!burger
|!awesome
|!nice
|!smile
|!gg
|!ez
|!ree
|!wah
|!luigi
|!charizard
|!sit
|!burrito
|!ohyeahyeah
|!pika
|!oof
|!rekt
|!gotem
|!fbi
|!snore
|!flex
|!rawr
|!cute
|!kawaii
|!cash
|!yoink
|!surprised
|!free
|!zoom
|!succ
|!juice
|!tea
|!brain
|!yum
|!jam
|!bop
|!tp
|!grind
|!rage
|!woosh
|!happy
|!zone
|!sad
|!killua
|!yandere
|!tsundere
|!loveuwu
|!bowser
|!pinrahaplant
|!chomp
|!echolenny
|!bear
|!lennybrick
|!vibe
|!gohard
|!tablefix
|!derpface
|!onoe
|!gross
|!hungry
|!baby
|!sigh
|!tilt
|!salt
|!salty
|!thonk
|!thirsty
|!hmph
|!supersaiyan
|!badass
|!hackerman
|!pepega
|!cheer
|!smug
|!salute
|!sammy
|!please
|!fed
|!praise
|!pow
|!thankyoukanye

|Terminator
|-
|!hastalavista
|!illbeback
|!chopper

|Undertale
|-
|!sans
|!papyrus
|!toriel
|!asgore
|!flowey
|!forbiddenundertale

|Fortnite
|-
|!victoryroyale
|!imfortnitegod
|!riptilted
|!droplocation
|!creatorcode
|!defaultdance
|!floss
|!bestmates
|!tpose

|PUBG
|-
|!bananaman
|!pubgdriving
|!dropLocationPUBG

|Minecraft
|-
|!steve
|!waterbucket
|!bedtrick
|!diamonds
|!emeralds
|!iron
|!coal
|!fallenkingdom
|!takebackthenight
|!swingsword

|Gungeon
|-
|!glitchchest
|!rainbowchest
|!blackchest
|!redchest
|!greenchest
|!bluechest
|!brownchest
|!yeet
|!1013

|FNAF
|-
|!bonnie
|!purpleguy
|!freddyfaz

|League of Legends
|-
|!firstblood
|!doublekill
|!triplekil
|!quadrakill
|!pentakill
|!tyler1
|!t1
|!nightblu3
|!teemorework
|!abcdelike
|!promocode
|!omgdragon
|!gbay99
|!ryzerework
|!ogryze
|!xpeke
|!faker
|!aatrox
|!ahri
|!akali
|!alistar
|!amumu
|!anivia
|!annie
|!ashe
|!sol
|!azir
|!bard
|!blitzcrank
|!brand
|!braum
|!caitlyn
|!camille
|!cass
|!chogath
|!corki
|!darius
|!diana
|!drmundo
|!draven
|!ekko
|!elise
|!evelynn
|!ezreal
|!fiddlesticks
|!fiora
|!fizz
|!galio
|!gangplank
|!garen
|!gnar
|!gragas
|!graves
|!hecarim
|!heimerdinger
|!illaoi
|!irelia
|!ivern
|!janna
|!jarvaniv
|!jax
|!jayce
|!jhin
|!jinx
|!kaisa
|!kalista
|!karma
|!karthus
|!kassadin
|!katarina
|!kayle
|!kayn
|!kennen
|!khazix
|!kindred
|!kled
|!kogmaw
|!leblanc
|!leesin
|!leona
|!lissandra
|!lucian
|!lulu
|!lux
|!malphite
|!malzahar
|!maokai
|!masteryi
|!missfortune
|!mordekaiser
|!morgana
|!nami
|!nasus
|!nautilus
|!neeko
|!nidalee
|!nocturne
|!nunu
|!olaf
|!orianna
|!ornn
|!pantheon
|!poppy
|!pyke
|!qiyana
|!quinn
|!rakan
|!rammus
|!reksai
|!renekton
|!rengar
|!riven
|!rumble
|!ryze
|!sejuani
|!shaco
|!shen
|!shyvana
|!singed
|!sion
|!sivir
|!skarner
|!sona
|!soraka
|!swain
|!sylas
|!syndra
|!tahmkench
|!taliyah
|!talon
|!taric
|!teemo
|!thresh
|!tristana
|!trundle
|!tryndamere
|!twistedfate
|!twitch
|!udyr
|!urgot
|!varus
|!vayne
|!veigar
|!velkoz
|!vi
|!viktor
|!vladimir
|!volibear
|!warwick
|!wukong
|!xayah
|!xerath
|!xinzhao
|!yasuo
|!yorick
|!yuumi
|!zac
|!zed
|!zilean
|!zoe
|!zyra
|!ziggs

|Spongebob
|-
|!leedle
|!potatosalad
|!touch
|!future
|!bigmeatyclaws
|!ugly
|!movebehindrocks
|!wumbo
|!mini
|!bathtime
|!chocolate
|!areyoupatrickstar
|!andthisisyourid
|!ifoundthisidinthiswallet
|!then take it
|!isthisthekrustykrab
|!krustykrabpizza
|!ismayoaninstrument
|!touch
|!we have technology
|!hello
|!donttouchme
|!24
|!25
|!mynamesnotrick
|!itssupposedtodothat
|!howcanweeverthankyou
|!seewhatimean
|!pat

|Overwatch
|-
|!c9
|!nerf
|!healing
|!genji
|!hanzo
|!highnoon
|!xqc
|!justice
|!seagull
|!hammer
|!goats
|!ana
|!ashe
|!baptiste
|!bastion
|!brigitte
|!dva
|!doomfist
|!genji
|!hanzo
|!junkrat
|!lucio
|!mccree
|!mei
|!mercy
|!moira
|!orisa
|!pharah
|!reaper
|!reinhardt
|!roadhog
|!soldier76
|!sombra
|!symmetra
|!torbjorn
|!tracer
|!widowmaker
|!winston
|!wreckingball
|!zarya
|!zenyatta




|Marvel
|-
|!love
|!balance
|!assemble
|!wakanda
|!spiderman
|!hulksmash
|!hulk
|!angry
|!ironman
|!groot
|!dormamu
|!snap
|!ass
|!dust

|Simpsons
|-
|!hereareyourgrades
|!bringimplementsofdestruction
|!foxnetwork
|!presidentoverthrown
|!classickrusty
|!comedycentral
|!bringmeanicotinepatch
|!letsplayagame
|!scrabble
|!skippingiscool
|!hellno
|!nobiblestories
|!shouldwetelldaddy
|!harrypotter
|!areyoujealousofhomer
|!imaginationchristmas
|!religiousfit
|!money
|!reversepsychology
|!herlegendwillliveforever
|!highschoolreunion
|!spendtimewiththeboy
|!whothedevilareyou
|!lisaneedsbraces
|!dentalplan
|!whyareyousinging
|!slow
|!think
|!thinklikeflanders
|!icanthearmyselfthink
|!timetogotowork
|!ciderorjuice

|CSGO
|-
|!juandeag
|!boostmeister
|!rushb
|!plant
|!s1mple
|!collat
|!dragonlore
|!green
|!knifemid
|!swag7

|DC
|-
|!batman
|!joker
|!aquaman
|!doomsday
|!wonderwoman
|!bane
|!robin
|!grenlantern
|!superman
|!gamers
|!flash
|!shazam

|MOMOLAND (Kpop)
|-
|!nancy
|!yeonwoo
|!ahin
|!daisy
|!taeha
|!hyebin
|!nayun
|!jane

|TWICE (Kpop)
|-
|!mina
|!sana
|!nayeon
|!momo
|!chaeyoung
|!jihyo
|!dahyun
|!tzuyu
|!tt
|!yesoryes
|!fancy
|!cheerup
|!micdrop (I know its BTS but shhhh)
|!heartshaker
|!likey
|!fancyyou

|Red Velvet (Kpop)
|-
|!irene
|!yeri
|!wendy
|!seulgi
|!powerup
|!russianrouletteRV
|!badboy
|!reallybadboy
|!icecreamcake
|!dumbdumb
|!zimzalabim
|!peekaboo
|!redflavor
|!rookie

|Modern Pop Music/Recent Hits
|-
|!whateverittakes
|!thisiswhatyoucamefor
|!rude
|!havana
|!intheend
|!sorry
|!oldtownroad
|!thelazysong
|!wedonttalkanymore
|!darkhorse
|!leanon
|!closer
|!highhopes
|!countingstars
|!stressedout
|!badguy
|!thunder
|!faded
|!7rings
|!believer
|!radioactive
|!ratherbe
|!maskoff
|!wakemeup
|!chandelier
|!attention
|!heathens
|!allofme
|!treatyoubetter
|!stitches
|!7years
|!despacito
|!starboy
|!godsplan
|!dontlemedown
|!shapeofyou
|!hipsdontlie
|!smooth

|Pokemon
|-
|!unown a
|!unown b
|!unown c
|!unown d
|!unown e
|!unown f
|!unown g
|!unown h
|!unown i
|!unown j
|!unown k
|!unown l
|!unown m
|!unown n
|!unown o
|!unown p
|!unown q
|!unown r
|!unown s
|!unown t
|!unown u
|!unown v
|!unown w
|!unown x
|!unown y
|!unown z
|!greninja
|!totodile
|!quagsire
|!squirtle
|!charmander
|!catchemall
|!suicune

|Boku No Hero
|-
|!detroitsmash
|!allmight

|Dragon Ball
|-
|!kamehameha

|Completely Random
|-
|!floss
|!bestmates
|!tpose
|!bts
|!blackpink
|!jisoo
|!rose
|!wooper
|!quieres
|!umaru
|!yourname
|!fmab
|!mustang
|!circle
|!yato
|!mob
|!seriouspunch
|!damn
|!jajanken
|!shelter
|!orangejustice
|!shoot
|!godspeed
|!demoman
|!engineer
|!heavy
|!medic
|!pyro
|!soldier
|!spy
|!sniper
|!scout
|!beep
|!doot
|!goldmember
|!wetworks
|!glossyboys
|!moist
|!charlie chapplin

|Alphabet
|-
|!a
|!b
|!c
|!d
|!e
|!f
|!g
|!h
|!i
|!j
|!k
|!l
|!m
|!n
|!o
|!p
|!q
|!r
|!s
|!t
|!u
|!v
|!w
|!x
|!y
|!z
|!69
|!alphabet
|!abcd
|!abc
|!abcde
|!wow?

|Random
|-
|!thisisaverylongcommand
|!passport
|!gibberjabber
|!dnd
|!nat1
|!nat20
|!1+1
|!9+10
|!cool?
|!yes
|!saynomore
|!knock knock
|!ye
|!ya ya
|!bois will be bois
|!caleb
|!nott
|!yourbreathtaking
|!breathtaking
|!you'rebreathtaking
|!comfort
|!company
|!beu
|!ashley johnson
|!mattew mercer
|!past or the future
|!curiosity
|!lifeguard
|!123
|!456
|!321
|!buzz 
|!pink slip
|!quit
|!gamesofthrones
|!troybois
|!in the zone?
|!this is a pretty good bot
|!hatebin
|!business
|!CharlietheUnicorn
|!Candy mountain
|!marioyou
|!luigiyou
|!haltosis
|!goodtimes
|!racism
|!racist

|Smash
|-
|!ssbu 
|!ssbu mario
|!ssbu peach
|!ssbu luigi
|!ssbu bowser
|!ssbu dr. mario
|!ssbu donkey kong
|!ssbu diddy kong
|!ssbu link
|!ssbu zelda
|!ssbu sheik
|!ssbu samus
|!ssbu zero suit samus
|!ssbu kirby
|!ssbu meta knight
|!ssbu king dedede
|!ssbu pikachu
|!ssbu jigglypuff
|!ssbu pichu
|!ssbu mewtwo
|!ssbu pokemon trainer
|!ssbu lucario
|!ssbu greninja
|!ssbu captain falcon
|!ssbu ness
|!ssbu lucas
|!ssbu ike
|!ssbu lucina
|!ssbu robin
|!ssbu corrin
|!ssbu mr.game & watch
|!ssbu wario
|!ssbu olimar
|!ssbu r.o.b.
|!ssbu villager
|!pink wii fit trainer
|!ssbu snake
|!ssbu sonic
|!ssbu mega man
|!ssbu pac-man
|!ssbu mii brawler
|!ssbu mii swordfighter
|!ssbu daisy
|!ssbu piranha plant
|!ssbu king k. rool
|!ssbu ridley
|!ssbu dark samus
|!ssbu inkling
|!ssbu ken
|!ssbu simon
|!ssbu richter
|!ssbu joker
|!ssbu bowser jr.
|!ssbu rosalina
|!ssbu yoshi
|!ssbu young link
|!ssbu ganondorf
|!ssbu toon link
|!ssbu wolf
|!ssbu falco
|!ssbu fox
|!ssbu ice climbers
|!ssbu marth
|!ssbu roy
|!ssbu pit
|!ssbu palutena
|!ssbu dark pit
|!ssbu little mac
|!ssbu shulk
|!ssbu duck hunt
|!ssbu ryu
|!ssbu cloud
|!ssbu bayonetta
|!ssbu mii gunner
|!ssbu incineroar
|!ssbu chrom
|!ssbu isabelle
|!ssbu hero
|!ssbu banyo & kazooie
|!ssbu galeem
|!ssbu master hand
|!ssbu giga bowser
|!ssbu ggalleom
|!ssbu rathalos
|!ssbu dharkon
|!ssbu crazy hand
|!ssbu marx
|!ssbu ganon
|!ssbu dracula
|!ssbu metal face
|!ssbu yellow devil
|!ssbu sark emperor
|!ridley
|!falcon
|!mewtwo
|!foxonly
|!tierlist
|!waluigi
|!isabelle
|!banjo
|!reggie
|!sakurai
|!wombocombo
|!chillin
|!joycon
|!hungrybox


|Zelda
|-
|!botwrain
|!koroks
|!botwselfie
|!botwlink
|!botwzelda
|!mipha
|!calamity ganon
|!yiga
|!impa
|!hestu
|!great deku tree
|!epona 
|!daruk
|!revali
|!urbosa
|!botwchart
|!vah medoh
|!vah naboris
|!vah rudania
|!vah ruta
|!botwsword
|!kass
|!sleeping link   
|!Hhiiyhaa    
|!zelda plead 

|Splatloon
|-
|!agent 3
|!agent 4
|!agent 8
|!callie
|!marie
|!pearl
|!marie
|!cap'n cuttlefish
|!c.q. cumber
|!judd
|!mrgrizz
|!iso padre
|!crusty sean
|!jelonzo 
|!annie  
|!sheldon   
|!spyke   
|!bisk
|!jelfonzo   
|!flow  
|!murch
|!dj octavio
|!splatfest

|Random/Modern Memes
|-
|!etika
|!meandtheboys
|!2b2t
|!karen
|!chungus
|!ticktok
|!crabrave
|!bowsette
|!thisissosad
|!alexaplaydespacito
|!ligma
|!sugma
|!ninja
|!foreveralone
|!trollface
|!lenny
|!megusta
|!nomegusta
|!pepe
|!notbad
|!smalls
|!trump
|!pelosi
|!thankyoukanye
|!career
|!felicia
|!walkin
|!homer
|!nothingatall
|!steamedhams
|!fact
|!krustyhotline







