using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Card_Farming_Bot
{
    using System;
    using System.Runtime.InteropServices;
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***Steam Card Farming Bot***");
            System.Console.WriteLine("Program created by: XRKT");
            System.Console.WriteLine("Steam URL: http://steamcommunity.com/profiles/76561198017577802");
            System.Console.WriteLine("*******************************************************************");
            System.Console.WriteLine("___________________________________________________________________");
            System.Console.WriteLine("The program is now active, press any key to close when you're done.");
            System.Console.WriteLine("___________________________________________________________________");
            Steam.Init();
            System.Console.WriteLine("___________________________________________________________________");
            Console.ReadKey();
            Steam.Kill();

        }
    }

    public class Steam
    {
        public static bool SteamInit;

        public static void Init()
        {
            SteamInit = SteamAPI_Init();
        }

        public static void Kill()
        {
            SteamAPI_Shutdown();
        }

        [DllImport("steam_api.dll")]
        private static extern bool SteamAPI_Init();
        [DllImport("steam_api.dll")]
        private static extern bool SteamAPI_Shutdown();
    }
}
