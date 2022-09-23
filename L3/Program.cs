using System;

namespace L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lab.labInHome.SmallShop();
        }
    }
}
namespace lab
{
    public class labInHome
    {
        public static void DayofWeek()
        {
            double numofday=double.Parse(Console.ReadLine());
            switch (numofday)
            {
                case 1: Console.WriteLine("Monday");break;
                case 2:Console.WriteLine("Tuesday");break;
                case 3:Console.WriteLine("Wednesday");break;
                case 4:Console.WriteLine("Thursday");break;
                case 5:Console.WriteLine("Friday");break;
                case 6:Console.WriteLine("Saturday");break;
                case 7:Console.WriteLine("Sunday");break;
                default:Console.WriteLine("Error");break;
            }
        }
        public static void WeekendOrWorkingDay()
        {
            string NameOfDay=Console.ReadLine();
            switch (NameOfDay)
            {
                case "Monday": Console.WriteLine("Working day"); break;
                case "Tuesday": Console.WriteLine("Working day"); break;
                case "Wednesday": Console.WriteLine("Working day"); break;
                case "Thursday": Console.WriteLine("Working day"); break;
                case "Friday": Console.WriteLine("Working day"); break;
                case "Saturday":Console.WriteLine("Weekend");break;
                case "Sunday": Console.WriteLine("Weekend"); break;
                    default:Console.WriteLine("Error");break;
            }
        }
        public static void AnimalType()
        {
            string animal=Console.ReadLine();
            if (animal.ToLower() == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal.ToLower() =="crocodile"|| animal.ToLower() == "tortoise" ||animal.ToLower() == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
        public static void PersonalTitles()
        {
            double yearold=double.Parse(Console.ReadLine());
            string th=Console.ReadLine();
            if(th.ToLower() == "m")
            {
                if (yearold >= 16) { Console.WriteLine("Mr."); } else { Console.WriteLine("Master"); }
            }
            else if (th.ToLower() =="f")
            {
                if (yearold >= 16) { Console.WriteLine("Ms."); } else { Console.WriteLine("Miss"); }
            }
        }
        public static void SmallShop()
        {
            string Product = Console.ReadLine();
            string City=Console.ReadLine(); 
            
            double NumOfProduct=double.Parse(Console.ReadLine());
            switch (City, Product)
            {
                case ("Sofia","coffee"):Console.WriteLine($"{NumOfProduct * 0.50}");break;
                case ("Sofia", "water"): Console.WriteLine($"{NumOfProduct * 0.80}"); break;
                case ("Sofia", "beer"): Console.WriteLine($"{NumOfProduct * 1.20}"); break;
                case ("Sofia", "sweets"): Console.WriteLine($"{NumOfProduct * 1.45}"); break;
                case ("Sofia", "peanuts"): Console.WriteLine($"{NumOfProduct * 1.60}"); break;
                case ("Plovdiv", "coffee"): Console.WriteLine($"{NumOfProduct * 0.40}"); break;
                case ("Plovdiv", "water"): Console.WriteLine($"{NumOfProduct * 0.70}"); break;
                case ("Plovdiv", "beer"): Console.WriteLine($"{NumOfProduct * 1.15}"); break;
                case ("Plovdiv", "sweets"): Console.WriteLine($"{NumOfProduct * 1.30}"); break;
                case ("Plovdiv", "peanuts"): Console.WriteLine($"{NumOfProduct * 1.50}"); break;
                case ("Varna", "coffee"): Console.WriteLine($"{NumOfProduct * 0.45}"); break;
                case ("Varna", "water"): Console.WriteLine($"{NumOfProduct * 0.70}"); break;
                case ("Varna", "beer"): Console.WriteLine($"{NumOfProduct * 1.10}"); break;
                case ("Varna", "sweets"): Console.WriteLine($"{NumOfProduct * 1.35}"); break;
                case ("Varna", "peanuts"): Console.WriteLine($"{NumOfProduct * 1.55}"); break;
            }
        }
    }
}