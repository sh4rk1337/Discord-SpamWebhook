using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Collections.Specialized;

namespace SHARKER1337
{
    class Encode_lmao
    {
        internal class SHARKER_Af5eCTB7twWWFTMZ458V17CSBgzTHlMSluWlNlxVkHbNMhPIsszLrzE5yO2SZh8F
        {

            public static byte[] SHARKER_BqL7BDbYmoAUlMJQMzjIhSNMIZ9mt0LO(string SHARKER_tuEpLY93dT0hH6Fplc1WEMUkfAMeGNpl, NameValueCollection SHARKER_ViVGlLi4IkG8HIuCAjivmpiXipmGZphN)
            {
                byte[] SHARKER_exEPW6MiSVOpRSIiPYK5qaEYNLSgDuqO;
                using (WebClient SHARKER_T96IRhz6I0 = new WebClient())
                {
                    SHARKER_exEPW6MiSVOpRSIiPYK5qaEYNLSgDuqO = SHARKER_T96IRhz6I0.UploadValues(SHARKER_tuEpLY93dT0hH6Fplc1WEMUkfAMeGNpl, SHARKER_ViVGlLi4IkG8HIuCAjivmpiXipmGZphN);
                }
                return SHARKER_exEPW6MiSVOpRSIiPYK5qaEYNLSgDuqO;
            }

        }

        private static void SHARKER_4E46Z2iVx22k4elrq2nOL3y0uoGrnKPZ(string SHARKER_dxbNBdyPJj3EsziNNm1FVtKOu3hW3FoU, string SHARKER_qhAqF0ti56U7OuIboX3Jgfzl61IJUwpI, string SHARKER_B3jAglT1gMuYcCj5sHnNJn9KB5QjVr43)
        {
            SHARKER_Af5eCTB7twWWFTMZ458V17CSBgzTHlMSluWlNlxVkHbNMhPIsszLrzE5yO2SZh8F.SHARKER_BqL7BDbYmoAUlMJQMzjIhSNMIZ9mt0LO(SHARKER_dxbNBdyPJj3EsziNNm1FVtKOu3hW3FoU, new NameValueCollection()
            {
                { "username", SHARKER_B3jAglT1gMuYcCj5sHnNJn9KB5QjVr43 },
                { "content", SHARKER_qhAqF0ti56U7OuIboX3Jgfzl61IJUwpI },
                { "avatar", "https://cdn.discordapp.com/avatars/752406475858772049/d1e782febbbc85db86209d9e34ee341a.png?width=684&height=684" },
            });
        }

        private static void spam(int succ, string str,string msg)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{succ}] send msg : {msg}");
                Thread.Sleep(200);
                SHARKER_4E46Z2iVx22k4elrq2nOL3y0uoGrnKPZ(str, msg, "SHARKER - CONSOLE");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Announcement from discord] wait 1minute for spam again.");
                Thread.Sleep(60000);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Discord SpamWebhook";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[input webhook for spam] : ");
            string strwebhook = Console.ReadLine();
            Console.Write("[input message for spam] : ");
            string message = Console.ReadLine();
            int succ = 0;

            while (true)
            {
                succ++;
                spam(succ,strwebhook, message);
            }

        }
    }
}
