using System.Globalization;
using System;
using System.Collections.Generic;

internal class Exercise
{
    static public void Ages()
    {
        int age = int.Parse(Console.ReadLine());
        if (age < 3 || age <= 0)
        {
            Console.WriteLine("baby");
        }
        else if (age <= 3 || age <= 13)
        {
            Console.WriteLine("child");
        }
        else if (age <= 14 || age <= 19)
        {
            Console.WriteLine("teenager");
        }
        else if (age <= 20 || age <= 65)
        {
            Console.WriteLine("adult");
        }
        else
        {
            Console.WriteLine("elder");
        }
    }

    internal static int Division(int num)
    {

        if (num % 10 == 0)
        {
            Console.WriteLine($"The number is divisible by 10");
        }
        else if (num % 7 == 0)
        {
            Console.WriteLine($"The number is divisible by 7");
        }
        else if (num % 6 == 0)
        {
            Console.WriteLine($"The number is divisible by 6");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine($"The number is divisible by 3");

        }
        else if (num % 2 == 0)
        {
            Console.WriteLine($"The number is divisible by 2");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }

        return num;
    }

    public static void Division1()
    {
        int num = int.Parse(Console.ReadLine());
        if (num % 10 == 0)
        {
            Console.WriteLine($"The number is divisible by 10");
        }
        else if (num % 7 == 0)
        {
            Console.WriteLine($"The number is divisible by 7");
        }
        else if (num % 6 == 0)
        {
            Console.WriteLine($"The number is divisible by 6");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine($"The number is divisible by 3");

        }
        else if (num % 2 == 0)
        {
            Console.WriteLine($"The number is divisible by 2");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }
    }

    public static void Vacantion()
    {
        int numP = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();
        double totalsum = 0.00;
        double price = 0.00;
        if (day.ToLower() == "friday")
        {
            switch (groupType.ToLower())
            {
                case "students": price = 8.45; if (numP >= 30.00) { totalsum = price * numP; totalsum -= totalsum *= 0.15; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "business": price = 10.90; if (numP >= 100.00) { totalsum = price * (numP - 10.00); Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "regular": price = 15.00; if (numP >= 10.00 && numP <= 20.00) { totalsum = price * numP; totalsum -= totalsum *= 0.05; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
            }
        }
        else if (day.ToLower() == "saturday")
        {
            switch (groupType.ToLower())
            {
                case "students": price = 9.80; if (numP >= 30.00) { totalsum = price * numP; totalsum -= totalsum *= 0.15; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "business": price = 15.60; if (numP >= 100.00) { totalsum = price * (numP - 10.00); Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "regular": price = 20.00; if (numP >= 10.00 && numP <= 20.00) { totalsum = price * numP; totalsum -= totalsum *= 0.05; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
            }
        }
        else if (day.ToLower() == "sunday")
        {
            switch (groupType.ToLower())
            {
                case "students": price = 10.46; if (numP >= 30.00) { totalsum = price * numP; totalsum -= totalsum *= 0.15; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "business": price = 16.00; if (numP >= 100.00) { totalsum = price * (numP - 10.00); Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
                case "regular": price = 22.50; if (numP >= 10.00 && numP <= 20.00) { totalsum = price * numP; totalsum -= totalsum *= 0.05; Console.WriteLine($"Total price: {totalsum:f2}"); } else { totalsum = price * numP; Console.WriteLine($"Total price: {totalsum:f2}"); }; break;
            }
        }


    }

    internal static int PrSum(int numOne, int numTwo)
    {
        int sum = 0;
        for (int i = numOne; i <= numTwo; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }
        Console.WriteLine($"\nSum: {sum}");

        return sum;
    }

    public static void printAndSum()
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = numOne; i <= numTwo; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }
        Console.WriteLine($"\nSum: {sum}");
    }

    public static void Login()
    {
        string userName = Console.ReadLine();
        string password = string.Empty;

        for (int i = userName.Length - 1; i >= 0; i--)
        {
            char symbol = userName[i];
            password += symbol;
        }

        for (int i = 0; i < 4; i++)
        {
            string currentPassword = Console.ReadLine();

            if (currentPassword == password)
            {
                Console.WriteLine($"User {userName} logged in.");
                break;
            }
            else if (password != currentPassword && i >= 0 && i < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
            else if (password != currentPassword && i == 3)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }

    public static bool IsStrong(int n)
    {
        long sum = 0;
        int n2 = n;

        while (n2 > 0)
        {
            sum += Fac(n2 % 10);
            n2 = n2 / 10;
        }

        return sum == n;
    }
    public static long Fac(long n)
    {
        var i = 1;
        for (; n > 1; n--)
        {
            i *= (int)n;
        }
        return i;
    }
    public static void StrongNumber()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsStrong(number) ? "yes" : "no");
    }

    public static void VendingMachine()
    {
        string command = String.Empty;
        string productname = string.Empty;
        double coins = 0.00;
        List<double> validCoins = new List<double>();
        validCoins.Add(0.1);
        validCoins.Add(0.2);
        validCoins.Add(0.5);
        validCoins.Add(1);
        validCoins.Add(2);
        Dictionary<string, double> productPrice = new Dictionary<string, double>
           {
               {"Nuts" ,2.0},
               { "Water",0.7},
               {"Crisps" ,1.5},
               {"Soda", 0.8},
               {"Coke",1.0}
            };
        double sum = 0.00;


        while (command != "Start")
        {
            command = Console.ReadLine();
            if (command == "Start") { break; }
            coins = double.Parse(command);
            if (validCoins.Contains(coins))
            {
                sum += coins;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coins}");
            }
        }
        while (productname != "End")
        {
            productname = Console.ReadLine();
            double varb = productPrice.GetValueOrDefault(productname, 0.00);
            if (productname == "End") { break; }

            if (varb == 0.00)
            {
                Console.WriteLine("Invalid product");
            }
            else
            {

                if ((sum - varb) < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    sum -= productPrice.GetValueOrDefault(productname, 0.00);
                    Console.WriteLine($"Purchased {productname.ToLower()}");
                }
            }
        }

        Console.WriteLine($"Change: {sum:f2}");
    }

    public static void TriangleOfNumbers()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++) // <=

        {
            //Console.WriteLine(row);
            for (int col = 1; col <= row; col++)
            {
                Console.Write(row + " ");

            }
            Console.WriteLine();
        }
    }
}