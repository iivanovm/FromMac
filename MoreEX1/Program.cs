using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace MoreEX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoreEx.RefactorSpecialNumbers();
        }
    }

    internal class MoreEx
    {
        public static void GamingStore()
        {
            var gStore = new Dictionary<string, double>
            {
                {"OutFall 4", 39.99},
                {"CS: OG",15.99},
                {"Zplinter Zell",19.99},
                {"Honored 2", 59.99},
                {"RoverWatch", 29.99},
                {"RoverWatch Origins Edition", 39.99}
            };
            double balance=double.Parse(Console.ReadLine());
            double total=balance;
            string command;
            double sum = 0;
            while (balance!= 0.00)
            {
                command = Console.ReadLine();
                if(command== "Game Time")
                {
                    if (balance > 0)
                    {
                        Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${total-sum:f2}");
                    }
                    break;
                }
                else if (gStore.GetValueOrDefault(command, 0) == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                }
                else if ((gStore.GetValueOrDefault(command, 0) > balance))
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    balance-= gStore.GetValueOrDefault(command, 0);
                    sum+=gStore.GetValueOrDefault(command, 0);
                    Console.WriteLine($"Bought {command}");
                    if (balance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                
            }
           
        }

        public static void ReverseString()
        {
            string word=Console.ReadLine();
           char[] nw=word.ToCharArray();
            string print = string.Empty;
            for (int i=nw.Length-1; i>=0; i--)
            {
                print += nw[i];
            }
            Console.WriteLine(print);
        }

        public static void Message()
        {
            var sms = new Dictionary<int, string>
            {
                {2,"a"},{22,"b"},{222,"c"},{3,"d"},{33,"e"},
                {333,"f"},{4,"g"},{44,"h"},{444,"i"}, {5,"j" },
                {55,"k" }, {555,"l"},{6,"m"},{66,"n"},
                {666,"o"},{7,"p"},{77,"q"},{777,"r"},{7777,"s"},
                {8,"t"},{88,"u"}, {888,"v"}, {9,"w"}, {99,"x"},{999,"y"},{9999,"z"},{0," "}
            };
            int numSms=int.Parse(Console.ReadLine());
            string printSms=string.Empty;
            for (int i=0; i<numSms; i++)
            {
                int input=int.Parse(Console.ReadLine());
                printSms += sms.GetValueOrDefault(input, "");

            }
            Console.WriteLine(printSms);
        }

        public static void RefactorVolumeofPyramid()
        {
            double lenght, Width,height, V = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            V = (lenght* Width*height)/3;
            Console.Write($"Pyramid Volume: {V:f2}");
        }

        public static void RefactorSpecialNumbers()
        {
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0;
            int takova = 0;
            bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine("{0} -> {1}", takova, toe);
                obshto = 0;
                ch = takova;
            }
        }
    }
}
