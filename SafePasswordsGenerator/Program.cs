using System;

namespace SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int numofPassword = int.Parse(Console.ReadLine());
            int cnt = 0;
            int i = 35;
            int j = 64;
            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    cnt++;
                    if (cnt > numofPassword)
                    {
                        return;
                    }
                    if (i == 55) { i = 35; }
                    if (j == 96) { j = 64; }
                    Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                    i++; j++;
                }
            }
        }
    }
}
