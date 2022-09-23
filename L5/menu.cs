using System;
using System.Collections;
using System.Collections.Generic;

namespace L5
{


    class setup
    {


        static int index = 0;
        public static string Menu(List<string> items)
        {
            string prefix = "o";
            for (int i = 0; i < items.Count; i++)
            {
                if (index == i)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(prefix + " " + items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }
            Console.CursorVisible = false;
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1) { }
                else
                {
                    index++;
                }
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0) { }
                else
                {
                    index--;
                }
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (key.Key == ConsoleKey.RightArrow) { Console.Clear(); }
            else if (key.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }

        public static void MenuFill()
        {
            List<string> MenuItem = new List<string>() { "Cofee", "Beer", "Coca Cola", "Red Bul", "Exit" };
            Console.CursorVisible = false;
            while (true)
            {
                string SelectedItem = Menu(MenuItem);
                if (SelectedItem == "Cofee")
                {
                    break;
                }
                else if (SelectedItem == "Berr")
                {
                    Console.WriteLine("beer");
                }
                else if (SelectedItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }

    public class userDetails
    {
        string fName;
        string lname;
        string Age;
        public userDetails(string fName, string lname, string age)
        {
            this.fName = fName;
            this.lname = lname;
            Age = age;
        }
    }

}