using System;

namespace UnFinishTaskPBOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.StreamOfLetters();
        }
    }

    internal class ToJudge
    {
        public static void Cinema()
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());
            string inc;
            double TotalSum = 0;
            int totalSeatsNum = 0;
            while ((inc = Console.ReadLine()) != "Movie time!")
            {
                int peopleNum = int.Parse(inc);

                if (peopleNum % 3 == 0)
                {
                    TotalSum += (5 * peopleNum) - 5;
                    totalSeatsNum += peopleNum;
                }
                else
                {
                    TotalSum += 5 * peopleNum;
                    totalSeatsNum += peopleNum;
                }
                if (cinemaCapacity < totalSeatsNum)
                {
                    break;
                }
            }
            if (inc == "Movie time!")
            {
                Console.WriteLine($"There are {cinemaCapacity - totalSeatsNum} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {TotalSum} lv.");
            }
            else
            {
                Console.WriteLine(cinemaCapacity > totalSeatsNum ? $"There are {cinemaCapacity - totalSeatsNum} seats left in the cinema." : $"The cinema is full.");
                Console.WriteLine($"Cinema income - {TotalSum} lv.");
            }

        }

        public static void PasswordGeneratorTrue()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int ch1 = 1; ch1 <= n; ch1++)
            {
                for (int ch2 = 1; ch2 <= n; ch2++)
                {
                    for (int ch3 = 0; ch3 < l; ch3++)
                    {
                        for (int ch4 = 0; ch4 < l; ch4++)
                        {
                            for (int ch5 = Math.Max(ch1, ch2) + 1; ch5 <= n; ch5++)
                            {
                                Console.Write($"{ch1}{ch2}{(char)(97 + ch3)}{(char)(97 + ch4)}{ch5} ");
                            }
                        }
                    }
                }
            }
        }

        public static void ChangeBureau()
        {
            decimal bitcoin = decimal.Parse(Console.ReadLine());
            decimal kioan = decimal.Parse(Console.ReadLine());
            decimal comis = decimal.Parse(Console.ReadLine());
            decimal total = 0.00m;
            total = (bitcoin * 1168) + ((kioan * 0.15m) * 1.76m);
            total /= 1.95m;
            total -= total * (comis / 100);
            Console.WriteLine($"{total:f2}");
        }
        public static void TrekkingMania()
        {
            double groupnum = double.Parse(Console.ReadLine());
            double totalnum = 0.00;
            double M = 0;
            double MM = 0;
            double KK = 0;
            double k2 = 0;
            double EV = 0;

            for (int i = 0; i < groupnum; i++)
            {
                double n = double.Parse(Console.ReadLine());
                totalnum += n;
                if (n <= 5)
                {
                    M += n;
                }
                else if (n >= 6 && n <= 12)
                {
                    MM += n;
                }
                else if (n >= 13 && n <= 25)
                {
                    KK += n;
                }
                else if (n >= 26 && n <= 40)
                {
                    k2 += n;
                }
                else if (n >= 41)
                {
                    EV += n;
                }
            }
            Console.WriteLine($"{(M / totalnum) * 100:0.00}%\n{(MM / totalnum) * 100:0.00}%\n{(KK / totalnum) * 100:0.00}%\n{(k2 / totalnum) * 100:0.00}%\n{(EV / totalnum) * 100:0.00}%");
        }

        public static void CatWalking()
        {
            int daywalking = int.Parse(Console.ReadLine());
            int walkingNum = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());
            Console.WriteLine((cal / 2) <= (daywalking * walkingNum * 5) ? $"Yes, the walk for your cat is enough. Burned calories per day: {daywalking * walkingNum * 5}." : $"No, the walk for your cat is not enough. Burned calories per day: {daywalking * walkingNum * 5}.");
        }

        public static void MountainRun()
        {
            double recordInSecond = double.Parse(Console.ReadLine());
            double distanceToRuN = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double slowerTime = Math.Floor(distanceToRuN / 50.00) * 30.00;
            slowerTime = Math.Floor(slowerTime);
            double totalTime = (timePerMeter * distanceToRuN) + slowerTime;
            Console.WriteLine(recordInSecond > totalTime ? $"Yes! The new record is {(totalTime):f2} seconds." : $"No! He was {totalTime - recordInSecond:f2} seconds slower.");
        }

        public static void EnergyBooster()
        {
            string fruitName = Console.ReadLine();
            string sizePack = Console.ReadLine();
            int packNum = int.Parse(Console.ReadLine());
            var name = Tuple.Create(fruitName + sizePack);
            double TotalPrice = 0.00;
            switch (name.Item1)
            {
                case "Watermelonsmall": TotalPrice = packNum * 56.00 * 2.00; break;
                case "Watermelonbig": TotalPrice = packNum * 28.70 * 5.00; break;
                case "Mangosmall": TotalPrice = packNum * 36.66 * 2.00; break;
                case "Mangobig": TotalPrice = packNum * 19.60 * 5.00; break;
                case "Pineapplesmall": TotalPrice = packNum * 42.10 * 2.00; break;
                case "Pineapplebig": TotalPrice = packNum * 24.80 * 5.00; break;
                case "Raspberrysmall": TotalPrice = packNum * 20.00 * 2.00; break;
                case "Raspberrybig": TotalPrice = packNum * 15.20 * 5.00; break;
            }
            if (TotalPrice >= 400 && TotalPrice <= 1000)
            {
                TotalPrice -= TotalPrice * 0.15;
            }
            else if (TotalPrice > 1000)
            {
                TotalPrice -= TotalPrice / 2.00;
            }
            Console.WriteLine($"{TotalPrice:f2} lv.");
        }

        public static void FitnessCard()
        {
            double ownMoney = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int yearOld = int.Parse(Console.ReadLine());
            string Sport = Console.ReadLine();
            var cndtn = Tuple.Create(sex + Sport);
            double totalToPay = 0.00;
            switch (cndtn.Item1)
            {
                case "mGym": totalToPay = 42.00; break;
                case "mBoxing": totalToPay = 41.00; break;
                case "mYoga": totalToPay = 45.00; break;
                case "mZumba": totalToPay = 34.00; break;
                case "mDances": totalToPay = 51.00; break;
                case "mPilates": totalToPay = 39.00; break;
                case "fGym": totalToPay = 35.00; break;
                case "fBoxing": totalToPay = 37.00; break;
                case "fYoga": totalToPay = 42.00; break;
                case "fZumba": totalToPay = 31.00; break;
                case "fDances": totalToPay = 53.00; break;
                case "fPilates": totalToPay = 37.00; break;
            }
            if (yearOld <= 19)
            {
                totalToPay -= totalToPay * 0.20;
            }
            Console.WriteLine(totalToPay <= ownMoney ? $"You purchased a 1 month pass for {Sport}." : $"You don't have enough money! You need ${totalToPay - ownMoney:f2} more.");
        }

        public static void FoodForPets()
        {
            int daysNum = int.Parse(Console.ReadLine());
            double Totaleating = double.Parse(Console.ReadLine());
            double dogEat = 0.00;
            double catEat = 0.00;
            double biscuit = 0.00;
            double totalsumeat = 0;
            for (int i = 1; i <= daysNum; i++)
            {
                double currentDog = double.Parse(Console.ReadLine());
                double currentCat = double.Parse(Console.ReadLine());
                dogEat += currentDog;
                catEat += currentCat;
                if (i % 3 == 0)
                {
                    biscuit += (currentCat + currentDog) * 0.10;
                }
            }
            totalsumeat = dogEat + catEat;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
            Console.WriteLine($"{(totalsumeat / Totaleating) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogEat / totalsumeat) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catEat / totalsumeat) * 100:f2}% eaten from the cat.");
        }
        public static void BirthdayParty()
        {
            double roomPrice = double.Parse(Console.ReadLine());
            double cakePrice = roomPrice * 0.20;
            double dringPrice = cakePrice - (cakePrice * 0.45);
            double animatePrice = roomPrice / 3;
            Console.WriteLine(roomPrice + cakePrice + dringPrice + animatePrice);
        }
        public static void Oscars()
        {
            string ActName = Console.ReadLine();
            double AcadPoint = double.Parse(Console.ReadLine());
            int NumOfPr = int.Parse(Console.ReadLine());
            string DP = "";
            double point = 0.00;
            double TotalP = AcadPoint;
            double Oscar = 1250.5;
            for (int i = 0; i < NumOfPr; i++)
            {
                DP = Console.ReadLine();
                point = double.Parse(Console.ReadLine());
                TotalP += ((DP.Length * point) / 2);
                if (TotalP >= Oscar)
                {
                    Console.WriteLine($"Congratulations, {ActName} got a nominee for leading role with {TotalP:0.0}!");

                    Environment.Exit(0);
                }

            }
            Console.WriteLine($"Sorry, {ActName} you need {Oscar - TotalP:0.0} more!");
        }

        public static void FavoriteMovie()
        {

            string movieName;
            int Max = int.MinValue;
            string MaxMovieName = "";
            int cnt = 0;
            bool isLimit = false;
            while ((movieName = Console.ReadLine()) != "STOP")
            {
                cnt++;
                int totalsum = 0;
                totalsum = FromStringToASCIISumWithUpperLowerCase(movieName, 65, 90, 97, 122);
                if (totalsum > Max)
                {
                    Max = totalsum;
                    MaxMovieName = movieName;
                }
                if (cnt >= 7)
                {
                    isLimit = true;
                    break;
                }
            }
            if (isLimit)
            {
                Console.WriteLine("The limit is reached.");
            }
            Console.WriteLine($"The best movie for you is {MaxMovieName} with {Max} ASCII sum.");
        }

        public static int FromStringToASCIISumWithUpperLowerCase(string name, int start, int stop, int twostart, int twostop)
        {
            try
            {
                int totalsum = 0;
                int len = name.Length;
                foreach (char c in name)
                {
                    int current = c;
                    if (current >= start && current <= stop)
                    {
                        totalsum += current - len;
                    }
                    else if (current >= twostart && current <= twostop)
                    {
                        totalsum += current - (len * 2);
                    }
                    else
                    {
                        totalsum += current;
                    }

                }
                return totalsum;
            }
            catch
            {
                return 0;
            }
        }

        public static void CinemaTickets()
        {
            //("student", "standard", "kid")
            string filmName = Console.ReadLine();
            int totalCountStudent = 0;
            int totalCountStandard = 0;
            int totalCountKid = 0;
            double sumTCalc = 0;
            while (filmName != "Finish")
            {
                int currentCountStudent = 0;
                int currentCountStandard = 0;
                int currentCountKid = 0;
                double sumCCalc = 0;
                double avg = 0;
                int capacity = int.Parse(Console.ReadLine());
                for (int i = 0; i < capacity; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType.ToLower())
                    {
                        case "student": totalCountStudent++; currentCountStudent++; break;
                        case "standard": totalCountStandard++; currentCountStandard++; break;
                        case "kid": totalCountKid++; currentCountKid++; break;
                    }

                }
                sumCCalc = currentCountKid + currentCountStandard + currentCountStudent;

                Console.WriteLine($"{filmName} - {(sumCCalc / capacity) * 100:f2}% full.");

                sumTCalc = totalCountKid + totalCountStandard + totalCountStudent;
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {sumTCalc}\n{(totalCountStudent / sumTCalc) * 100:f2}% student tickets.\n{(totalCountStandard / sumTCalc) * 100:f2}% standard tickets.\n{(totalCountKid / sumTCalc) * 100:f2}% kids tickets."
);
        }

        public static void MovieTickets()
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = a1; i <= a2 - 1; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 1; k <= (n / 2) - 1; k++)
                    {
                        if (i % 2 != 0 && (i + j + k) % 2 != 0)
                        {
                            Console.WriteLine($"{(char)i}-{j}{k}{i}");
                        }
                    }
                }
            }


        }

        public static void BirthdayPartyfromWorkPC()
        {
            double roomPrice = double.Parse(Console.ReadLine());
            double cakePrice = roomPrice * 0.20;
            double dringPrice = cakePrice - (cakePrice * 0.45);
            double animatePrice = roomPrice / 3;
            Console.WriteLine(roomPrice + cakePrice + dringPrice + animatePrice);
        }

        public static void WorldSnookerChampionship()
        {
            string stageOfChamp = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketNum = int.Parse(Console.ReadLine());
            char snapWithTr = char.Parse(Console.ReadLine());
            double totalSum = 0;
            double snapPrice = 0;
            var sumoft = Tuple.Create(stageOfChamp + ticketType);
            switch (sumoft.Item1)
            {
                case "Quarter finalStandard": totalSum = 55.50 * ticketNum; break;
                case "Quarter finalPremium": totalSum = 105.20 * ticketNum; break;
                case "Quarter finalVIP": totalSum = 118.90 * ticketNum; break;
                case "Semi finalStandard": totalSum = 75.88 * ticketNum; break;
                case "Semi finalPremium": totalSum = 125.22 * ticketNum; break;
                case "Semi finalVIP": totalSum = 300.40 * ticketNum; break;
                case "FinalStandard": totalSum = 110.10 * ticketNum; break;
                case "FinalPremium": totalSum = 160.66 * ticketNum; break;
                case "FinalVIP": totalSum = 400.00 * ticketNum; break;
            }

            if (totalSum > 4000)
            {
                totalSum -= totalSum * 0.25;
                snapWithTr = 'N';
            }
            else if (totalSum > 2500)
            {
                totalSum -= totalSum * 0.10;
            }
            if (snapWithTr == 'Y' && totalSum < 4000)
            {
                totalSum += ticketNum * 40;
            }


            Console.WriteLine($"{totalSum:f2}");
        }

        public static void HighJump()
        {
            int hjump = int.Parse(Console.ReadLine());
            int failcount = 0;
            bool isfail = false;
            int jumpcount = 0;
            int currenth = 0;
            int result = hjump - 30;
            for (int i = result; i <= hjump; i += 5)
            {
                int currentjump = int.Parse(Console.ReadLine());
                jumpcount++;
                currenth = i;
                if (currentjump > i)
                {
                    failcount = 0;
                    continue;
                }
                else
                {
                    failcount++;
                    i -= 5;
                    if (failcount == 3)
                    {
                        isfail = true;
                        failcount = 0;
                        break;
                    }
                }
            }
            if (isfail)
            {
                Console.WriteLine($"Tihomir failed at {currenth}cm after {jumpcount} jumps.");

            }
            else
            {

                Console.WriteLine($"Tihomir succeeded, he jumped over {currenth}cm after {jumpcount} jumps.");
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
                days--;
            }
            else if (days <= 0)
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
                case "BurgawithBreakfastyes": totalPrice = (days * 130.00); totalPrice -= totalPrice * 0.12; break;
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


        public static void SumNumbers()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < num)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }


        public static void Washmashine()
        {
            int btl = 750;
            int detergent = int.Parse(Console.ReadLine()) * btl;
            double voldetergent = 0;
            int count = 0;
            int dishes = 0;
            int pots = 0;
            for (int i = detergent; i >= voldetergent;)
            {
                string num = Console.ReadLine();
                if (num == "End")
                {
                    break;
                }
                count++;
                if (count == 3)
                {
                    count = 0;
                    voldetergent += int.Parse(num) * 15;
                    pots += int.Parse(num);
                }
                else
                {
                    voldetergent += int.Parse(num) * 5;
                    dishes += int.Parse(num);
                }


            }
            if (voldetergent <= detergent)
            {
                Console.WriteLine($"Detergent was enough!\n{dishes} dishes and {pots} pots were washed.\nLeftover detergent {detergent - voldetergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {voldetergent - detergent} ml. more necessary!");
            }
        }

        public static void StreamOfLetters()
        {
            //"c", "o" и "n"
            string word = string.Empty;
            bool ccount = false;
            bool ocount = false;
            bool ncount = false;
            bool result = ccount&&ocount&&ncount;
            string newWord = string.Empty;
            string magic = string.Empty;
            while ((word = Console.ReadLine()) != "End")
            {
                if (isLatinAlpha(word))
                {

                    if (word == "c" && ccount == false)
                    {

                        ccount = true;

                    }
                    else if (word == "o" && ocount == false)
                    {

                        ocount = true;

                    }
                    else if (word == "n" && ncount == false)
                    {

                        ncount = true;

                    }
                    else if (ccount && ocount && ncount)
                    {
                        newWord = magic + " ";
                        magic = string.Empty;
                        magic = word;
                        ocount = false; ncount = false; ccount = false;
                        Console.Write(newWord);

                    }
                    else
                    {
                        magic += word;
                    }

                }
                else
                {
                    continue;
                }
            }
            
           

        }
        private static bool isLatinAlpha(string name)
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

    }
}
