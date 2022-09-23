using System;

namespace PBOE232019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.VetParking();
        }
    }

    public class ToJudge
    {
        public static void FruitMarket()
        {
            double jprice = double.Parse(Console.ReadLine());
            double bananaNum = double.Parse(Console.ReadLine());
            double ponum = double.Parse(Console.ReadLine());
            double manum = double.Parse(Console.ReadLine());
            double jnum = double.Parse(Console.ReadLine());
            double maprice = jprice / 2;
            double poprice = maprice - (maprice * 0.40);
            double banprice = maprice - (maprice * 0.80);
            double total = (jprice * jnum) + (bananaNum * banprice) + (ponum * poprice) + (manum * maprice);
            Console.WriteLine($"{total:f2}");
        }

        public static void Safari()
        {
            double budget = double.Parse(Console.ReadLine());
            double litre = double.Parse(Console.ReadLine()) * 2.10;
            string day = Console.ReadLine();
            double totalm = litre + 100;
            if (day == "Sunday")
            {
                totalm -= totalm * 0.20;
            }
            else if (day == "Saturday")
            {
                totalm -= totalm * 0.10;
            }
            Console.WriteLine(totalm <= budget ? $"Safari time! Money left: {budget - totalm:f2} lv." : $"Not enough money! Money needed: {totalm - budget:f2} lv.");
        }

        public static void Mobileoperator()
        {
            string contractdt = Console.ReadLine();
            string constactType=Console.ReadLine();
            string withLte=Console.ReadLine();
            int month=int.Parse(Console.ReadLine());
            double totalSumPay = 0;
            switch (contractdt)
            {
                case "one":
                    if (constactType == "Small")
                    {
                        totalSumPay = month * 9.98;
                    }
                    else if (constactType == "Middle")
                    {
                        totalSumPay = month * 18.99;
                    }
                    else if (constactType == "Large")
                    {
                        totalSumPay = month * 25.98;
                    }
                    else if (constactType == "ExtraLarge")
                    {
                        totalSumPay = month * 35.99;
                    }
                    break;
                case "two":
                    if (constactType == "Small")
                    {
                        totalSumPay = month * 8.58;
                    }
                    else if (constactType == "Middle")
                    {
                        totalSumPay = month * 17.09;
                    }
                    else if (constactType == "Large")
                    {
                        totalSumPay = month * 23.59;
                    }
                    else if (constactType == "ExtraLarge")
                    {
                        totalSumPay = month * 31.79;
                    }

                    

                    break;
            }
            if (withLte == "yes")
            {
                if (constactType == "Small")
                {
                    totalSumPay += month * 5.50;
                }
                else if (constactType == "Middle" || constactType == "Large")
                {
                    totalSumPay += month * 4.35;
                }
                else if (constactType == "ExtraLarge")
                {
                    totalSumPay += month * 3.85;
                }
            }
            if (contractdt == "two")
            {
                totalSumPay -= totalSumPay * 0.0375;
            }
            Console.WriteLine($"{totalSumPay:f2} lv.");
        }

        public static void TouristShop()
        {
            double budget = double.Parse(Console.ReadLine());
            string prname;
            bool isNotEnoughtMoney=false;
            double totalSum = 0;
            int cnt=0;
            int tcnt = 0;
            while ((prname=Console.ReadLine())!= "Stop")
            {
                double productPrice=double.Parse(Console.ReadLine());
                cnt++;
                tcnt++;
                if (cnt == 3)
                {
                    productPrice /= 2;
                    cnt = 0;
                }
                totalSum+=productPrice;
                if (totalSum > budget)
                {
                    isNotEnoughtMoney=true;
                    break;
                }

            }
            if (isNotEnoughtMoney)
            {
                Console.WriteLine($"You don't have enough money!\nYou need {(totalSum-budget):f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {tcnt} products for {totalSum:f2} leva.");
            }
        }

        public static void DivisionWithoutRemainder()
        {
            int numberOfNum=int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2= 0;
            int p3 = 0;
            string p1c = string.Empty;
            string p2c = string.Empty;
            string p3c = string.Empty;
            for (int start=0; start<numberOfNum; start++)
            {
                int cNum = int.Parse(Console.ReadLine());
                if (cNum % 2 == 0)
                {
                    p1++;
                    p1c += cNum.ToString()+",";
                }
                if (cNum % 3 == 0)
                {
                    p2++;
                    p2c += cNum.ToString() + ",";
                }
                 if (cNum % 4 == 0)
                {
                    p3++;
                    p3c += cNum.ToString() + ",";
                }
            }
            Console.WriteLine($"{((double)p1/numberOfNum)*100:f2}%\n{((double)p2 /numberOfNum)*100:f2}%\n{((double)p3 /numberOfNum)*100:f2}%");
           
        }

        public static void VetParking()
        {
            int daysNum = int.Parse(Console.ReadLine());
            int hoursNum = int.Parse(Console.ReadLine());
            double dayTotal = 0;
            double total = 0;
            for (int i=1; i<=daysNum; i++)
            {
                for (int j=1; j<=hoursNum; j++)
                {
                    if(i%2== 0 && j % 2 != 0)
                    {
                        dayTotal += 2.50;
                       
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        dayTotal += 1.25;
                    }
                    else
                    {
                        dayTotal += 1.00;
                    }
                }
                Console.WriteLine($"Day: {i} - {dayTotal:f2} leva");
                total+=dayTotal;
                dayTotal = 0;
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
