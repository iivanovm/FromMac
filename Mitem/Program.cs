using System;
using System.Collections;
using System.Collections.Generic;

namespace Mitem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuitemFull();
        }



        public static void MenuitemFull()
        {
            List<string> MenuItem = new List<string>() { "Cofee", "Beer", "Coca Cola", "Red Bul", "Exit" };
            Console.CursorVisible = false;
            while (true)
            {
                string index = nmenu.Men(MenuItem);
                if (index == "Cofee")
                {
                    Console.WriteLine("sad");
                }
                else if (index == "Beer")
                {
                    Console.WriteLine("Sasa");
                }
                else if (index == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
