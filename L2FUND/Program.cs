using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;

namespace L2FUND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exr.BeerKegs();
        }
    }

    internal class Exr
    {
        public static void IntOperation()
        {
            int firstnum=int.Parse(Console.ReadLine()); 
            int secondnum=int.Parse(Console.ReadLine());
            int thirdnum=int.Parse(Console.ReadLine());
            int fourthnum=int.Parse(Console.ReadLine());
            int total = 0;

            Console.WriteLine($"{total=((firstnum+secondnum)/thirdnum)*fourthnum}");
        }

        public static void SumOfDigit()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input.ToString().Sum(c => c - '0')); 
        }

        public static void Elevator()
        {
            int person=int.Parse(Console.ReadLine());   
            int capacity=int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)person/capacity))    ;
        }
        public static void SumOFChars()
        {
            int numofchar=int.Parse(Console.ReadLine());
            char input;
            int sum = 0;
            for (int i = 0; i < numofchar; i++)
            {
                input=char.Parse(Console.ReadLine());

                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }

        public static void PrintPartASCII()
        {
            int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());  
            for ( int i = start; i <=end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }

        public static void TriplesofLatinLetters()
        {
            int n =int.Parse(Console.ReadLine());   
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    for (int k=0; k < n; k++)
                    {
                        Console.Write((char)('a' + i));Console.Write((char)('a' + j)); Console.WriteLine((char)('a' + k));
                    }
                }
            }
        }

        public static void WaterOverflow()
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int tankcap = 255;
            int sum = 0;
            for (int i=0; i < n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                if ((sum + liters) > tankcap)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else if ( sum<tankcap)
                {
                    sum += liters;
                }
            }
            Console.WriteLine(sum);
        }

        public static void BeerKegs()
        {
            int n = int.Parse(Console.ReadLine());
           // double p=double.Parse(Console.ReadLine());
            double max = int.MinValue;
            string winname = string.Empty;
            string model = string.Empty;
            float radios = 0;
            double height = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radios = float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                total = Math.PI * radios * height;
                if (total > max)
                {
                    max = total;
                    winname = model;
                }

            }
            Console.WriteLine(winname);
        }
    }

}

