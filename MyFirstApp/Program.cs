using System;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            f();
        }

        static void f()
        {

            me.MoreEx.WeatherForecast2();

        }
    }

    public class lab
    {
        public static void pavi()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
        }

        public static void recareae(int a, int b)
        {
            //  int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a * b);

        }
        public static void inchtocm()
        {
            double inches = 2.54;
            double cm = double.Parse(Console.ReadLine());
            Console.WriteLine(cm * inches);
        }
        public static void grbyname()
        {
            string name = Console.ReadLine();
            Console.Write("Hello, {0}!", name);

        }
        public static void ConcatenateData()
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", fname, lname, age, city);
        }
        public static void ProjectsCreation()
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, 3 * project, project);
        }
        public static void PetShop()
        {
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} lv.", dog * 2.5 + cat * 4);
        }
        public static void YardGreening()
        {

            double size = double.Parse(Console.ReadLine());

            Console.WriteLine("The final price is: {0} lv.\nThe discount is: {1} lv.", size * 7.61 - size * 7.61 * 0.18, size * 7.61 * 0.18);
        }
    }

}
namespace Exer
{
    static class exerc
    {
        public static void CurrencyUSDtoBGN()
        {
            double currencyBGN = double.Parse(Console.ReadLine());
            double currencyUSD = 1.79549;
            Console.WriteLine(currencyBGN * currencyUSD);
        }
        public static void RadianstoDegrees()
        {
            double radians = double.Parse(Console.ReadLine());
            double degrs = radians * 180 / Math.PI;
            Console.WriteLine(degrs);
        }
        public static void DepositCalculator()
        {
            double DepoSum = double.Parse(Console.ReadLine());
            int DepoMonths = int.Parse(Console.ReadLine());
            double DepoPrecentY = double.Parse(Console.ReadLine());
            double pr = DepoSum * (DepoPrecentY / 100 / 12);
            Console.WriteLine(DepoSum + pr * DepoMonths);
        }
        public static void VacationBooksList()
        {
            double pages = double.Parse(Console.ReadLine());
            double pagesperhour = double.Parse(Console.ReadLine());
            double numdays = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(pages / pagesperhour / numdays));

        }
        public static void SuppliesforSchool()
        {
            double hpack = 5.8 * double.Parse(Console.ReadLine());
            double mpack = 7.20 * double.Parse(Console.ReadLine());
            double lpack = 1.2 * double.Parse(Console.ReadLine());
            double dis = double.Parse(Console.ReadLine()) / 100;
            double sum = hpack + mpack + lpack;
            Console.WriteLine(sum - sum * dis);
        }
        public static void Repainting()
        {
            double nl = 2 + double.Parse(Console.ReadLine());
            double plitr = double.Parse(Console.ReadLine());
            double rpaint = 5.0 * double.Parse(Console.ReadLine());
            double workhours = double.Parse(Console.ReadLine());
            double nlt = nl * 1.5;
            double tmat = nl * 1.5 + (plitr * 0.1 + plitr) * 14.5 + (rpaint + 0.4);
            Console.WriteLine(tmat + tmat * 0.3 * workhours);
        }
        public static void FoodDelivery()
        {
            double chick = 10.35 * double.Parse(Console.ReadLine());
            double fish = 12.4 * double.Parse(Console.ReadLine());
            double vege = 8.15 * double.Parse(Console.ReadLine());
            Console.WriteLine(chick + fish + vege + 2.5 + (chick + fish + vege) * 0.2);
        }
        public static void BasketballEquipment()
        {
            double BBtax = double.Parse(Console.ReadLine());
            double BBsh = BBtax - BBtax * 0.4;
            double BBtsh = BBsh - BBsh * 0.2;
            double BBbl = BBtsh / 4;
            double bbacc = BBbl / 5;
            Console.WriteLine(BBtax + BBsh + BBtsh + BBbl + bbacc);
        }
        public static void FishTank()
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());
            double ttlitre = l * w * h * 0.001;
            Console.WriteLine(ttlitre * (1 - precent / 100));

        }
    }
}
namespace me
{
    public class MoreEx
    {
        public static void TrapeziodArea()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float tt = (a + b) * h / 2f;
            Console.WriteLine(tt.ToString("0.00"));
        }
        public static void TriangleArea()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            Console.Write((a * h / 2).ToString("0.00"));
        }
        public static void CelsiustoFahrenheit()
        {
            double cel = double.Parse(Console.ReadLine());
            Console.WriteLine((cel * 1.8 + 32).ToString("0.00"));
        }
        public static void VegetableMarket()
        {
            double prpkgn = double.Parse(Console.ReadLine());
            double prpkgm = double.Parse(Console.ReadLine());
            double totaln = double.Parse(Console.ReadLine());
            double totalm = double.Parse(Console.ReadLine());
            Console.WriteLine(((prpkgn * totaln + prpkgm * totalm) / 1.94).ToString("0.00"));
        }
        public static void TrainingLab()
        {
            double w = 100 * double.Parse(Console.ReadLine());
            double h = 100 * double.Parse(Console.ReadLine()) - 100;
            Console.WriteLine((int)(h / 70) * (int)(w / 120) - 3);
        }
        public static void Fishland()
        {
            double priceskum = double.Parse(Console.ReadLine());
            double pricecac = double.Parse(Console.ReadLine());
            double weightpa = double.Parse(Console.ReadLine());
            double weightsaf = double.Parse(Console.ReadLine());
            double wightmid = double.Parse(Console.ReadLine());
            double pricemid = 7.5;
            double pricesaf = pricecac + pricecac * 0.8;
            double pricepa = priceskum + priceskum * 0.6;
            Console.WriteLine((wightmid * pricemid + weightsaf * pricesaf + weightpa * pricepa).ToString("0.00"));


        }
        public static void HousePainting()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double greenpaint = 3.4;
            double redpaint = 4.3;

            double door = 1.2 * 2;
            double lside = 2 * (x * x) - door;
            double trside = 2 * (0.5 * x * h);
            double windows = 2 * 1.5 * 1.5;
            double fside = 2 * (x * y) - windows;
            double tr = 2 * (x * h / 2);
            Console.WriteLine(((fside + lside) / greenpaint).ToString("0.00") + "\n" + ((fside + windows + tr) / redpaint).ToString("0.00"));

        }
        public static void CircleAreaandPerimeter()
        {
            double r = double.Parse(Console.ReadLine());
            double area = 2 * Math.PI * r;
            double s = Math.PI * r * r;
            Console.WriteLine(s.ToString("0.00") + "\n" + area.ToString("0.00"));
        }
        public static void WeatherForecast()
        {
            string weat = Console.ReadLine();

            if (weat.ToLower() == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
        public static void WeatherForecast2()
        {
            double degree = double.Parse(Console.ReadLine());
            if (degree >= 26 && degree <= 35)
            {
                Console.WriteLine("Hot");
            }
            else if (degree >= 20.1 && degree <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15 && degree <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12 && degree <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
