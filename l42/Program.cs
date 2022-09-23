using System;
using System.Collections;
using System.Collections.Generic;

namespace l42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TennisRanklist();
        }

        public static void Salary()
        {
            double n = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string SiteName = "";
            var Snam = new Dictionary<string, double>
            {
                {"facebook",150.00 },
                {"instagram",100.00 },
                {"reddit",50.00 }

            };

            for (int i = 0; i <= n; i++)
            {
                SiteName = Console.ReadLine();
                salary -= Snam.GetValueOrDefault(SiteName.ToLower(), 0.00);
                if (salary == 0 || salary < 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            Console.WriteLine(salary == 0 || salary < 0 ? "" : $"{salary:0}");
        }
        public static void Oscars()
        {
            string ActName=Console.ReadLine();
            double AcadPoint=double.Parse(Console.ReadLine());
            int NumOfPr=int.Parse(Console.ReadLine());
            string DP="";  
            double point=0.00;
            double TotalP = AcadPoint;
            double Oscar=1250.5;
            for (int i=0; i<NumOfPr; i++)
            {
                DP = Console.ReadLine();
                point = double.Parse(Console.ReadLine());
                TotalP += ((DP.Length *point )/ 2);
                if(TotalP >= Oscar)
                {
                    Console.WriteLine($"Congratulations, {ActName} got a nominee for leading role with {TotalP:0.0}!");
                  
                    Environment.Exit(0);
                }
                
            }
            Console.WriteLine($"Sorry, {ActName} you need {Oscar-TotalP:0.0} more!");
        }
        public static void TrekkingMania()
        {
            double groupnum=double.Parse(Console.ReadLine());
            double totalnum = 0.00;
            double M = 0;
            double MM=0;
            double KK = 0;
            double k2=0;
            double EV = 0;

            for (int i=0; i<groupnum; i++)
            {
                double n=double.Parse(Console.ReadLine());
                totalnum += n;
                if (n<= 5)
                {
                    M+=n;
                }
                else if (n>=6 && n <= 12)
                {
                    MM+=n;
                }   
                else if (n>=13 && n <= 25)
                {
                    KK+=n;
                }
                else if (n>=26 && n <= 40)
                {
                    k2+=n;
                }
                else if (n >= 41)
                {
                    EV+=n;
                }
            }
            Console.WriteLine($"{(M / totalnum) * 100:0.00}%\n{(MM / totalnum )* 100:0.00}%\n{(KK / totalnum) * 100:0.00}%\n{(k2 / totalnum) * 100:0.00}%\n{(EV / totalnum) * 100:0.00}%");
        }
        public static void TennisRanklist()
        {
            var dictFinalScore = new Dictionary<string, double>
            {
                {"w",2000 },
                {"f",1200 },
                {"sf",720 }
            };
            double tournament=double.Parse(Console.ReadLine());
            double StartPoint=double.Parse(Console.ReadLine());
            double CountWins = 0.00;
            double TotalScore = StartPoint;
            double AvgScore = 0.00;
            double ScoreInTime = 0.00;
            for (int i = 0; i < tournament; i++)
            {
                string CurrentScore=Console.ReadLine();
                ScoreInTime+=dictFinalScore.GetValueOrDefault(CurrentScore.ToLower(),0);
                TotalScore+=dictFinalScore.GetValueOrDefault(CurrentScore.ToLower(),0);
                if (CurrentScore.ToLower() == "w") { CountWins++; }
            }
            AvgScore = ScoreInTime / tournament;
            Console.WriteLine($"Final points: {TotalScore:0}\nAverage points: {Math.Floor(AvgScore):0}\n{((CountWins/tournament)*100):0.00}%");
        }

    }
}