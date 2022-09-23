using System;

namespace ExercLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            P02_MultiplicationTable();

        }

        public static void P04_TriangleofDollars()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }

        }

        public static void P05_SquareFrame()
        {
            var n = int.Parse(Console.ReadLine());

            //First Part
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");

            }
            Console.WriteLine(" +");

            //Two parts
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            //last part
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");

            }
            Console.WriteLine(" +");
        }

        public static void P06_RhombusOfStars()
        {
            int n = int.Parse(Console.ReadLine());
              for (int row =1; row <=n; row++)
            {
                for (int col =1; col <=n-row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for(int col =1; col<row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row > 0; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

        }

        public static void P07_ChristmasTree()
        {
            int n=int.Parse(Console.ReadLine());    
            for (int row =0; row <=n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*',row));
                
                Console.WriteLine();
            }
            
        }

        public static void P08_Sunglasses()
        {

            //с размер 5*n x n като в примерите:
            int n = int.Parse(Console.ReadLine());
            int m = n * 5;
            for (int i = 1; i<=n; i++)
            {
                Console.Write(new string('*',1));
            }
        }

        public static void P01_Clock()
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }

        public static void P02_MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    int EndResult = i * j;
                    Console.WriteLine($"{i} * {j} = {EndResult}");
                }
            }
        }
    }
}
