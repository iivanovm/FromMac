using System;

namespace PBOE2020v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToJudge.Cinema();
        }
    }

    public class ToJudge
    {
        public static void BirthdayParty()
        {
            double roomPrice = double.Parse(Console.ReadLine());
            double cakePrice = roomPrice * 0.20;
            double dringPrice = cakePrice - (cakePrice * 0.45);
            double animatePrice = roomPrice / 3;
            Console.WriteLine(roomPrice+cakePrice+dringPrice+animatePrice);
        }

        public static void SeriesCalculator()
        {
            string sName=Console.ReadLine();
            int seasonNum=int.Parse(Console.ReadLine());
            int epNum=int.Parse(Console.ReadLine());
            double epTIme=double.Parse(Console.ReadLine());
            double totalepTime = epTIme + (epTIme * 0.2);
            double totalTime = (totalepTime*epNum*seasonNum) + (seasonNum * 10);
            Console.WriteLine($"Total time needed to watch the {sName} series is {totalTime} minutes.");
        }

        public static void MovieProfit()
        {
            string FilmName=Console.ReadLine();
            int daysNum = int.Parse(Console.ReadLine());
            int ticketNum = int.Parse(Console.ReadLine());
            double ticketPrice=double.Parse(Console.ReadLine());
            double precen=double.Parse(Console.ReadLine());
            double totalsum = 0;
            totalsum = (ticketNum * ticketPrice * daysNum);
            totalsum -= totalsum* (precen/100);
        
            Console.WriteLine($"The profit from the movie {FilmName} is {totalsum:f2} lv.");
        }

        public static void MovieDay()
        {
            int timemovie = int.Parse(Console.ReadLine());
            int scenNum = int.Parse(Console.ReadLine());
            int scentime= int.Parse(Console.ReadLine());
            double TotalTime = (timemovie * 0.15) + (scenNum * scentime);
            Console.WriteLine(TotalTime<timemovie?$"You managed to finish the movie on time! You have {Math.Ceiling(timemovie-TotalTime)} minutes left!":$"Time is up! To complete the movie you need {Math.Ceiling(TotalTime-timemovie)} minutes.");
        }

        public static void FilmPremiere()
        {
            string projectName=Console.ReadLine();
            string packetType=Console.ReadLine();
            int ticketNum=int.Parse(Console.ReadLine());
            double price = 0.00;
            double totalsum = 0;
            switch (projectName)
            {
                case "John Wick":
                    if (packetType == "Drink")
                    {
                        price = 12.00;
                    }
                    else if (packetType == "Popcorn")
                    {
                        price = 15.00;
                    }
                    else if (packetType == "Menu")
                    {
                        price = 19.00;
                    }
                    break;
                case "Star Wars":
                    if (packetType == "Drink")
                    {
                        price = 18.00;
                    }
                    else if (packetType == "Popcorn")
                    {
                        price = 25.00;
                    }
                    else if (packetType == "Menu")
                    {
                        price = 30.00;
                    }
                    break;
                case "Jumanji":
                    if (packetType == "Drink")
                    {
                        price = 9.00;
                    }
                    else if (packetType == "Popcorn")
                    {
                        price = 11.00;
                    }
                    else if (packetType == "Menu")
                    {
                        price = 14.00;
                    }
                    break;
            }
            totalsum = price * ticketNum;
            if (ticketNum>=4&& projectName== "Star Wars")
            {
                totalsum -= totalsum * 0.30;
            }
            else if (ticketNum == 2 &&projectName== "Jumanji")
            {
                totalsum -= totalsum * 0.15;
            }
            Console.WriteLine($"Your bill is {totalsum:f2} leva.");
        }

        public static void MovieDestination()
        {
            double movieBudjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season=Console.ReadLine();
            int daysNum = int.Parse(Console.ReadLine());
            double currentBud = 0.00;
            if(destination=="Dubai"&& season=="Winter")
            {
                currentBud = daysNum * 45000;
                currentBud -= currentBud * 0.30;
            }
            else if (destination == "Dubai" && season == "Summer")
            {
                currentBud = daysNum * 40000;
                currentBud -= currentBud * 0.30;
            }
            else if (destination == "Sofia" && season == "Winter")
            {
                currentBud = daysNum * 17000;
                currentBud += currentBud * 0.25;
            }
            else if (destination == "Sofia" && season == "Summer")
            {
                currentBud = daysNum * 12500;
                currentBud += currentBud * 0.25;
            }
            else if (destination == "London" && season == "Winter")
            {
                currentBud = daysNum * 24000;
            }
            else if (destination == "London" && season == "Summer")
            {
                currentBud = daysNum * 20250;
            }
            Console.WriteLine(currentBud<=movieBudjet?$"The budget for the movie is enough! We have {movieBudjet-currentBud:f2} leva left!":$"The director needs {currentBud-movieBudjet:f2} leva more!");
        }

        public static void Cinema()
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());
            string inc;
            double TotalSum=0;
            int totalSeatsNum = 0;
            while ((inc=Console.ReadLine())!= "Movie time!")
            {
                int peopleNum=int.Parse(inc);
                if (peopleNum % 3 == 0)
                {
                    TotalSum += (5 * peopleNum)-5;
                    totalSeatsNum += peopleNum;
                }
                else
                {
                    TotalSum += 5 * peopleNum;
                    totalSeatsNum += peopleNum;
                }
                if (cinemaCapacity <= totalSeatsNum)
                {
                    break;
                }
            }
            Console.WriteLine(cinemaCapacity > totalSeatsNum || cinemaCapacity-totalSeatsNum==0? $"There are {cinemaCapacity - totalSeatsNum} seats left in the cinema." : $"The cinema is full.");
            Console.WriteLine($"Cinema income - {TotalSum} lv.");
        }
    }
}
