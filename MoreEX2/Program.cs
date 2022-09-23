using System;

namespace MoreEX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex.DataTypeFinder();
        }
    }
    internal class Ex
    {
        public static void DataTypeFinder()
        {

            string input = Console.ReadLine();
            int valueInt;
            float valueFloat;
            char valueChar;
            bool valueBoolean;

            while (input != "END")
            {
                if (int.TryParse(input, out valueInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out valueFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out valueChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out valueBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
        public static void FromLeftToTheRight()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';
                string[] splitNumbers = numbers.Split(delimiter);

                long leftNum = long.Parse(splitNumbers[0]);
                long rightNum = long.Parse(splitNumbers[1]);

                long biggerNumber = rightNum;
                if (leftNum > rightNum)
                {
                    biggerNumber = leftNum;
                }

                long sumOfDigits = 0;
                while (biggerNumber != 0)
                {
                    sumOfDigits += biggerNumber % 10;
                    biggerNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
                //this upload 
            }

        }
    }
}
