using System;



namespace MBWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MB.AverageNumber();

        }

        
    }
    class MB
    {
        public static void ReportSystem()
        {
            double needMoney=double.Parse(Console.ReadLine());
            double currentMoney = 0;
            double cashPay = 0;
            double cardPay = 0;
            int cashCount = 0;
            int cardCount = 0;
            bool isCard=false;
            while (currentMoney < needMoney)
            {   
                string input=Console.ReadLine();
                
                if (input == "End")
                {
                    break;
                }
                double inpt = double.Parse(input);
                if (!isCard && inpt > 100)
                {
                        isCard=true;
                    Console.WriteLine("Error in transaction!");
                }
                else if (isCard && inpt < 10)
                {
                    isCard = false;
                    Console.WriteLine("Error in transaction!");
                }
                else if (!isCard)
                {
                    currentMoney += inpt;
                    cashPay += inpt;
                    cashCount++;
                    isCard = true;
                    Console.WriteLine("Product sold!");
                }
                else if (isCard)
                {
                    currentMoney += inpt;
                    cardPay +=inpt;
                    cardCount++;
                    isCard = false;
                    Console.WriteLine("Product sold!");
                }
            }
            if (currentMoney >= needMoney)
            {
                Console.WriteLine($"Average CS: {(cashPay / cashCount):f2}\nAverage CC: {(cardPay / cardCount):f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.") ;
            }
        }

     public static void test()
        {
            for (int i = 0; i < 10; i++)
            {
                char n = char.Parse(Console.ReadLine());
                if (CheckLatinLetters(n))
                {
                    Console.WriteLine("da");
                }
                else
                {
                    Console.WriteLine("ne");
                }
            }
       
        }

       public static void StreamOfLetters()
        {
            
        }

        public static bool CheckLatinLetters(char input)
        {
            string latin = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            bool isLatin = false;
            for (int index = 0; index < latin.Length; index++)
            {
                if (input == latin[index])
                {
                    isLatin = true;
                    break;
                }

            }
            if (isLatin)
            {
                return true;
            }

            else return false;

        }

        public static void n199()
        {
            int n = 0;
            while (n <99)
            {
                n++;
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                    
                }
            }
        }

        public static void AverageNumber()
        {
            int n = int.Parse(Console.ReadLine());
            double input = 0;
            int count = 0;
            double sum=0;
           
            while (count<n)
            {
                input=double.Parse(Console.ReadLine());
                count++;
                sum+=input;

            }
            Console.WriteLine($"{(sum/count):f2}");
        }
    }
}

