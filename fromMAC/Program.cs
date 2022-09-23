using System;
using System.Linq;
using System.Collections;

namespace fromMAC
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 5 5 99 3 4 2 5 1 1 4

            string[] input = Console.ReadLine().Split(" ");
            int[] ints = input.Select(int.Parse).ToArray();
            foreach(int n in ints)
            {
                Console.WriteLine(n);
            }

        }
    }
}

