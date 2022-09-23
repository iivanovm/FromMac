using System;
using System.Collections;
using System.Collections.Generic;

namespace Loops_MB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnTime();
        }

        public static void newHome()
        {
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //

            double roses = 5.00;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;
            string flowerType = Console.ReadLine();
            double flowernum = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalSumOfFlowers = 0;
            switch (flowerType.ToLower())
            {
                case "roses": totalSumOfFlowers += roses * flowernum; break;
                case "dahlias": totalSumOfFlowers += dahlias * flowernum; break;
                case "tulips": totalSumOfFlowers += tulips * flowernum; break;
                case "narcissus": totalSumOfFlowers += narcissus * flowernum; break;
                case "gladiolus": totalSumOfFlowers += gladiolus * flowernum; break;
            }

            if (flowerType.ToLower() == "roses" && flowernum > 80)
            {
                totalSumOfFlowers -= (totalSumOfFlowers * 0.10);
            }
            else if (flowerType.ToLower() == "dahlias" && flowernum > 90)
            {
                totalSumOfFlowers -= (totalSumOfFlowers * 0.15);
            }
            else if (flowerType.ToLower() == "tulips" && flowernum > 80)
            {
                totalSumOfFlowers -= (totalSumOfFlowers * 0.15);
            }

            else if (flowerType.ToLower() == "narcissus" && flowernum < 120)
            {
                totalSumOfFlowers += (totalSumOfFlowers * 0.15);
            }
            else if (flowerType.ToLower() == "gladiolus" && flowernum < 80)
            {
                totalSumOfFlowers += (totalSumOfFlowers * 0.20);
            }

            if (totalSumOfFlowers <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowernum} {flowerType} and {Math.Abs(budget - totalSumOfFlowers):0.00} leva left.");
            }
            else if (totalSumOfFlowers > budget)
            {
                Console.WriteLine($"Not enough money, you need {(totalSumOfFlowers - budget):0.00} leva more.");
            }
        }


        public static void fishingBoat()
        {
            //: "Spring", "Summer", "Autumn", "Winter"

            double spring = 3000;
            double summer = 4200;
            double autumn = 4200;
            double winter = 2600;
            double totalSum = 0;
            double groupBudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fisherman = double.Parse(Console.ReadLine());

            switch (season.ToLower())
            {
                case "spring": totalSum += spring; break;
                case "summer": totalSum += summer; break;
                case "autumn": totalSum += autumn; break;
                case "winter": totalSum += winter; break;
            }

            if (fisherman <= 6)
            {

                totalSum -= totalSum * 0.10;
            }

            else if (fisherman > 6 && fisherman <= 11)
            {
                totalSum -= totalSum * 0.15;
            }
            else if (fisherman > 12)
            {

                totalSum -= totalSum * 0.25;
            }

            if (fisherman % 2 == 0 && season.ToLower() != "autumn")
            {
                totalSum -= totalSum * 0.05;
            }

            Console.WriteLine(totalSum <= groupBudget ? $"Yes! You have {(groupBudget - totalSum):0.00} leva left." : $"Not enough money! You need {(totalSum - groupBudget):0.00} leva.");
        }
        public static void OperationsBetweenNumbers()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double Total = 0.00;
            switch (oper)
            {

                case "+":
                    Total = n1 + n2;
                    if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); }
                    else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;

                case "-":
                    Total = n1 - n2;
                    if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); }
                    else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;

                case "*":
                    Total = n1 * n2;
                    if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); }
                    else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;

                case "/":
                    Total = n1 / n2;
                    if (n2 == 0) { Console.WriteLine($"Cannot divide {n1} by zero"); }
                    else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)}"); }; break;

                case "%":
                    Total = n1 % n2;
                    if (n2 == 0) { Console.WriteLine($"Cannot divide {n1} by zero"); }
                    else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)}"); }; break;
            }
        }

        public static void rooms()
        {
            string months = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartments = 0;
            double studio = 0;
            double totalSumApart = 0;
            double totalSumSt = 0;
            if (months.ToLower() == "may" || months.ToLower() == "october")
            {
                apartments = 65;
                studio = 50;
                totalSumApart += apartments * nights;
                totalSumSt += studio * nights;

                if (nights > 7 && nights < 14)
                {

                    totalSumSt -= totalSumSt * 0.05;
                }
                else if (nights > 14)
                {
                    totalSumSt -= totalSumSt * 0.30;
                    totalSumApart -= totalSumApart * 0.1;
                }
            }
            else if (months.ToLower() == "june" || months.ToLower() == "september")
            {
                apartments = 68.70;
                studio = 75.20;
                totalSumApart += apartments * nights;
                totalSumSt += studio * nights;

                if (nights > 14)
                {
                    totalSumSt -= totalSumSt * 0.20;
                    totalSumApart -= totalSumApart * 0.1;
                }
                
            }
            else if (months.ToLower() == "july" || months.ToLower() == "august")
            {
                apartments = 77;
                studio = 76;
                totalSumApart += apartments * nights;
                totalSumSt += studio * nights;

                if (nights > 14)
                {
                    totalSumApart -= totalSumApart * 0.1;
                }
               
            }

            Console.WriteLine($"Apartment: {totalSumApart:0.00} lv.\nStudio: {totalSumSt:0.00} lv.");
        }

        public static void OnTime()
        {
            double examHour=double.Parse(Console.ReadLine());
            double examMinute=double.Parse(Console.ReadLine());
            double examTimeInMinutes = 0;
            double studentHour=double.Parse(Console.ReadLine());
            double studentMinute=double.Parse(Console.ReadLine());
            double studentTimeInMinutes = 0;
            examTimeInMinutes = (examHour*60) + examMinute;
            studentTimeInMinutes = (studentHour*60) + studentMinute;
            double difftime = studentTimeInMinutes - examTimeInMinutes;
            string arrival ="";
            
            if(difftime >0)
            {
                arrival = "Late";
            }
            else if (studentTimeInMinutes<examTimeInMinutes)
            {
                if (Math.Abs(difftime) <= 30)
                {
                    arrival = "On time";
                }
                else if (Math.Abs(difftime) >30)
                {
                    arrival = "Early";
                }
            }
           
           
        }
    }
}
