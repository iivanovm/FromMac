using System;

namespace NestetLoops_Exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainTheTrainers(); 
        }

        public static void NumberPyramid()
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        public static void EqualSumsEvenOddPosition()
        {
            int startnum = int.Parse(Console.ReadLine());
            int endnum = int.Parse(Console.ReadLine());

            for (int start = startnum; start <= endnum; start++)
            {

                string CurrentNum = start.ToString();
                int evensum = 0;
                int oddsum = 0;
                for (int num = 0; num < CurrentNum.Length; num++)
                {
                    int CurrentToInt = int.Parse(CurrentNum[num].ToString());
                    if (num % 2 == 0)
                    {
                        evensum += CurrentToInt;
                    }
                    else
                    {
                        oddsum += CurrentToInt;
                    }
                }
                if (evensum == oddsum)
                {
                    Console.WriteLine(start);
                }
            }

        }

        public static void SumPrimeNonPrime()
        {
            string input = Console.ReadLine();
            bool isprime = false;
            int sumprime = 0;
            int sumnoprime = 0;

            while (input != "stop")
            {
                int n = int.Parse(input);
                if (n < 0)
                {
                    n = 0;
                    Console.WriteLine("Number is negative.");

                }

                else if (n == 1)
                {
                    isprime = false;
                }
                else
                {
                    for (int count = 2; count < n; count++)
                    {
                        if (n % count != 0)
                        {
                            isprime = true;

                        }
                        else if (n % count == 0 && (count != n || count != 1))

                        {
                            isprime = false;

                            break;
                        }
                    }

                }
                if (isprime)
                {
                    sumprime += n;
                }
                else if (isprime == false)
                {
                    sumnoprime += n;
                }
                input = Console.ReadLine();
            }
            if (input == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {sumprime}");
                Console.WriteLine($"Sum of all non prime numbers is: {sumnoprime}");
            }
        }

        public static void TrainTheTrainers()
        {
            string presentationName=Console.ReadLine();
            double avgScore=0;
            int cnt=0;
            int cnsc = 0;
            double sum = 0;
            double sum1 = 0;
            while (presentationName != "Finish")
            {
                cnt++; 
                int juryNum = int.Parse(Console.ReadLine());
                for (int score = 1; score <= juryNum; score++)
                {
                    cnsc++;
                    double scr=double.Parse(Console.ReadLine());
                    sum+=scr;

                }
                sum1 += sum;
                sum = 0;
                cnsc = 0;
                Console.WriteLine($"{presentationName} - {(sum/cnsc):f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(sum1/cnt):f2}.");
        }
    }
}

