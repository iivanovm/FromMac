using System;

namespace MoreEX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex.BalancedBrackets();
        }
    }
    internal class Ex
    {
        public static void FloatingEquality()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if ((Math.Max(a, b) - Math.Min(a, b)) > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }

        public static void RefactoringPrimeChecker()
        {
            int prime = int.Parse(Console.ReadLine());
            for (int i = 2; i <= prime; i++)
            {
                Console.WriteLine($"{i} -> {isPrime(i).ToString().ToLower()}");
            }
        }
        public static bool isPrime(int num)
        {
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DecryptingMessage()
        {
            byte decriptionKey = byte.Parse(Console.ReadLine());
            byte charactersCount = byte.Parse(Console.ReadLine());
            string message = "";

            while (charactersCount > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + decriptionKey)).ToString();

                charactersCount--;
            }

            Console.WriteLine(message);
        }
        public static void BalancedBrackets()
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            bool isLocked = false;
            byte openingBracketsCount = 0;
            byte closingBracketsCount = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString.Length == 1)
                {
                    char currentChar = char.Parse(currentString);
                    openingBracketsCount += currentChar == '(' ? (byte)1 : (byte)0;
                    closingBracketsCount += currentChar == ')' ? (byte)1 : (byte)0;
                    if (!(openingBracketsCount == closingBracketsCount ||
                        openingBracketsCount == closingBracketsCount + 1))
                    {
                        isLocked = true;
                    }
                }
            }
            bool isBalances = openingBracketsCount == closingBracketsCount;
            Console.WriteLine(isBalances && !isLocked ? "BALANCED" : "UNBALANCED");
        }
    }
}
