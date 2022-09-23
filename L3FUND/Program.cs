using Microsoft.VisualBasic;
using System;
using System.Buffers;
using System.Linq;
using System.Net;

namespace L3FUND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise.EqualSum();
        }
    }
    internal class Exercise
    {
        public static void Train()
        {
            int wagonnum = int.Parse(Console.ReadLine());
            int[] people = new int[wagonnum];
            int sum = 0;
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += (int)people[i];

            }
            foreach (int i in people)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\n{sum}");
        }

        public static void CommonElements()
        {
            var arr1 = Console.ReadLine().Split(' ').ToArray();
            var arr2 = Console.ReadLine().Split(' ').ToArray();
            string rezult = string.Empty;
            string[] a1 = arr1;
            string[] a2 = arr2;
            for (int i = 0; i < a2.Length; i++)
            {
                for (int k = 0; k < a1.Length; k++)
                {
                    if (a2[i] == a1[k])
                    {
                        rezult += a2[i] + " ";
                    }
                }
            }
            Console.WriteLine(rezult);
        }
        public static void ZigZagArrays()
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];
            int[] arr2 = new int[num];
            int a;
            int b;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    a = 0;
                    b = 1;
                }
                else
                {
                    b = 0;
                    a = 1;
                }
                var nw = Console.ReadLine();
                string[] nn = nw.Split(' ');
                arr1[i] = int.Parse(nn[a]);
                arr2[i] = int.Parse(nn[b]);
            }
            Console.WriteLine($"{string.Join(" ", arr1)}");
            Console.WriteLine($"{string.Join(" ", arr2)}");
        }

        public static void ArrayRotation()
        {
            var newarr = Console.ReadLine();
            int numrevers = int.Parse(Console.ReadLine());

            string[] arr = newarr.Split(" ");
            for (int i = 0; i < numrevers; i++)
            {
                var head = arr[0];
                Array.Copy(arr, 1, arr, 0, arr.Length - 1);
                arr[arr.Length - 1] = head;
            }
            Console.WriteLine(String.Join(" ", arr));
        }

        public static void TopIntegers()
        {
            long[] inputArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (long i = 0; i < inputArr.Length; i++)
            {
                bool isItBigger = true;
                for (long j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }
            }
        }

        public static void EqualSum()
        {
            string[] input= Console.ReadLine().Split(' ');
            int[] ints=input.Select(int.Parse).ToArray();
            int leftsum = 0;
            int rightsum = 0;   
            for (int i = 0; i <ints.Length-1; i++)
            {
                Console.WriteLine($"Num {i}");
                for (int k = ints.Length - 1; k > i; k--)
                { 
                    Console.WriteLine($"RightSide=====>ints[{k}]={ints[k]}");
                    rightsum+=ints[k];
                }
                for (int j =i; j > 0; j--)
                {
                    Console.WriteLine($"LeftSide=====>ints[{j}]={ints[j]}");
                    leftsum+=ints[j];
                }

                Console.WriteLine($"RESULT==>{rightsum==leftsum}");
            }
            

        }
    }
}
