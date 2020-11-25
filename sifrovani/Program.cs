using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifrovani
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Zadejte větu k zašifrování:");
            string userSlovo = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("Zadejte sílů šifrování: 1-16");
            int insertCislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nVáš klíč je {0}", insertCislo);

           long[] convertor1 = new long[userSlovo.Length];
           string[] convertor2 = new string[userSlovo.Length];


            long keyNumber = insertCislo;

            Dictionary<long, string> hash = new Dictionary<long, string>()
            {
                [keyNumber] = "Kappa",
                [keyNumber*1] = "HeyGuys",
                [keyNumber*2] = "PogChamp",
                [keyNumber*3] = "LUL",
                [keyNumber*4] = "CoolStoryBob",
                [keyNumber*5] = "4Head",
                [keyNumber*6] = "Jebaited",
                [keyNumber*7] = "FrankerZ",
                [keyNumber*8] = "PJSalt",
                [keyNumber*9] = "NotLikeThis",
                [keyNumber*10] = "WutFace",
                [keyNumber*11] = "SeemsGood",
                [keyNumber*12] = "ResidentSleeper",
                [keyNumber*13] = "TwitchUnity",
                [keyNumber*14] = "GivePLZ",
                [keyNumber*15] = "CoolCat",
                [keyNumber*16] = "CurseLit",
                [keyNumber*17] = "POGGERS",
                [keyNumber*18] = "OMEGALUL",
                [keyNumber*19] = "monkaS",
                [keyNumber*20] = "Clap",
                [keyNumber*21] = "PepeHands",
                [keyNumber*22] = "EZ",
                [keyNumber*23] = "Pepega",
                [keyNumber*24] = "pepeJAM",
                [keyNumber*25] = "KEKW",
                [keyNumber*26] = "PogU",
                [keyNumber*27] = "PepePls",
                [keyNumber*28] = "monkaW",
                [keyNumber*29] = "PepeLaugh",
                [keyNumber*30] = "weirdChamp",
                [keyNumber*31] = "gachiHYPER",
                [keyNumber*32] = "peepoClap",
                [keyNumber*33] = "LULW",
                [keyNumber*34] = "peepoHappy",
                [keyNumber*35] = "TriKool",
                [keyNumber*36] = "FeelsBadMan",
                [keyNumber*37] = "ddHuh",
                [keyNumber*38] = "forsenPls",
                [keyNumber*39] = "CrabPls",
                [keyNumber*40] = "WowPls",
                [keyNumber*41] = "XDD",
                [keyNumber*42] = "UwU",
                [keyNumber*43] = "-_-",
                [keyNumber * 44] = ":)",
                [keyNumber * 45] = ":(",
                [keyNumber * 46] = ":/",
                [keyNumber * 47] = ":3",
                [keyNumber * 48] = "8)",
                [keyNumber * 49] = ":*",
                [keyNumber * 50] = ":C",
                [keyNumber * 51] = "XoXo",
            };
            // inicializace Abecedy převedené do "hashe"
            Dictionary<string, long> slovnik = new Dictionary<string, long>() {
                ["a"] = keyNumber,
                ["á"] = keyNumber*1,
                ["b"] = keyNumber*2,
                ["c"] = keyNumber*3,
                ["č"] = keyNumber*4,
                ["d"] = keyNumber*5,
                ["ď"] = keyNumber*6,
                ["e"] = keyNumber*7,
                ["é"] = keyNumber*8,
                ["ě"] = keyNumber*9,
                ["f"] = keyNumber*10,
                ["g"] = keyNumber*11,
                ["h"] = keyNumber*12,
                ["ch"] = keyNumber*13,
                ["i"] = keyNumber*14,
                ["j"] = keyNumber*15,
                ["k"] = keyNumber*16,
                ["l"] = keyNumber*17,
                ["m"] = keyNumber*18,
                ["n"] = keyNumber*19,
                ["ň"] = keyNumber*20,
                ["o"] = keyNumber*21,
                ["ó"] = keyNumber*22,
                ["p"] = keyNumber*23,
                ["q"] = keyNumber*24,
                ["r"] = keyNumber*25,
                ["ř"] = keyNumber*26,
                ["s"] = keyNumber*27,
                ["š"] = keyNumber*28,
                ["t"] = keyNumber*29,
                ["ť"] = keyNumber*30,
                ["u"] = keyNumber*31,
                ["ú"] = keyNumber*32,
                ["ů"] = keyNumber*33,
                ["v"] = keyNumber*34,
                ["w"] = keyNumber*35,
                ["x"] = keyNumber*36,
                ["y"] = keyNumber*37,
                ["ý"] = keyNumber*38,
                ["z"] = keyNumber*39,
                ["ž"] = keyNumber*40,
                [" "] = keyNumber*41,
                ["1"] = keyNumber*42,
                ["2"] = keyNumber * 43,
                ["3"] = keyNumber * 44,
                ["4"] = keyNumber * 45,
                ["5"] = keyNumber * 46,
                ["6"] = keyNumber * 47,
                ["7"] = keyNumber * 48,
                ["8"] = keyNumber * 49,
                ["9"] = keyNumber * 50,
                ["í"] = keyNumber * 51,

            };
            string pouzivaneSlovo;
            for(int i = 0; i < userSlovo.Length; i++)
            {
                pouzivaneSlovo = userSlovo[i].ToString();
                convertor1[i] = slovnik[pouzivaneSlovo];
            }
            for(int i = 0; i < userSlovo.Length; i++)
            {
                convertor2[i] = hash[convertor1[i]];
            }
            Console.WriteLine("\nČíselný hash:");
            for (int i = 0; i < userSlovo.Length; i++)
            {
                Console.Write(convertor1[i]);
                if (i + 1 == userSlovo.Length)
                {
                    break;
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("\nTwitch hash:");
            for (int i = 0; i < userSlovo.Length; i++)
            {
                Console.Write(convertor2[i]);
                if (i+1 == userSlovo.Length)
                {
                    break;
                }
                else
                {
                    Console.Write("-");
                }

            }
            Console.ReadKey();
        }
    }
}
