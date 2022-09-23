using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace DrawMenuFromList
{
    internal class Program
    {
        public static void Main()
        {

           
            mainMenu();
        }
        static int indexMainMenu = 0;


        public static void mainMenu()
        {
            Console.Clear();

            List<string> menuItems = new List<string>()
    {
        "Play",
        "Settings",
        "NowCreate",
        "Exit"
    };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMainMenu(menuItems);
                if (selectedMenuItem == "Play")
                {
                    // Play the game, or start the app
                }
                else if (selectedMenuItem == "Settings")
                {
                    /* Go to settings. Call a method, in the method just
                    copy this menu system and change the list names for
                    each setting you want.*/
                }
                else if (selectedMenuItem == "NowCreate")
                {
                    /* Go to settings. Call a method, in the method just
                    copy this menu system and change the list names for
                    each setting you want.*/
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0); // Or  System.Environment.Exit(0);
                }
            }
        }

        public static string drawMainMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == indexMainMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (indexMainMenu == items.Count - 1) { }
                else { indexMainMenu++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (indexMainMenu <= 0) { }
                else { indexMainMenu--; }
            }
            else if (ckey.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[indexMainMenu];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
