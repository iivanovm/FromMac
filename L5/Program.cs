using System;
using System.Collections;
using System.Collections.Generic;

namespace L5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            setup.MenuFill();
        }

        public static void ReadText()
        {
            string word = "stop";
            string input = "";
            string print = "";
            while (input.ToLower() != word)
            {
                print += input;
                input = Console.ReadLine();

            }
            Console.WriteLine(print);

        }
        public static void Ticket()
        {
            double budget = double.Parse(Console.ReadLine());
            string Category = Console.ReadLine();
            double HumanNum = double.Parse(Console.ReadLine());
            double TSum = 0.00;
            // double Total=double.Parse(Console.ReadLine());
            switch (Category.ToLower())
            {
                case "vip": TSum = 499.99 * HumanNum; break;
                case "normal": TSum = 249.99 * HumanNum; break;
                default: TSum = TSum * 1; break;
            }



            if (HumanNum > 0 && HumanNum <= 4)
            {
                budget = budget - budget * 0.75;
            }
            else if (HumanNum >= 5 && HumanNum <= 9)
            {
                budget = budget - budget * 0.60;
            }
            else if (HumanNum >= 10 && HumanNum <= 24)
            {
                budget = budget - budget * 0.50;
            }
            else if (HumanNum >= 25 && HumanNum <= 49)
            {
                budget = budget - budget * 0.40;
            }
            else if (HumanNum >= 50)
            {
                budget = budget - budget * 0.25;
            }

            Console.WriteLine(budget >= TSum ? $"Yes! You have {budget - TSum:0.00} leva left." : $"Not enough money! You need {TSum - budget:0.00} leva.");

        }

        public static void BikeRace()
        {
            double Junior = double.Parse(Console.ReadLine());
            double Senior = double.Parse(Console.ReadLine());
            string TraceType = Console.ReadLine();
            double Total = 0.00;
            switch (TraceType.ToLower())
            {
                case "trail": Total = Junior * 5.50 + Senior * 7; break;
                case "cross-country":
                    if (Junior + Senior >= 50)
                    {
                        Total = Junior * 8 + Senior * 9.50;
                        Total = Total - (Total * 0.25);

                    }
                    else
                    {
                        Total = Junior * 8 + Senior * 9.50;
                    }; break;
                case "downhill": Total = Junior * 12.25 + Senior * 13.75; break;
                case "road": Total = Junior * 20 + Senior * 21.50; break;

            }
            Console.WriteLine($"{Total - (Total * 0.05):0.00}");
        }

        public static void Vacantion()
        {
            double budget=double.Parse(Console.ReadLine()); 
            string season=Console.ReadLine();
            string location = "";
            string nights = "";
            double SumTotal = 0.00;
            if (budget <= 1000)
            {
                nights = "Camp";
                switch (season.ToLower())
                {
                    case "summer":location = "Alaska";SumTotal = budget*0.65; break;
                    case "winter":location = "Morocco";SumTotal = budget * 0.45;break;
                }

            }
           else if (budget > 1000&&budget<=3000)
            {
                nights = "Hut";
                switch (season.ToLower())
                {
                    case "summer": location = "Alaska"; SumTotal = budget * 0.80; break;
                    case "winter": location = "Morocco"; SumTotal = budget * 0.60; break;
                }

            }
            else if ( budget >3000)
            {
                nights = "Hotel";
                switch (season.ToLower())
                {
                    case "summer": location = "Alaska"; SumTotal = budget * 0.90; break;
                    case "winter": location = "Morocco"; SumTotal = budget * 0.90; break;
                }

            }
            Console.WriteLine($"{location} - {nights} - {SumTotal:0.00}");
            
        }

        public static void TruckDriver()
        {
            string Season = Console.ReadLine(); 
            double KmPerMonth=double.Parse(Console.ReadLine());
            double PricePerKm = 0.00;
            double TotalSelary = 0.00;
            if (KmPerMonth <= 5000)
            {
                if(Season.ToLower() =="spring"||Season.ToLower() == "autumn")
                {
                    TotalSelary = KmPerMonth * 0.75*4;
                }
                else if (Season.ToLower() == "summer")
                {
                    TotalSelary = KmPerMonth * 0.90 * 4;
                }
                else if (Season.ToLower() == "winter")
                {
                    TotalSelary = KmPerMonth * 1.05 * 4;
                }
            }
            else if (KmPerMonth > 5000&& KmPerMonth<=10000)
            {
                if (Season.ToLower() == "spring" || Season.ToLower() == "autumn")
                {
                    TotalSelary = KmPerMonth * 0.95 * 4;
                }
                else if (Season.ToLower() == "summer")
                {
                    TotalSelary = KmPerMonth * 1.10 * 4;
                }
                else if (Season.ToLower() == "winter")
                {
                    TotalSelary = KmPerMonth * 1.25 * 4;
                }
            }
            else if (KmPerMonth > 10000 && KmPerMonth <= 20000)
            {
                
                    TotalSelary = KmPerMonth * 1.45 * 4;
                
            }
            TotalSelary =TotalSelary- TotalSelary * 0.1;
            Console.WriteLine($"{TotalSelary:0.00}");
        }

        public static void SchoolCamp()
        {
            string season=Console.ReadLine();
            string grouptype=Console.ReadLine();
            double students=double.Parse(Console.ReadLine());
            double nights=double.Parse(Console.ReadLine());
            double TotalCals=0.00;
            var Fd = new Dictionary<Tuple<string, string>, string>
            {
                {Tuple.Create("winter","girls"),"Gymnastic" },
                {Tuple.Create("spring","girls"),"Athletics" },
                {Tuple.Create("summer","girls"),"Volleyball"},
                {Tuple.Create("winter","boys"),"Judo" },
                {Tuple.Create("spring","boys"),"Judo" },
                {Tuple.Create("summer","boys"),"Football"},
                {Tuple.Create("winter","mixed"),"Ski" },
                {Tuple.Create("spring","mixed"),"Cycling" },
                {Tuple.Create("summer","mixed"),"Swimming"}
            };
            var PriceD = new Dictionary<Tuple<string, string>, double>
            {
                {Tuple.Create("winter","girls"), 9.60},
                {Tuple.Create("spring","girls"),7.20},
                {Tuple.Create("summer","girls"),15},
                {Tuple.Create("winter","boys"), 9.60},
                {Tuple.Create("spring","boys"),7.20},
                {Tuple.Create("summer","boys"),15.00},
                {Tuple.Create("winter","mixed"),10.00},
                {Tuple.Create("spring","mixed"),9.50},
                {Tuple.Create("summer","mixed"),20.00}
            };
          //  
          if (students > 50)
            {
                TotalCals = nights * PriceD.GetValueOrDefault(Tuple.Create(season.ToLower(), grouptype.ToLower()),1)*students;
                TotalCals = TotalCals / 2;
            }
          else if (students >= 20 && students < 50)
            {
                TotalCals = nights * PriceD.GetValueOrDefault(Tuple.Create(season.ToLower(), grouptype.ToLower()), 1)*students;
                TotalCals = TotalCals -(TotalCals*0.15);
            }
          else if (students >= 10 && students < 20)
            {
                TotalCals = nights * PriceD.GetValueOrDefault(Tuple.Create(season.ToLower(), grouptype.ToLower()), 1)*students;
                TotalCals = TotalCals - (TotalCals * 0.05);
            }
          else
            {
                TotalCals = nights * PriceD.GetValueOrDefault(Tuple.Create(season.ToLower(), grouptype.ToLower()), 1) * students;
            }
            Console.WriteLine($"{Fd.GetValueOrDefault(Tuple.Create(season.ToLower(), grouptype.ToLower())," ")} {TotalCals:0.00}");
        }

        public static void PointOnRectangleBorder()
        {
            double x1=double.Parse(Console.ReadLine()); 
            double y1=double.Parse(Console.ReadLine());
            double x2=double.Parse(Console.ReadLine());
            double y2=double.Parse(Console.ReadLine());
            double x=double.Parse(Console.ReadLine());
            double y=double.Parse(Console.ReadLine());
            if(x1<=x && x2<=x && y1<=y && y2 <= y)
            {
                Console.WriteLine("Outside");
            }
            else if (x1 > x && x2 > x && y1 > y && y2 > y)
            {
                Console.WriteLine("Outside");
            }
            else if ((x1 == x && x2 == x && y1 == y && y2 == y))
            {
                Console.WriteLine("Border");
            }
        }

    }
}
