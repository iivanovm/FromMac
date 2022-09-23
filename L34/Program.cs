using System;

using System.Collections.Generic;
namespace L34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Histogram();

        }

        static void Tr()
        {
            double budget = double.Parse(Console.ReadLine());
            string ses = Console.ReadLine();
            var dchoice = new Dictionary<string, string>
            {
                {"summer","Camp"},
                {"winter","Hotel" }
            };

            if (budget <= 100)
            {
                if (ses.ToLower() == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria\n{dchoice[ses.ToLower()]} - {(budget * 0.30).ToString("0.00")}");
                }
                else
                {
                    Console.WriteLine($"Somewhere in Bulgaria\n{dchoice[ses.ToLower()]} - {(budget * 0.70).ToString("0.00")}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (ses.ToLower() == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans\n{dchoice[ses.ToLower()]} - {(budget * 0.40).ToString("0.00")}");
                }
                else
                {
                    Console.WriteLine($"Somewhere in Balkans\n{dchoice[ses.ToLower()]} - {(budget * 0.80).ToString("0.00")}");
                }
            }
            else if (budget >= 1000)
            {

                Console.WriteLine($"Somewhere in Europe\nHotel - {(budget * 0.90).ToString("0.00")}");

            }
        }
        static void OperationsBetweenNumbers()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double Total = 0.00;
            switch (oper)
            {

                case "+": Total = n1 + n2; if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); } else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;
                case "-": Total = n1 - n2; if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); } else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;
                case "*": Total = n1 * n2; if (Total % 2 == 0) { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - even"); } else { Console.WriteLine($"{n1} {oper} {n2} = {Math.Round(Total, 2)} - odd"); }; break;
                case "/": Total = n1 / n2; if (n2 == 0) { Console.WriteLine($"Cannot divide {n1} by zero"); } else { Console.WriteLine($"{n1} {oper} { n2} = {Math.Round(Total, 2)}"); }; break;
                case "%": Total = n1 % n2; if (n2 == 0) { Console.WriteLine($"Cannot divide {n1} by zero"); } else { Console.WriteLine($"{n1} {oper} { n2} = {Math.Round(Total, 2)}"); }; break;
            }
        }

        static void Histogram()
        {
            double num = double.Parse(Console.ReadLine());
            string u1 = "";
            string u2 = "";
            string u3 = "";
            string u4 = "";
            string u5 = "";
           
            List <double> u200= new List <double>();
            List<double> u200399 = new List<double>();
            List<double> u400599 = new List<double>();
            List<double> u600799 = new List<double>();
            List <double> u800 = new List<double>();
            List <int> list= new List <int>();
            for (int i = 0; i < num; i++)
            {
               

                double press = double.Parse(Console.ReadLine());
                if(press < 200)
                {
                    u200.Add(press);
                }
                else if (press >= 200 && press <= 399)
                {
                    u200399.Add(press);
                }
                else if(press >=400&&press <= 599)
                {
                    u400599.Add(press);
                }
                else if (press >=600&& press <= 799)
                {
                    u600799.Add(press);
                }
                else if (press >=800)
                {
                    u800.Add(press);
                }
            }
            foreach(double star in u200)
            {
                u1 +=star+",";
               // Console.WriteLine($"||< 200|-->|{u1}|-->|{u200.Count}|-->{(u200.Count / num * 100).ToString("0.00")}||");
            }
            foreach (double star1 in u200399)
            {
                u2 += star1 + ",";
               // Console.WriteLine($"||200 … 399|-->|{u2}|-->|{u200399.Count}|-->{(u200399.Count / num * 100).ToString("0.00")}||");
            }
            foreach (double star2 in u400599)
            {
                u3 += star2 + ",";
                //Console.Write($"||400 … 599|-->|{u3}|-->|{u400599.Count}|-->{(u400599.Count / num * 100).ToString("0.00")}||");
            }
            foreach (double star3 in u600799)
            {
                u4 += star3 + ",";
                //Console.Write ($"||600 … 799|-->|{u4}|-->|{u600799.Count}|-->{(u600799.Count / num * 100).ToString("0.00")}||");
            }
            foreach (double star4 in u800)
            {
                u5 += star4 + ",";
               // Console.WriteLine($"||≥ 800|-->|{u5}|-->|{u800.Count}|-->{(u800.Count / num * 100).ToString("0.00")}||");
            }

            list.Add(u1.Length);
            list.Add(u2.Length);
            list.Add(u3.Length); 
            list.Add(u4.Length);
            list.Add(u5.Length);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('=', 58) + "Start" + new string('=', 59));
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ',11)}Diapson{new string(' ', 11)}|{new string(' ', 13)}List{new string(' ', 13)}|{new string(' ', 12)}Count{new string(' ', 12)}|{new string(' ', 10)}Precentage{new string(' ', 9)}|");
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ', 11)}<200{new string(' ', 14)}|{new string(' ', 15- u1.Length/2)}{u1}{new string(' ',  15- u1.Length/2 )}|{new string(' ', 14)}{u200.Count}{new string(' ', 14)}|{new string(' ', 11)}{(u200.Count/num*100).ToString("0.00")}{new string(' ', 14)}|");
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ', 10)}200-399{new string(' ', 12)}|{new string(' ', 15 - u2.Length / 2)}{u2}{new string(' ', 15 - u2.Length / 2)}|{new string(' ', 14)}{u200399.Count}{new string(' ', 14)}|{new string(' ', 11)}{(u200399.Count / num * 100).ToString("0.00")}{new string(' ', 14)}|");
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ', 10)}400-599{new string(' ', 12)}|{new string(' ', 15 - u3.Length / 2)}{u3}{new string(' ', 15 - u3.Length / 2)}|{new string(' ', 14)}{u400599.Count}{new string(' ', 14)}|{new string(' ', 11)}{(u400599.Count / num * 100).ToString("0.00")}{new string(' ', 14)}|");
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ', 10)}600-799{new string(' ', 12)}|{new string(' ', 15 - u4.Length / 2)}{u4}{new string(' ', 15 - u4.Length / 2)}|{new string(' ', 14)}{u600799.Count}{new string(' ', 14)}|{new string(' ', 11)}{(u600799.Count / num * 100).ToString("0.00")}{new string(' ', 14)}|");
            Console.WriteLine(new string('_', 123));
            Console.WriteLine($"|{new string(' ', 11)}>800{new string(' ', 14)}|{new string(' ', 15 - u5.Length / 2)}{u5}{new string(' ', 15 - u5.Length / 2)}|{new string(' ', 14)}{u800.Count}{new string(' ', 14)}|{new string(' ', 11)}{(u800.Count / num * 100).ToString("0.00")}{new string(' ', 14)}|");
            Console.WriteLine(new string('_', 123)); Console.WriteLine();
            Console.WriteLine(new string('=', 58) + "End" + new string('=', 59));
            Console.ReadKey();
        }
    }
}
