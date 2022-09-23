using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MoreEX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MEX.MultiplicationSign();
        }
    }

    internal class MEX
    {
        public static void DataTypes()
        {
            string wht = Console.ReadLine();
            var num = Console.ReadLine();
            switch (wht.ToLower())
            {
                case "int": Console.WriteLine(int.Parse(num) * 2); break;
                case "real": Console.WriteLine($"{(float.Parse(num) * 1.5):f2}"); break;
                case "string": Console.WriteLine($"${num}$"); break;
            }
        }

        public static void CenterPoint(double x1, double y1, double x2, double y2)
        {
            double result = Math.Abs(x1) + Math.Abs(y1);
            double result2 = Math.Abs(x2) + Math.Abs(y2);

            if (result < result2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static void ClosestToZero(double a, double b, double c, double d)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(c), 2) + Math.Pow(Math.Abs(d), 2));
            if (first > second)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
        }

        public static void LongestLine(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            double firstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double secondLine = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - h), 2));
            if (firstLine >= secondLine)
            {
                ClosestToZero(a, b, c, d);
            }
            else
            {
                ClosestToZero(e, f, g, h);
            }
        }

        public static void TribonacciSequence()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.Write(1);
            }
            else if (num == 2)
            {
                Console.Write("1 1");
            }
            else if (num == 3)
            {
                Console.Write("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribonacci(num);
            }
        }

        private static void GetTribonacci(BigInteger num)
        {
            BigInteger minus3 = 1;
            BigInteger minus2 = 1;
            BigInteger minus1 = 2;
            BigInteger max = num;
            for (int i = 0; i < max - 3; i++)
            {
                num = minus3 + minus2 + minus1;
                minus3 = minus2;
                minus2 = minus1;
                minus1 = num;
                Console.Write("{0} ", num);
            }
        }

        public static void MultiplicationSign()
        {

            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            isPositive(a, b, c);
        }

        public static void isPositive(double a, double b,double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }

            else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
    
}
