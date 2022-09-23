using System;

namespace While_loop_From_P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            P04_Walking();
        }

        static void P03_Vacation()
        {
          double VacantionPrice=double.Parse(Console.ReadLine());   
          double YourMoney =double.Parse(Console.ReadLine());
            int daycount = 0;
            int spendcount = 0;
            string CmT = "";
            
            while (YourMoney<VacantionPrice&&spendcount<5)
            {
                CmT= Console.ReadLine();
               double money = double.Parse(Console.ReadLine());
                daycount++;

                if (CmT.ToLower() == "spend")
                {
                    YourMoney -= money;
                    if (YourMoney < 0)
                    {
                        YourMoney = 0;
                    }
                    spendcount++;
                }
                else if (CmT.ToLower() == "save")
                {
                    YourMoney += money;
                }
            }
           
            if (spendcount == 5)
            {
                Console.WriteLine($"You can't save the money.\n{daycount}");
               
            }
            else if (YourMoney >= VacantionPrice)
            {
                Console.WriteLine($"You saved the money for {daycount} days.");
            }

        }

        static void P04_Walking()
        {
            double DaySteps = 0;
            while (DaySteps <= 10000)
            {
                string CS= Console.ReadLine();
                if (CS.ToLower() == "going home")
                {
                    CS= Console.ReadLine();
                    DaySteps += double.Parse(CS);
                    break;

                }
                DaySteps += double.Parse(CS);
               
            }
            if (DaySteps < 10000)
            {
                Console.WriteLine($"{10000-DaySteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!\n{DaySteps-10000} steps over the goal!");
            }
            
        }

        static void P05_Coins()
        {
            
        }

    }


    
}
