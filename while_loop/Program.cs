using System;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            decimal price = 0.00m;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.50m;
                }
                if (fruit == "apple")
                {
                    price = quantity * 1.20m;
                }
                if (fruit == "orange")
                {
                    price = quantity * 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = quantity * 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = quantity * 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = quantity * 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = quantity * 3.85m;
                }

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.70m;
                }
                if (fruit == "apple")
                {
                    price = quantity * 1.25m;
                }
                if (fruit == "orange")
                {
                    price = quantity * 0.90m;
                }
                if (fruit == "grapefruit")
                {
                    price = quantity * 1.60m;
                }
                if (fruit == "kiwi")
                {
                    price = quantity * 3.00m;
                }
                if (fruit == "pineapple")
                {
                    price = quantity * 5.60m;
                }
                if (fruit == "grapes")
                {
                    price = quantity * 4.20m;
                }
                Console.WriteLine(Math.Round(price, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
          

        }
    }
}
