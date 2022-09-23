using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());

            int goingToMusala = 0;
            int goingToMonthblanc = 0;
            int goingToKilimandjaro = 0;
            int goingToK2 = 0;
            int goingToEverest = 0;

            int allPeople = 0;


            for (int i = 1; i <= groupNum; i++)
            {
                int peopleInGroupNum = int.Parse(Console.ReadLine());
                allPeople += peopleInGroupNum;

                if (peopleInGroupNum >= 1 && peopleInGroupNum <= 5)
                {
                    goingToMusala += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 6 && peopleInGroupNum <= 12)
                {
                    goingToMonthblanc += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 13 && peopleInGroupNum <= 25)
                {
                    goingToKilimandjaro += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 26 && peopleInGroupNum <= 40)
                {
                    goingToK2 += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 41)
                {
                    goingToEverest += peopleInGroupNum;
                }
            }
            double percentMusala = goingToMusala / (allPeople * 1.0);
            Console.WriteLine($"{percentMusala:f2}%");

            double percentMonthblanc = goingToMonthblanc / (allPeople * 1.0);
            Console.WriteLine($"{percentMonthblanc:f2}%");

            double percentKilimandjaro = goingToKilimandjaro / (allPeople * 1.0);
            Console.WriteLine($"{percentKilimandjaro:f2}%");

            double percentK2 = goingToK2 / (allPeople * 1.0);
            Console.WriteLine($"{percentK2:f2}%");

            double percentEverest = goingToEverest / (allPeople * 1.0);
            Console.WriteLine($"{percentEverest:f2}%");
        }

    }
}