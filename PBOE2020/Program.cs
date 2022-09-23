using System;

namespace PBOE2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuJud.BarCodeGenerator();
        }
    }

    public class TuJud
    {
        public static void AluminumJoinery()
        {
            int numJoinery = int.Parse(Console.ReadLine());
            string typeOfJoinery = Console.ReadLine();
            string deliveryType = Console.ReadLine();
            double price = 0;
            if (numJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (typeOfJoinery)
            {
                case "90X130":
                    price = numJoinery * 110; if (numJoinery > 30 && numJoinery < 60) { price -= price * 0.05; } else if (numJoinery > 60) { price -= price * 0.08; };
                    break;
                case "100X150":
                    price = numJoinery * 140; if (numJoinery > 40 && numJoinery < 80) { price -= price * 0.06; } else if (numJoinery > 80) { price -= price * 0.10; }
                    break;
                case "130X180":
                    price = numJoinery * 190; if (numJoinery > 20 && numJoinery < 50) { price -= price * 0.07; } else if (numJoinery > 50) { price -= price * 0.12; }
                    break;
                case "200X300":
                    price = numJoinery * 250; if (numJoinery > 25 && numJoinery < 50) { price -= price * 0.09; } else if (numJoinery > 50) { price -= price * 0.14; }
                    break;
            }
            if (deliveryType == "With delivery")
            {
                price += 60;
            }
            else
            {
                price += 0;
            }
            if (numJoinery > 99)
            {
                price -= price * 0.04;
            }
            Console.WriteLine($"{price:f2} BGN");
        }

        public static void Balls()
        {
            double ballsNum = int.Parse(Console.ReadLine());
            double totalPoint = 0.00;
            int OranagePoint = 0;
            int yellowPoint = 0;
            int whitePoint = 0;
            int blackPoint = 0;
            int red = 0;
            int other = 0;
            for (int i = 1; i <= ballsNum; i++)
            {
                string ballsType = Console.ReadLine();
                switch (ballsType.ToLower())
                {
                    case "red": totalPoint += 5; red++; break;
                    case "orange": totalPoint += 10; OranagePoint++; break;
                    case "yellow": totalPoint += 15; yellowPoint++; break;
                    case "white": totalPoint += 20; whitePoint++; break;
                    case "black": Math.Floor(totalPoint /= 2); blackPoint++; break;
                    default: other++; break;
                }
            }
            Console.WriteLine($"Total points: {Math.Floor(totalPoint)}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {OranagePoint}");
            Console.WriteLine($"Yellow balls: {yellowPoint}");
            Console.WriteLine($"White balls: {whitePoint}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {blackPoint}");

        }

        public static void BestPlayer()
        {
            string command;
            int max = int.MinValue;
            string bestpl = string.Empty;
            int goals = 0;
            string playerName = "";
            while ((command = Console.ReadLine()).ToUpper() != "END")
            {
                if (command.ToUpper() == "END") { break; }
                 playerName = command;
                goals = int.Parse(Console.ReadLine());
                if (goals > max)
                {
                    max = goals;
                    bestpl = command;
                }
                if (goals >= 10)
                {
                   
                    break;
                }
            }
            Console.WriteLine($"{bestpl} is the best player!");
            Console.WriteLine(goals >= 3 ? $"He has scored {goals} goals and made a hat-trick !!!" : $"He has scored {goals} goals.");
        }

        public static void BarCodeGenerator()
        {
            int startnum = int.Parse(Console.ReadLine());
            int endnum = int.Parse(Console.ReadLine());
            string start = startnum.ToString();
            string end = endnum.ToString();
            int fstart = int.Parse(start[0].ToString());
            int fend = int.Parse(end[0].ToString());
            int tstart = int.Parse(start[1].ToString());
            int tend = int.Parse(end[1].ToString());  
            int trstart=int.Parse(start[2].ToString());
            int trend=int.Parse(end[2].ToString());
            int ffstart=int.Parse(start[3].ToString());
            int ffend=int.Parse(end[3].ToString());
            for (int i = fstart; i <=fend; i++)
            {
                for (int j=tstart; j <=tend; j++)
                {
                    for (int var=trstart; var <=trend; var++)
                    {
                        for (int k=ffstart; k <=ffend; k++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && var % 2 != 0 && k % 2 != 0)
                            {
                                Console.Write($"{i}{j}{var}{k} ");
                            }
                        }
                    }
                }
            }
           
            

        }
    }
}
