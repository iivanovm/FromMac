using System;

namespace notFinishTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double vacantionPrice = double.Parse(Console.ReadLine());
            double jportfolio=double.Parse(Console.ReadLine());
            string typeOfAction = "";
            double savingMoney = 0;
            double sumSavingMoney = jportfolio;
            int countSpend = 0;
            int dayscount = 0;
           
          
            while (sumSavingMoney<vacantionPrice&&countSpend<5)
            {
                typeOfAction = Console.ReadLine();
                savingMoney=double.Parse(Console.ReadLine());
                dayscount++;

                if(typeOfAction.ToLower() =="save")
                {
                    sumSavingMoney += savingMoney;
                    countSpend = 0;
                }
                else if (typeOfAction.ToLower() == "spend")
                {
                    countSpend++;
                    sumSavingMoney -= savingMoney;
                    if (sumSavingMoney <= 0)
                    {
                        sumSavingMoney = 0;
                    }
                }
                if (sumSavingMoney >= vacantionPrice)
                {
                    break;
                }
            }
            Console.WriteLine(countSpend >= 5? $"You can't save the money.\n{dayscount}":$"You saved the money for {dayscount} days.");
        }
    }
}
