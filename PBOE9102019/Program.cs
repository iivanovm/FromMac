using System;

namespace PBOE9102019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJudge.FromCharToInt("It's"));
        }


    }
    public class ToJudge
    {
        public static void Skeleton()
        {
            double TopMin = double.Parse(Console.ReadLine());
            double TopSec = double.Parse(Console.ReadLine());
            double len = double.Parse(Console.ReadLine());
            double secFor100Metr = double.Parse(Console.ReadLine());
            double toptime = TopMin * 60 + TopSec;
            double MartinTime = ((len / 100) * secFor100Metr) - ((len / 120) * 2.5);
            if (MartinTime <= toptime)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!\nHis time is {MartinTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(MartinTime - toptime):f3} second slower.");
            }

        }

        public static void Gymnastics()
        {
            string countryName = Console.ReadLine();
            string type = Console.ReadLine();
            double total = 0.00;

            switch (countryName)
            {
                case "Russia": if (type == "ribbon") { total = 9.1 + 9.4; }
                    else if (type == "hoop") { total = 9.3 + 9.8; } else if (type == "rope") { total = 9 + 9.6; }
                    break;
                case "Bulgaria": if (type == "ribbon") { total = 9.6 + 9.4; }
                    else if (type == "hoop") { total = 9.550 + 9.750; } else if (type == "rope") { total = 9.500 + 9.400; }
                    break;
                case "Italy":
                    if (type == "ribbon") { total = 9.200 + 9.500; }
                    else if (type == "hoop") { total = 9.450 + 9.350; } else if (type == "rope") { total = 9.700 + 9.150; }
                    break;
            }
            Console.WriteLine($"The team of {countryName} get {total:f3} on {type}.\n{((20 - total) / 0.20):f2}% ");
        }

        public static void WorldSnookerChampionship()
        {
            string stageOfChamp = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketNum = int.Parse(Console.ReadLine());
            char snapWithTr = char.Parse(Console.ReadLine());
            double totalSum = 0;
            if (stageOfChamp == "Quarter final" && ticketType == "Standard")
            {
                totalSum = 55.50 * ticketNum;
            }
            else if (stageOfChamp == "Quarter final" && ticketType == "Premium")
            {
                totalSum = 105.20 * ticketNum;
            }
            else if (stageOfChamp == "Quarter final" && ticketType == "VIP")
            {
                totalSum = 118.90 * ticketNum;
            }
            else if (stageOfChamp == "Semi final" && ticketType == "Standard")
            {
                totalSum = 75.88 * ticketNum;
            }
            else if (stageOfChamp == "Semi final" && ticketType == "Premium")
            {
                totalSum = 125.22 * ticketNum;
            }
            else if (stageOfChamp == "Semi final" && ticketType == "VIP")
            {
                totalSum = 300.40 * ticketNum;
            }
            else if (stageOfChamp == "Final" && ticketType == "Standard")
            {
                totalSum = 110.10 * ticketNum;
            }
            else if (stageOfChamp == "Final" && ticketType == "Premium")
            {
                totalSum = 160.66 * ticketNum;
            }
            else if (stageOfChamp == "Final" && ticketType == "VIP")
            {
                totalSum = 400 * ticketNum;
            }
            if (snapWithTr == 'Y')
            {
                if (totalSum > 4000)
                {
                    totalSum -= totalSum * 0.25;
                }
                else if (totalSum > 250)
                {
                    totalSum -= totalSum * 0.1;
                    totalSum += ticketNum * 40;
                }
                else
                {
                    totalSum += ticketNum * 40;
                }
            }
            else
            {
                totalSum = totalSum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }


        public static void TennisRanklist()
        {
            int turNum = int.Parse(Console.ReadLine());
            int startPointNum = int.Parse(Console.ReadLine());
            double wcount = 0;
            int fcount = 0;
            int sfcount = 0;

            double finalScore = startPointNum;
            for (int i = 1; i <= turNum; i++)
            {
                string stage = Console.ReadLine();
                switch (stage.ToUpper())
                {
                    case "W":
                        finalScore += 2000; wcount++;
                        break;
                    case "F":
                        finalScore += 1200; fcount++;
                        break;
                    case "SF":
                        finalScore += 720; sfcount++;
                        break;
                }

            }
            Console.WriteLine($"Final points: {finalScore}");
            Console.WriteLine($"Average points: {Math.Floor((finalScore - startPointNum) / turNum)}");
            Console.WriteLine($"{(wcount / turNum) * 100:f2}%");

        }

        public static void FitnessCenter()
        {
            //("Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar"
            int fitnessHNum = int.Parse(Console.ReadLine());
            string activity = string.Empty;
            int backcnt = 0;
            int chestcnt = 0;
            int legscnt = 0;
            int abscnt = 0;
            int shakecnt = 0;
            int barcnt = 0;
            int totalcnt = 0;
            double acHm = 0.00;
            double eatHm = 0.00;
            for (int i = 1; i <= fitnessHNum; i++)
            {
                activity = Console.ReadLine();
                switch (activity.ToLower())
                {
                    case "back": backcnt++; break;
                    case "chest": chestcnt++; break;
                    case "legs": legscnt++; break;
                    case "abs": abscnt++; break;
                    case "protein shake": shakecnt++; break;
                    case "protein bar": barcnt++; break;
                }
            }
            totalcnt = backcnt + chestcnt + legscnt + abscnt + shakecnt + barcnt;
            acHm = ((backcnt + chestcnt + legscnt + abscnt) / (double)totalcnt) * 100;
            eatHm = ((shakecnt + barcnt) / (double)totalcnt) * 100;

            Console.WriteLine($"{backcnt} - back\n{chestcnt} - chest\n{legscnt} - legs\n{abscnt} - abs\n{shakecnt} - protein shake\n{barcnt} - protein bar\n{acHm:f2}% - work out\n{eatHm:f2}% - protein");
        }

        public static void HighJump()
        {
            int thgh = int.Parse(Console.ReadLine());
            int totalh = 0;
            int sucCount = 0;
            int unsscount = 0;
            int lth = 0;
            bool isFl = false;
            for (lth=thgh-30;thgh>=lth; )
            {
               
                int jump = int.Parse(Console.ReadLine());
                totalh++;
                if (jump > lth)
                {
                    sucCount++;
                    lth += 5;
                    unsscount = 0;
                }
                else if (jump < lth)
                {
                    unsscount++;
                    
                }
                if (unsscount == 3)
                {
                    isFl = true;
                    break;

                }

            }
            
            if (!isFl)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {thgh}cm after {totalh} jumps.");
            } 
            else
            {
                Console.WriteLine($"Tihomir failed at {lth}cm after {totalh} jumps.");
            }

            
        }

        public static void BasketballTournament()
        {
            string trName;
            int winCount = 0;
            int lossCount = 0;
            while ((trName = Console.ReadLine()) != "End of tournaments")
            {
                int matchNum = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= matchNum; i++)
                {
                    string dpoint = Console.ReadLine();

                    int DesiTeamPoint = int.Parse(dpoint);
                    int OtherTeamPoint = int.Parse(Console.ReadLine());
                    if (DesiTeamPoint > OtherTeamPoint)
                    {
                        winCount++;
                        Console.WriteLine($"Game {i} of tournament {trName}: win with {DesiTeamPoint - OtherTeamPoint} points.");
                    }
                    else
                    {
                        lossCount++;
                        Console.WriteLine($"Game {i} of tournament {trName}: lost with {OtherTeamPoint - DesiTeamPoint} points.");
                    }
                }
            }
            Console.WriteLine($"{((double)winCount/(winCount+lossCount)*100):f2}% matches win\n{((double)lossCount/(winCount+lossCount)*100):f2}% matches lost");
        
        }

        public static int FromCharToInt(string input)
        {
            int CurrnetSum = 0;
            foreach(char c in input)
            {
                CurrnetSum += Convert.ToChar(c);
            }

            return CurrnetSum;

        }
    }
}
