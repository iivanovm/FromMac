using System;
using Lecture1;
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Threading;
namespace Lecture1
{
    public class Lab
    {

        static void LetStartAgain()
        {
            Console.Write("Please insert number of multiplication:_");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                Console.WriteLine($"Multiplication table with {i + 1}");
                for (int m = 1; m <= 10; m++)
                {
                    Console.Write($"\t{i} x {m} = {i * m}\n");
                }
            }
        }
        static void WeekDay()
        {
            int week = int.Parse(Console.ReadLine());
            switch (week)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Saturday"); break;
                case 6: Console.WriteLine("Sunday"); break;
                case 7: Console.WriteLine("Monday"); break;
                default: Console.WriteLine("Error"); ; break;

            }
        }
        static public void StudentInformation()
        {
            string StudenName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            decimal averageGrade = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {StudenName}, Age: {age}, Grade: {averageGrade}");
        }

        static public void Passed()
        {
            decimal grade = decimal.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }


        }

        static public void PassedOrFailed()
        {
            decimal grade = decimal.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }

        static public void BackIn30Minutes()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes >= 59)
            {
                hours++;
                minutes -= 60;


            }
            if (hours >= 23)
            {
                hours = 00;

            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }

        static public void MonthPrinter()
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("September"); break;
                case 9: Console.WriteLine("January"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Error!"); break;
            }
        }

        static public void ForeignLanguages()
        {
            string lang = Console.ReadLine();
            if (lang.ToLower() == "usa" || lang.ToLower() == "england")
            {
                Console.WriteLine("English");
            }
            else if (lang.ToLower() == "spain" || lang.ToLower() == "argentina" || lang.ToLower() == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }

        static public void TheatrePromotion()
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            switch (typeOfDay.ToLower())
            {
                case "weekday":
                    if (age >= 0 && age <= 18) { Console.WriteLine("12$"); }
                    else if (age > 18 && age <= 64) { Console.WriteLine("18$"); }
                    else if (age > 64 && age <= 122) { Console.WriteLine("12$"); }
                    else { Console.WriteLine("Error!"); }
                    break;
                case "weekend":
                    if (age >= 0 && age <= 18) { Console.WriteLine("15$"); }
                    else if (age > 18 && age <= 64) { Console.WriteLine("20$"); }
                    else if (age > 64 && age <= 122) { Console.WriteLine("15$"); }
                    else { Console.WriteLine("Error!"); }
                    break;
                case "holiday":
                    if (age >= 0 && age <= 18) { Console.WriteLine("5$"); }
                    else if (age > 18 && age <= 64) { Console.WriteLine("12$"); }
                    else if (age > 64 && age <= 122) { Console.WriteLine("10$"); }
                    else { Console.WriteLine("Error!"); }
                    break;
                default: Console.WriteLine("Error!"); break;
            }
        }

        static public void DivisibleByThree()
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static public void SumOfOddNumbers()
        {
            int number = int.Parse(Console.ReadLine());
            int oddcounter = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    oddcounter++;
                    sum += i;
                }
                if (oddcounter == number)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");

        }

        static public void MultiplicationTable()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }

        static public void MultiplicationTable2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m > 10)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
            }
            else
            {
                for (int i = m; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }

        static public void EvenNUmber()
        {
            int number = int.Parse(Console.ReadLine());

            while (number % 2 != 0)
            {


                Console.WriteLine("Please write an even number.");

                number = int.Parse(Console.ReadLine());
            }
            if (Math.Abs(number) % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
            }

        }

        static public void HolidaysBetweenTwoDates()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                        "dd.m.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "dd.m.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday &&
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            Console.WriteLine(holidaysCount);
        }
    }
}