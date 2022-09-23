using System;

namespace UnFinishTaskPBOE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.EqualPairs();
        }
    }

    internal class ToJudge
    {
        internal static bool isLatinAlpha(string name)
        {
            char c = Convert.ToChar(name);
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void TravelAgency()
        {
            string destinationName = Console.ReadLine();
            string packType = Console.ReadLine();
            string VIP = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            var choice = Tuple.Create(destinationName + packType + VIP);
            bool isfail = false;
            double totalPrice = 0;
            if (days > 7)
            {
                days -= 1;
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                isfail = true;
                return;
            }
            switch (choice.Item1)
            {
                case "BanskonoEquipmentno": totalPrice = days * 80.00; break;
                case "BanskonoEquipmentyes": totalPrice = (days * 80.00); totalPrice -= totalPrice * 0.05; break;
                case "BanskowithEquipmentno": totalPrice = days * 100.00; break;
                case "BanskowithEquipmentyes": totalPrice = (days * 100.00); totalPrice -= totalPrice * 0.10; break;
                case "BorovetsnoEquipmentno": totalPrice = days * 80.00; break;
                case "BorovetsnoEquipmentyes": totalPrice = (days * 80.00); totalPrice -= totalPrice * 0.05; break;
                case "BorovetswithEquipmentno": totalPrice = days * 100.00; break;
                case "BorovetswithEquipmentyes": totalPrice = (days * 100.00); totalPrice -= totalPrice * 0.10; break;
                case "VarnanoBreakfastno": totalPrice = days * 100.00; break;
                case "VarnanoBreakfastyes": totalPrice = (days * 100.00); totalPrice -= totalPrice * 0.07; break;
                case "VarnawithBreakfastno": totalPrice = days * 130.00; break;
                case "VarnawithBreakfastyes": totalPrice = (days * 130.00); totalPrice -= totalPrice * 0.12; break;
                case "BurgasnoBreakfastno": totalPrice = days * 100.00; break;
                case "BurgasnoBreakfastyes": totalPrice = (days * 100.00); totalPrice -= totalPrice * 0.07; break;
                case "BurgaswithBreakfastno": totalPrice = days * 130.00; break;
                case "BurgaswithBreakfastyes": totalPrice = (days * 130.00); totalPrice -= totalPrice * 0.12; break;
                default: Console.WriteLine("Invalid input!"); isfail = true; break;
            }
            if (isfail)
            {
                return;
            }
            else
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
        }

        public static void StreamOfLettersMe()
        {
            string word = string.Empty;
            bool ccount = false;
            bool ocount = false;
            bool ncount = false;
            string magic = string.Empty;
            while ((word = Console.ReadLine()) != "End")
            {
                if (ccount && ocount && ncount)
                {
                    Console.Write(magic + " ");
                    magic = string.Empty;
                    ocount = false;
                    ncount = false;
                    ccount = false;
                }
                char to = Convert.ToChar(word);
                if ((to >= 65 && to <= 90) || (to >= 97 && to <= 122))
                {
                    if (word == "c" && ccount == false)
                    {
                        ccount = true;
                        continue;
                    }
                    else if (word == "o" && ocount == false)
                    {
                        ocount = true;
                        continue;
                    }
                    else if (word == "n" && ncount == false)
                    {
                        ncount = true;
                        continue;
                    }

                    magic += to;
                }
                else
                {
                    continue;
                }
            }

        }

        public static void Pets()
        {
            int daysNum = int.Parse(Console.ReadLine());
            int totalfood = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine()) / 1000.00;
            double food = 0.00;
            food = daysNum * (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay);
            Console.WriteLine(food <= totalfood ? $"{Math.Floor(totalfood - food)} kilos of food left." : $"{Math.Ceiling(food - totalfood)} more kilos of food are needed.");
        }

        public static void FuelTankPart2()
        {
            string fueloType = Console.ReadLine();
            double fueloNum = double.Parse(Console.ReadLine());
            string withCard = Console.ReadLine();
            var conditional = Tuple.Create(fueloType + withCard);
            double TotalPrice = 0.00;
            switch (conditional.Item1)
            {
                case "GasYes": TotalPrice = (0.93 - 0.08) * fueloNum; break;
                case "GasNo": TotalPrice = 0.93 * fueloNum; break;
                case "GasolineYes": TotalPrice = (2.22 - 0.18) * fueloNum; break;
                case "GasolineNo": TotalPrice = 2.22 * fueloNum; break;
                case "DieselYes": TotalPrice = (2.33 - 0.12) * fueloNum; break;
                case "DieselNo": TotalPrice = 2.33 * fueloNum; break;
            }
            if (fueloNum > 20 && fueloNum <= 25)
            {
                TotalPrice -= TotalPrice * 0.08;
            }
            else if (fueloNum > 25)
            {
                TotalPrice -= TotalPrice * 0.10;
            }

            Console.WriteLine($"{TotalPrice:f2} lv.");
        }

        public static void Harvest()
        {
            double Xland = double.Parse(Console.ReadLine());
            double Yvol = double.Parse(Console.ReadLine());
            double ZwineL = double.Parse(Console.ReadLine());
            double numworkers = double.Parse(Console.ReadLine());
            double wrkland = Xland * Yvol * 0.4;
            double winehave = wrkland / 2.5;
            if (winehave < ZwineL)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(ZwineL - winehave)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(winehave)} liters.\n{Math.Ceiling(winehave - ZwineL)} liters left -> {Math.Ceiling((winehave - ZwineL) / numworkers)} liters per person.");
            }

        }

        public static void TransportPrice()
        {
            double n = double.Parse(Console.ReadLine());
            string whn = Console.ReadLine();
            double sum = 0;
            if (n < 20)
            {
                if (whn == "day")
                {
                    sum = 0.7 + n * 0.79;
                }
                else
                {
                    sum = 0.7 + n * 0.9;

                }
            }
            else if (n < 100)
            {
                sum = n * 0.09;
            }
            else
            {
                sum = (n * 0.06);
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static void SafePasswordsGenerator()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int numofPassword = int.Parse(Console.ReadLine());
            int cnt = 0;
            int i = 35;
            int j = 64;

            for (int k = 1; k <= a; k++)
            {

                for (int l = 1; l <= b; l++)
                {
                    cnt++;
                    if (cnt > numofPassword)
                    {
                        return;
                    }
                    Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                    i++; j++;

                    if (i >= 55) { i = 35; }
                    if (j >= 96) { j = 64; }
                }
            }


        }

        public static void BirthdayParty()
        {
            double roomPrice = double.Parse(Console.ReadLine());
            double cakePrice = roomPrice * 0.20;
            double dringPrice = cakePrice - (cakePrice * 0.45);
            double animatePrice = roomPrice / 3;
            Console.WriteLine(roomPrice + cakePrice + dringPrice + animatePrice);
        }

        public static void Cinema()
        {
            int roomCapacity = int.Parse(Console.ReadLine());
            int totalSum = 0;
            string guestnum = string.Empty;
            bool isFinish=false;
            while ((guestnum = Console.ReadLine()) != "Movie time!")
            {
                int num = int.Parse(guestnum);
                roomCapacity -= num;
                if (roomCapacity < 0)
                { 
                    isFinish = true;
                    break;
                }
                if (num % 3 == 0)
                {
                    int currentsum = 5 * num - 5;
                    totalSum += currentsum;
                }
                else
                {
                    totalSum += 5 * num;
                }
            }
            if(guestnum== "Movie time!")
            {
                Console.WriteLine($"There are {roomCapacity} seats left in the cinema.");
            }
            else if (isFinish)
            {
                Console.WriteLine("The cinema is full.");
            }
            Console.WriteLine($"Cinema income - {totalSum} lv.");
        }

        public static void EqualPairs()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            int min = 0;
            int num1 = 0;
            int num2 = 0;
            int sum1=0;
            for (int i = 0; i < n; i++)
            {
                 num1 = int.Parse(Console.ReadLine());
                 num2 = int.Parse(Console.ReadLine());
                sum=num1 + num2;
                if (i > 0)
                {
                    max = Math.Abs(sum1 - sum);
                }
                sum1 = sum;
            }
            if (min == max)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(max - min)}");
            }
        }
    }
}

