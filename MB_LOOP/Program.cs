using System;

namespace MB_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 56; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }

    internal class Todo
    {
        public static void LuckyNumbers()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {

                            if (i + j == k + l && n % (i + j) == 0)
                            {


                                Console.Write($"{i}{j}{k}{l} ");


                            }

                        }
                    }
                }
            }
        }

        public static void CarNumbers()
        {
            int startnum = int.Parse(Console.ReadLine());
            int endnum = int.Parse(Console.ReadLine());
            for (int a = startnum; a <= endnum; a++)
            {
                for (int b = startnum; b <= endnum; b++)
                {
                    for (int c = startnum; c <= endnum; c++)
                    {
                        for (int d = startnum; d <= endnum; d++)
                        {
                            if ((a % 2 == 0 && d % 2 != 0 && a > d && (b + c) % 2 == 0) || (a % 2 != 0 && d % 2 == 0 && a > d && (b + c) % 2 == 0))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }
        }
        public static void ChallengeTheWedding()
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int roomCapacity = int.Parse(Console.ReadLine());
            string total = "";

            int cnt = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    cnt++;
                    total += $"({i} <-> {j}) ";
                    if (cnt == roomCapacity)
                    {
                        break;
                    }
                }
                if (cnt == roomCapacity)
                {
                    break;
                }
            }
            Console.WriteLine(total);
        }


        public static void WeddingSeats()
        {
            char lastSector=char.Parse(Console.ReadLine());
            int rows=int.Parse(Console.ReadLine());
            int sec=int.Parse(Console.ReadLine());
            int cnt = 0;
            string word = "abcdefghijklmnopqrstuvwxyz";
            for (char start = 'A'; start <= lastSector; start++)
            {   
                
                for (int i = 1; i <= rows; i ++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j <sec+2; j++)
                        {
                            Console.WriteLine($"{start}{i}{word[j]}");
                            cnt++;
                        }
                    }
                    else
                    {
                        for (int k = 0; k <sec; k++)
                        {
                            Console.WriteLine($"{start}{i}{word[k]}");
                            cnt++;
                        }
                    }
                    
                }
                rows++;
            }
            Console.WriteLine(cnt);

        }

        public static void SecretDoorsLock()
        {
            int firstStep = int.Parse(Console.ReadLine());
            int secondStep = int.Parse(Console.ReadLine());
            int thStep=int.Parse(Console.ReadLine());
            for(int i = 1; i <=firstStep; i++)
            {
                for (int j = 1; j <=secondStep; j++)
                {
                    for (int k = 1; k <=thStep; k++)
                    {
                        if (isPrime(j))
                        {
                            if (i % 2 == 0 && k % 2 == 0 && j > 1&& j< 8)
                                Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
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

        public static void SafePasswordsGenerator()
        {

        }

    }
}

        

  

