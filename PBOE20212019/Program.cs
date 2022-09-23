using System;

namespace PBOE20212019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.EasterBakery();
        }
    }

    public class ToJudge
    {
        public static void EasterLunch()
        {
            int k = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{(k*3.20)+(j * 4.35)+(j*12*0.15)+(c*5.40):f2}");
        }

        public static void EasterBakery()
        {
            double flourPrice=double.Parse(Console.ReadLine());
            double flourVol=double.Parse(Console.ReadLine());
            double sugarPrice = flourPrice - (flourPrice * 0.25);
            double sugarVol=double.Parse(Console.ReadLine());
            double eggPrice = flourPrice + (flourPrice * 0.10);
            double eggNum=double.Parse(Console.ReadLine());
            double yeastPrice = sugarPrice - (sugarPrice * 0.80);
            double yeastNum=double.Parse(Console.ReadLine());
            Console.WriteLine($"{((flourPrice*flourVol)+(sugarPrice*sugarVol)+(eggNum*eggPrice)+(yeastPrice*yeastNum)):f2}");
        }
    }
}
