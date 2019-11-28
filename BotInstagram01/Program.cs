using System;

namespace BotInstagram01
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile = Instagram.GetProfileByUser("cadugraphys.py");

            Console.ReadKey();
        }
    }
}
