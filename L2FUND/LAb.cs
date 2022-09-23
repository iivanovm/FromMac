using System;

namespace L2FUND
{
    internal class lab
    {
        public static void ConvertMeterstoKilometers()
        {
            int meter = int.Parse(Console.ReadLine());
            Console.WriteLine($"{meter * 0.001:f2}");
        }
        public static void PtoDollars()
        {
            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine($"{pound * 1.31:f3}");
        }

        public static void ExactSumOfRealNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal nnn = decimal.Parse(Console.ReadLine());
                sum += nnn;
            }
            Console.WriteLine(sum);
        }

        public static void CenturiesToMinutes()
        {
            int input = int.Parse(Console.ReadLine());
            int years = 100;
            double days = input * years * 365.2422;
            long hours = (int)days * 24;
            long minutes = (int)hours * 60;
            Console.WriteLine($"{input} centuries = {input * years} years = {(int)days} days = {hours} hours = {minutes} minutes");

        }

        public static void SpecialNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int start = 1; start <= n; start++)
            {
                sum = 0;
                for (int i = start; i > 0; i = i / 10)
                {
                    sum += i % 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                    Console.WriteLine($"{start} -> {isSpecial}");
                }
                else
                {
                    isSpecial = false;
                    Console.WriteLine($"{start} -> {isSpecial}");
                }
            }
        }

        public static void ReversedString()
        {
            string name = Console.ReadLine();
            string revname = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revname += name[i] + " ";
            }
            Console.Write(revname);
        }

        public static void ReversedChar()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{c} {b} {a}");
        }

        public static void ConcatNames()
        {
            string name = Console.ReadLine();
            string lname = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{name}{delimeter}{lname}");
        }

        public static void TownInfo()
        {
            string name = Console.ReadLine();
            string lname = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"Town {name} has population of {lname} and area {delimeter} square km.");
        }

        public static void CharsToString()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string text = a.ToString() + b.ToString() + c.ToString();
            Console.WriteLine(text);
        }

        public static void LowerOrUpper()
        {
            char input = char.Parse(Console.ReadLine());

            if ((int)input >= 65 && (int)input <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)input >= 97 && (int)input <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}