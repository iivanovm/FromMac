using System;

namespace MBForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MB.LuckyNumbers();
        }
    }
    internal class MB
    {
        public static void OddEvenPosition()
        {
            int n=int.Parse(Console.ReadLine());
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double oddSum = 0;
            for (int i=1; i<=n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += input;
                    if (input > evenMax)
                    {
                        evenMax=input;
                    }
                    if(input < evenMin)
                    {
                        evenMin=input;
                    }
                }
                else if(i%2!=0)
                {
                    oddSum+=input;
                    if (input > oddMax)
                    {
                        oddMax = input;
                    }
                     if (input < oddMin)
                    {
                        oddMin = input;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine(oddMin==double.MaxValue? "OddMin=No," : $"OddMin={oddMin:f2},");
            Console.WriteLine(oddMax==double.MinValue? "OddMax=No," : $"OddMax={oddMax:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine(evenMin==double.MaxValue? "EvenMin=No," : $"EvenMin={evenMin:f2},");
            Console.WriteLine(evenMax==double.MinValue? "EvenMax=No" : $"EvenMax={evenMax:f2}");         
        }

        public static bool primeNotPrime(int num)
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

        public static void pin()
        {
            int firstnum=int.Parse(Console.ReadLine());
            int secondnum=int.Parse(Console.ReadLine());
            int thirdnum=int.Parse(Console.ReadLine());
            string pin=string.Empty;
            for (int fn=1; fn<=firstnum; fn++)
            {
                for (int sn = 1; sn <= secondnum; sn++)
                {
                    for (int tn=1; tn<=thirdnum; tn++)
                    {
                        bool isPrime = primeNotPrime(sn);
                        if (fn % 2 == 0 && isPrime && sn > 1 && tn % 2 == 0)
                        {
                            pin = fn.ToString()+" "+sn.ToString()+" "+tn.ToString();
                            Console.WriteLine(pin);
                        }

                    }
                }
            }
        }

        public static void LettersCombinations()
        {
            char first = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char not = char.Parse(Console.ReadLine());
            int cnt = 0;
            for (char i = first; i <=two; i++)
            {
                for (char k = first; k <=two; k++)
                {
                    for (char l = first; l <=two; l++)
                    {
                        if (i == not || k == not || l == not)
                        {

                        }
                        else
                        {   cnt++;
                            Console.Write($"{i}{k}{l} ");
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }

        public static void LuckyNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 1; k < n; k++)
                    {
                        for (int l = 1; l < n; l++)
                        {
                            
                            
                            if (i+j == k+l)
                            {
                                if ((i+j)%n == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
