using System;

namespace PBOE672019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.TravelAgency();
        }
    }

    internal class ToJudge
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
        public static void PoolDay()
        {
            int humanNum = int.Parse(Console.ReadLine());
            double EntryTax = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());
            double sunbedNum = Math.Ceiling(humanNum * 0.75);
            double umbrellaNum = Math.Ceiling(humanNum / 2.00);
            Console.WriteLine($"{(humanNum * EntryTax) + (sunbedPrice * sunbedNum) + (umbrellaPrice * umbrellaNum):f2} lv.");
        }

        public static void FamilyTrip()
        {
            double budget = double.Parse(Console.ReadLine());
            int nightNum = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int pothermoney = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (nightNum > 7)
            {
                pricePerNight -= pricePerNight * 0.05;
            }
            totalPrice = (double)nightNum * pricePerNight + (budget * ((double)pothermoney / 100));
            Console.WriteLine(totalPrice <= budget ? $"Ivanovi will be left with {(budget - totalPrice):f2} leva after vacation." : $"{totalPrice - budget:f2} leva needed.");
        }

        public static void CoffeeMachine()
        {
            string drinkName = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinkNum = int.Parse(Console.ReadLine());
            double EndPrice = 0.00;
            switch (drinkName)
            {
                case "Espresso":
                    if(sugar== "Without")
                    {
                        EndPrice += drinkNum * 0.90;
                    }
                    else if (sugar == "Normal")
                    {
                        EndPrice += drinkNum * 1.00;
                    }
                    else if (sugar == "Extra")
                    {
                        EndPrice += drinkNum * 1.20;
                    }break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        EndPrice += drinkNum * 1.00;
                    }
                    else if (sugar == "Normal")
                    {
                        EndPrice += drinkNum * 1.20;
                    }
                    else if (sugar == "Extra")
                    {
                        EndPrice += drinkNum * 1.60;
                    } break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        EndPrice += drinkNum *0.50;
                    }
                    else if (sugar == "Normal")
                    {
                        EndPrice += drinkNum * 0.60;
                    }
                    else if (sugar == "Extra")
                    {
                        EndPrice += drinkNum * 0.70;
                    }break;
            }
            if (sugar == "Without")
            {
                EndPrice -= EndPrice * 0.35;
            }
            if (drinkNum >= 5 && drinkName == "Espresso")
            { EndPrice -= EndPrice * 0.25; }

            if (EndPrice > 15)
            {
                EndPrice -= EndPrice * 0.20;
            }
            


            Console.WriteLine($"You bought {drinkNum} cups of {drinkName} for {EndPrice:f2} lv.");
        }
        public static void club()
        {
            double budget = double.Parse(Console.ReadLine());
            string cname = string.Empty;
            double totalsum = 0.00;
            double currentsum = 0.00;
            while (totalsum < budget && (cname = Console.ReadLine()) != "Party!")
            {
                int price = cname.Length;
                int num = int.Parse(Console.ReadLine());
                currentsum += num * price;
                if (num * price % 2 != 0)
                {
                    currentsum -= currentsum * 0.25;
                }
                totalsum += currentsum;
                currentsum = 0;
            }
            if (cname == "Party!")
            {
                Console.WriteLine($"We need {Math.Abs(budget - totalsum):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {totalsum:f2} leva.");
        }

        public static void Renovation()
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double totalforpaint = h * w * 4.00;
            double notPaintPrecent = int.Parse(Console.ReadLine());
            string paint = string.Empty;
            totalforpaint -= totalforpaint / 100 * notPaintPrecent;
            totalforpaint = Math.Ceiling(totalforpaint);
            while (totalforpaint >= 0 && (paint = Console.ReadLine()) != "Tired!")
            {
                double cPaint = double.Parse(paint);
                totalforpaint -= cPaint;
                //if (totalforpaint <= 0)
                //{
                //    break;
                //}

            }
            if (paint == "Tired!")
            {
                Console.WriteLine($"{totalforpaint} quadratic m left.");
            }
            else if (totalforpaint == 0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(totalforpaint)} l paint left!");
            }
        }

        public static void PCGameShop()
        {
            int gameNum = int.Parse(Console.ReadLine());
            int hpoint = 0;
            int fpoint = 0;
            int opoint = 0;
            int otpint = 0;
            for (int i = 1; i <= gameNum; i++)
            {
                string product = Console.ReadLine();
                switch (product)
                {
                    case "Hearthstone": hpoint++; break;
                    case "Fornite": fpoint++; break;
                    case "Overwatch": opoint++; break;
                    default: otpint++; break;
                }
            }
            Console.WriteLine($"Hearthstone - {((double)hpoint / gameNum * 100):f2}%\nFornite - {(double)fpoint / gameNum * 100:f2}%\nOverwatch - {(double)opoint / gameNum * 100:f2}%\nOthers - {(double)otpint / gameNum * 100:f2}%");
        }

        public static void FootballTournament()
        {
            string teamName=Console.ReadLine();
            int matchNum=int.Parse(Console.ReadLine());
            char result;
            int tPoint=0;
            int wcount=0;
            int dcount=0;
            int lcount = 0;
            if (matchNum == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
                return;
            }
            for (int match=0; match<matchNum; match++)
            {
               result=char.Parse(Console.ReadLine());
                switch (result)
                {
                    case 'W':tPoint += 3;wcount++; break;
                    case 'D':tPoint += 1;dcount++; break;
                    case 'L':tPoint += 0;lcount++; break;
                }

            }
            Console.WriteLine($"{teamName} has won {tPoint} points during this season.\nTotal stats:\n## W: {wcount}\n## D: {dcount}\n## L: {lcount}\nWin rate: {((double)wcount/matchNum*100):f2}%"
);
        }

        public static void NameGame()
        {
            string playerName;
            int currentpoint = 0;
            int maxpoint = int.MinValue;
            string MaxPlname = string.Empty ;
            while ((playerName=Console.ReadLine())!= "Stop")
            {
                currentpoint=ASCIItoC(playerName, 10, 2);
                if (currentpoint >=maxpoint)
                {
                    maxpoint = currentpoint;
                    MaxPlname = playerName;
                    currentpoint = 0;
                } 
            }
            Console.WriteLine($"The winner is {MaxPlname} with {maxpoint} points!");
            
        }

        public static void TheMostPowerfulWord()
        {
            string word;
            double MaxSum = 0.00;
            double currentpoint = 0.00;
            string MaxWord=string.Empty ;
            string ido = "aeiouyAEIOUY";
            bool isFind = false;
            while ((word=Console.ReadLine())!= "End of words")
            {
                currentpoint+=FromChToInt(word);
                isFind = (FindCharinString(ido, word, 0, 1));
                if (isFind)
                {
                    currentpoint*=word.Length;
                }
                else if (!isFind)
                {
                   currentpoint/=word.Length;
                    currentpoint=Math.Floor(currentpoint);
                }
                if (currentpoint > MaxSum)
                {
                    MaxSum = currentpoint;
                    MaxWord=word;
                   
                }
                currentpoint = 0;
            }
            Console.WriteLine($"The most powerful word is {MaxWord} - {Math.Floor(MaxSum)}");
        }

        public static void TravelAgency()
        {
            string cityName = Console.ReadLine();
            string packType = Console.ReadLine();
            string vip = Console.ReadLine();
            int daysNum = int.Parse(Console.ReadLine());
            double TotalPRice = 0.00;

            if (daysNum < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (daysNum >= 7)
            {
                daysNum -= 1;
            }
            if (cityName == "Bansko" || cityName == "Borovets")
            {
                switch (packType)
                {
                    case "withEquipment": 
                        if(vip== "yes")
                        {
                            TotalPRice = 100.00-(100.00 * 0.10);
                        }
                        else
                        {
                            TotalPRice = 100.00;
                        }
                        break;
                    case "noEquipment":
                        if (vip == "yes")
                        {
                            TotalPRice = 80.00 - (80.00 * 0.05);
                        }
                        else
                        {
                            TotalPRice = 80.00;
                        }
                        break;
                    default: Console.WriteLine("Invalid input!");break;
                }
                
                Console.WriteLine($"The price is {TotalPRice * daysNum:f2}lv! Have a nice time!");
            }
            else if (cityName == "Varna" || cityName == "Burgas")
            {
                switch (packType)
                {
                    case "withBreakfast":
                        if (vip == "yes")
                        {
                            TotalPRice = 130.00 - (130.00 * 0.12);
                        }
                        else
                        {
                            TotalPRice = 130.00;
                        }
                        break;
                    case "noBreakfast":
                        if (vip == "yes")
                        {
                            TotalPRice = 100.00 - (100.00 * 0.05);
                        }
                        else
                        {
                            TotalPRice = 100.00;
                        }
                        break;
                    default: Console.WriteLine("Invalid input!"); break;
                }

                Console.WriteLine($"The price is {TotalPRice * daysNum:f2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }
        internal static int FromChToInt(string input)
        {
            int current=0;
            foreach(char c in input)
            {
                current+=Convert.ToInt32(c);
            }
            return current;
        }
        internal static  bool FindCharinString(string searchstring , string stringinfind,int start,int num)
        {
            bool found = false;
            foreach (char c in searchstring)
            {
                
                if (c.ToString() == stringinfind.Substring(start, num))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static int ASCIItoC(string Pname,int p1, int p2)
        {
            int currentpoint=0;
            foreach (char c in Pname)
            {
                int cr = int.Parse(Console.ReadLine());
                if (Convert.ToChar(c) == cr)
                {
                    currentpoint += p1;
                }
                else
                {
                    currentpoint += p2;
                }
            }
            return currentpoint;
        }

    }
}
