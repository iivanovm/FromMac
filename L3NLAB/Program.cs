using System;
using System.Collections;
using System.Collections.Generic;

namespace L3NLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l3ex.L3ex.FishBoad();
        }
    }
}
namespace l3ex
{
    public class L3ex
    {
        public static void NewHouse()
        {

            var dct = new Dictionary<string, double>
            {
                { "roses",3 },
                { "dahlias", 3.8 },
                {"tulips",2.80 },
                { "narcisus",3 },
                { "gladios",2.50 }
        };
            string FlowerType = Console.ReadLine();
            double FlowerNum = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double fl = 0.00;
            double total = 0.00;
            
            total = dct[FlowerType] * FlowerNum;
            Console.WriteLine(total);
        }

        public static void FishBoad()
        {
            double budget = double.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            double NumOfFishB=double.Parse(Console.ReadLine());
            var Sd = new Dictionary<string, double>
            {
                {"spring",3000.00 },
                {"summer",4200.00 },
                {"autumn",4200.00 },
                {"winter",2600.00 }
            };
            double sum=0.00;
            sum = Sd[Season.ToLower()];
            switch (NumOfFishB)
            {
                case <= 6:sum = sum-(sum * 0.1);break;
                case double n when (n >7 && n <= 11):sum= sum - (sum * 0.15); break;
                case > 12: sum=sum - (sum * 0.25); break;
            }
            if(NumOfFishB%2==0&& Season.ToLower() != "autumn")
            {
                sum = sum - (sum * 0.05);
            }
            else
            {
                sum = sum;
            }
           
            if (sum <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - sum).ToString("0.00")} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - sum).ToString("0.00")} leva.");
            }
        }
    }
}