using System;

namespace PBOE67A2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.CinemaVoucher();
        }
    }

    internal class ToJudge
    {
        public static void Oscarsceremony()
        {
            double hallRent = double.Parse(Console.ReadLine());
            double statuette = hallRent - (hallRent * 0.30);
            double catering = statuette - (statuette * 0.15);
            double sound = catering / 2.00;
            double total = hallRent + statuette + catering + sound;
            Console.WriteLine($"{total:f2}");
        }
        public static void GodzillaVsKong()
        {
            double budget = double.Parse(Console.ReadLine());
            double nstat = double.Parse(Console.ReadLine());
            double priceclothing = double.Parse(Console.ReadLine());
            double dk = budget * 0.1;
            double clpricewithoutdiscount = nstat * priceclothing;
            double clpricewithdiscount = (nstat * priceclothing) - (nstat * priceclothing * 0.1);
            if (nstat >= 150)
            {
                double totalprice = clpricewithdiscount + dk;
                if (totalprice <= budget)
                {
                    Console.WriteLine($"Action!\nWingard starts filming with {(budget - totalprice).ToString("0.00")} leva left.");//
                }
                else
                {
                    Console.WriteLine($"Not enough money!\nWingard needs {(totalprice - budget).ToString("0.00")} leva more.");
                }
            }
            else
            {
                double totalprice = clpricewithoutdiscount + dk;
                if (totalprice <= budget)
                {
                    Console.WriteLine($"Action!\nWingard starts filming with {(budget - totalprice).ToString("0.00")} leva left.");//
                }
                else
                {
                    Console.WriteLine($"Not enough money!\nWingard needs {(totalprice - budget).ToString("0.00")} leva more.");
                }

            }

        }

        public static void OscarsWeekInCinema()
        {
            
           string movieName=Console.ReadLine(); 
            string rtype=Console.ReadLine();
            int ticketBuy=int.Parse(Console.ReadLine());
            double totalPrice = 0;

            var mr=Tuple.Create(movieName+rtype);
           
            switch (mr.Item1)
            {
                case "A Star Is Bornnormal": totalPrice = ticketBuy * 7.50;break;
                case "A Star Is Bornluxury": totalPrice = ticketBuy * 10.50; break;
                case "A Star Is Bornultra luxury": totalPrice = ticketBuy * 13.50; break;
                case "Bohemian Rhapsodynormal": totalPrice = ticketBuy * 7.35; break;
                case "Bohemian Rhapsodyluxury": totalPrice = ticketBuy * 9.45; break;
                case "Bohemian Rhapsodyultra luxury": totalPrice = ticketBuy * 12.75; break;
                case "Green Booknormal": totalPrice = ticketBuy * 8.15; break;
                case "Green Bookluxury": totalPrice = ticketBuy * 10.25; break;
                case "Green Bookultra luxury": totalPrice = ticketBuy * 13.25; break;
                case "The Favouritenormal": totalPrice = ticketBuy * 8.75; break;
                case "The Favouriteluxury": totalPrice = ticketBuy * 11.55; break;
                case "The Favouriteultra luxury": totalPrice = ticketBuy * 13.95; break;

            }
            Console.WriteLine($"{movieName} -> {totalPrice:f2} lv.");
        }

        public static void CinemaVoucher()
        {
            int ticktCount = 0;
            int otCount=0;
            double voucherPRice = double.Parse(Console.ReadLine());
            string buy;
            while((buy=Console.ReadLine())!="End")
            {
                int currentsum = 0;
                if (buy.Length > 8)
                {
                    currentsum = Convert.ToChar(buy.Substring(0, 1)) + Convert.ToChar(buy.Substring(1, 1));
                }
                else
                {
                    currentsum= Convert.ToChar(buy.Substring(0,1));
                }
                if (voucherPRice <0 || (voucherPRice -currentsum<0))
                {
                    break;
                }
                if (buy.Length > 8)
                {
                    ticktCount++;
                }
                else
                {
                    otCount++;  
                }
                if (voucherPRice-currentsum>0)
                {
                    voucherPRice-=currentsum;
                }
            }
            Console.WriteLine($"{ticktCount}\n{otCount}");
        }

        internal static int CinemaASCIIToCh(string word)
        {
            int ch = 0;
            try
            {
                int total = 0;
                if (word.Length > 8)
                {
                    try
                    {
                        total = Convert.ToChar(word.Substring(0, 1)) + Convert.ToChar(word.Substring(1, 1));
                    }
                    catch
                    {
                        total = ch;
                    }
                }
                else if (word.Length <= 8)
                {
                    try
                    {
                        total = Convert.ToChar(word.Substring(0, 1));
                    }
                    catch
                    {
                        total = ch;
                    }
                }

                return total;
            }
            catch
            {
                return ch;
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
            Console.WriteLine($"Total tickets: {sumTCalc}\n{(totalCountStudent / sumTCalc) * 100:f2}% student tickets.\n{(totalCountStandard / sumTCalc) * 100:f2}% standard tickets.\n{(totalCountKid / sumTCalc) * 100:f2}% kids tickets.");
        }

        public static void MovieRatings()
        {
            int movieNum=int.Parse(Console.ReadLine());
            double maxScore = double.MinValue;
            string MaxRateMName=string.Empty;
            string MinRateMName = string.Empty;
            double minScore = double.MaxValue;
            double AvgScore=0.00;
            double totalMovieRate = 0.00;
            string movieName=string.Empty;
            for (int mnum = 1; mnum <= movieNum; mnum++)
            {
                movieName = Console.ReadLine();
                double movieRating=double.Parse(Console.ReadLine());
                totalMovieRate+=movieRating;
                if(movieRating > maxScore)
                {
                    maxScore = movieRating;
                    MaxRateMName= movieName;
                }
                else if (movieRating < minScore)
                {
                    minScore = movieRating;
                    MinRateMName= movieName;
                }
            }
            AvgScore = totalMovieRate / movieNum;
            Console.WriteLine($"{MaxRateMName} is with highest rating: {maxScore:f1}\n{MinRateMName} is with lowest rating: {minScore:f1}\nAverage rating: {AvgScore:f1}");
        }
    }
}
