

using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZoobBot
{
    public class memeHydroHomies : ModuleBase
    {
        [Command("meme hydrohomies")]
        public async Task HydroHomiesAsync()
        {
            string user = " Water gang ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://external-preview.redd.it/DMhGo8c4BhrVB2smobmh-yNaCvCQr1jdbgDNg1sT9ME.jpg?width=640&crop=smart&auto=webp&s=f81e6f6cb1d080982945708428e16ae16146f918 ";
                    break;
                case 1:
                    user += " https://preview.redd.it/a7zdptg8im031.jpg?width=640&crop=smart&auto=webp&s=23ddd3337f1a644aaedb1b96fa7a24c6595c47d4 ";
                    break;
                case 2:
                    user += " https://preview.redd.it/30mpdkz4zzx21.png?width=640&crop=smart&auto=webp&s=d8974b23e820298b1e6075ea3bb848114b5d2fd3 ";
                    break;
                case 3:
                    user += " https://i.redd.it/9q8ijqtqrq031.jpg ";
                    break;
                case 4:
                    user += " https://preview.redd.it/80cyth4llp231.jpg?width=640&crop=smart&auto=webp&s=ed4f2f996f1d4ac3c912e66a5534638b139608df ";
                    break;
                case 5:
                    user += " https://preview.redd.it/2jt6idpqgc031.jpg?width=640&crop=smart&auto=webp&s=fda7b74a914ddd83e806e66bde30d83a60b1fce7 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/hf4lkv9wgez21.jpg?width=640&crop=smart&auto=webp&s=1f2645ed9faa60a85ef27f633d4e371b886af543 ";
                    break;
                case 7:
                    user += " https://preview.redd.it/ebf7xyjnkg631.jpg?width=640&crop=smart&auto=webp&s=53a07df98052fd3ed5560f2acb8fd37a106e9851 ";
                    break;
                case 8:
                    user += " https://preview.redd.it/44lrcop831031.jpg?width=640&crop=smart&auto=webp&s=5a32451dea40f31d4f013cc887f53c5b039d975d ";
                    break;
                case 9:
                    user += " https://preview.redd.it/mckmi7cxpq131.jpg?width=640&crop=smart&auto=webp&s=cd1afc090e969166244d9b9a011b01b9da715565 ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
}





