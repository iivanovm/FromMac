using System;
namespace _05._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    counter++;
                    int currSum = n1 + n2;
                    if (currSum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({n1} + {n2} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}