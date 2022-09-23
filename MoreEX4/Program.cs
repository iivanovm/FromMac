using System;
using System.Runtime.InteropServices;
using System.Linq;

namespace MoreEX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex.RecursiveFibonacci();
        }
    }

    internal class Ex
    {
        public static void EncryptSortandPrintArray()
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();
                int sum = 0;

                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == 'A' || chars[j] == 'E' || chars[j] == 'I' || chars[j] == 'O' || chars[j] == 'U' || chars[j] == 'a' || chars[j] == 'e' || chars[j] == 'i' || chars[j] == 'o' || chars[j] == 'u')
                    {
                        sum += (int)chars[j] * input.Length;
                    }
                    else
                    {
                        sum += (int)chars[j] / input.Length;
                    }
                }
                arr[i] = sum;
            }
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void PascalTriangle()
        {
            var numl = int.Parse(Console.ReadLine());
            var Ptriangle = new long[numl][];

            for (int row = 0; row < numl; row++)
            {
                Ptriangle[row] = new long[row + 1];
                Ptriangle[row][0] = 1;
                Ptriangle[row][^1] = 1;

                for (var col = 1; col < row; col++)
                {
                    Ptriangle[row][col] = Ptriangle[row - 1][col - 1] + Ptriangle[row - 1][col];
                }
            }
            for (var row = 0; row < numl; row++)
            {
                Console.WriteLine(String.Join(" ", Ptriangle[row]));
            }
        }

        public static void RecursiveFibonacci()
        {
            int fibonachiNumber = int.Parse(Console.ReadLine());

            int[] startArr = new int[] { 1, 1 };


            for (int i = 0; i < fibonachiNumber; i++)
            {
                int[] sequenceOfFibonachi = new int[startArr.Length + 1];
                sequenceOfFibonachi[0] = 1;
                sequenceOfFibonachi[1] = 1;

                for (int j = 2; j < sequenceOfFibonachi.Length; j++)
                {
                    sequenceOfFibonachi[j] = startArr[j - 2] + startArr[j - 1];
                }

                startArr = sequenceOfFibonachi.ToArray();
            }

            Console.WriteLine($"{startArr[fibonachiNumber - 1]}");
        }

    }
}
 
    
