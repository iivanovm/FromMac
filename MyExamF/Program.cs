using System;

namespace MyExamF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyExam.CourierExpress();
        }
    }

    public class MyExam
    {
        public static void CatDiet()
        {
            double precentOfm = double.Parse(Console.ReadLine());
            double precentofp = double.Parse(Console.ReadLine());
            double precentofv = double.Parse(Console.ReadLine());
            int total = int.Parse(Console.ReadLine());
            double precentofwater = double.Parse(Console.ReadLine());
            double totalmazn = (total * precentOfm) / 9;
            double totalprot = (total * precentofp) / 4;
            double totalvagl = (total * precentofv) / 4;
            double eatTotal = totalmazn + totalprot + totalvagl;
            double totalCal = total / eatTotal;
            totalCal *= 100-precentofwater;
            Console.WriteLine($"{totalCal:f4}");

        }

        public static void MaidenParty()
        {
            double totalPartyCost=double.Parse(Console.ReadLine());
            int loveString = int.Parse(Console.ReadLine());
            int roseNum=int.Parse(Console.ReadLine());
            int keychainNUm=int.Parse(Console.ReadLine());
            int cariNum = int.Parse(Console.ReadLine());
            int luckyNum=int.Parse(Console.ReadLine());
            double TotalSum = (loveString * 0.60) + (roseNum * 7.20) + (keychainNUm * 3.60) + (cariNum * 18.20) + (luckyNum * 22.00);
            if ((loveString + roseNum + keychainNUm + cariNum + luckyNum) >= 25)
            {
                TotalSum -= TotalSum* 0.35;
            }
            
                TotalSum -=TotalSum* 0.10;
            Console.WriteLine(TotalSum >= totalPartyCost ? $"Yes! {TotalSum - totalPartyCost:f2} lv left.":$"Not enough money! {Math.Abs(TotalSum - totalPartyCost):f2} lv needed.");
        }

        public static void CourierExpress()
        {
            double packVol = double.Parse(Console.ReadLine());
            string serviceType=Console.ReadLine();
            int km=int.Parse(Console.ReadLine());
            double TotalPrice = 0;
            switch (serviceType)
            {
                case "standard":
                    if (packVol < 1)
                    {
                        TotalPrice = km * 0.03;
                    }
                    else if (packVol >1 && packVol < 10)
                    {
                        TotalPrice = km * 0.05;
                    }
                    else if (packVol >= 10 && packVol <40)
                    {
                        TotalPrice = km * 0.10;
                    }
                    else if (packVol >= 40 && packVol < 90)
                    {
                        TotalPrice = km * 0.15;
                    }
                    else if (packVol >= 90 && packVol <150)
                    {
                        TotalPrice = km * 0.20;
                    }
                    break;
                case "express":
                    if (packVol < 1)
                    {
                        TotalPrice = km * 0.03;
                        double cprice = (0.03 * 0.80) * packVol;
                        cprice *= km;
                        TotalPrice += cprice;
                    }
                    else if (packVol > 1 && packVol < 10)
                    {
                        TotalPrice = km * 0.05;
                        double cprice = (0.05 * 0.40) * packVol;
                        cprice *= km;
                        TotalPrice += cprice;
                    }
                    else if (packVol >= 10 && packVol <40)
                    {
                        TotalPrice = km * 0.10;
                        double cprice = (0.10 * 0.05) * packVol;
                        cprice *= km;
                        TotalPrice += cprice;
                    }
                    else if (packVol >= 40 && packVol < 90)
                    {
                        TotalPrice = km * 0.15;
                        double cprice = (0.15 * 0.02) * packVol;
                        cprice *= km;
                        TotalPrice+=cprice;
                    }
                    else if (packVol >= 90 && packVol <150)
                    {
                        TotalPrice = km * 0.20;
                        double cprice = (0.20 * 0.01) * packVol;
                        cprice *= km;
                        TotalPrice += cprice;
                    }
                    break;
            }
            Console.WriteLine($"The delivery of your shipment with weight of {packVol:f3} kg. would cost {TotalPrice:f2} lv.");
        }

        public static void GrandpaStavri()
        {
            int daysNUm = int.Parse(Console.ReadLine());
            double AlcVol= 0;
            double AlcDegree = 0;
            double sumVol=0;
            double SumDegree=0;
        
            for (int i = 1; i <=daysNUm; i++)
            {
                AlcVol = double.Parse(Console.ReadLine());
                AlcDegree = double.Parse(Console.ReadLine());
                sumVol += AlcVol;
                SumDegree += AlcVol * AlcDegree;
            }
            double avgDeegree = SumDegree /sumVol ;
            Console.WriteLine($"Liter: {sumVol:f2}\nDegrees: {avgDeegree:f2}");
            if (avgDeegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avgDeegree>=38&& avgDeegree < 42)
            {
                Console.WriteLine("Super!");
            }
            else if (avgDeegree > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }

        public static void Everest()
        {
            string withNights= Console.ReadLine();
            int daysnum = 1;
            int total = 5364;
            bool isFinish=false;

            while(withNights!="END")
            {
                if (withNights == "Yes")
                {
                    daysnum++;
                }
                if (daysnum > 5)
                {
                    break;
                }
                int currenth = int.Parse(Console.ReadLine());                
                total += currenth;
               

                if (total >= 8848)
                {
                    isFinish = true;
                    break;
                }
                withNights = Console.ReadLine();

            }
            if (isFinish)
            {
                Console.WriteLine($"Goal reached for {daysnum} days!");
            }
            else
            {
                Console.WriteLine($"Failed!\n{total}");
            }
            
        }

        public static void MultiplyTable()
        {
            string num = Console.ReadLine();
            int firstnum = int.Parse(num[2].ToString());
            int secondnum = int.Parse(num[1].ToString());
            int thirdnum = int.Parse(num[0].ToString());
            for (int i = 1; i <=firstnum; i++)
            {
                for (int j=1; j <=secondnum; j++)
                {
                    for (int k=1; k <=thirdnum; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k};");
                    }
                }
            }
        }
    }
}
