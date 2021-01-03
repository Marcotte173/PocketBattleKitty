using System;

namespace TheAdventuresOfPocketBattleKitty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Color.SetupConsole();
            Menu.Go();
        }
    }
}
