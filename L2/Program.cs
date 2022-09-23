using System;

namespace L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exer.l2.FuelTankPartTwo();
        }
    }
    namespace lab
    {
        public class l2
        {
            public static void ExcellentResult()
            {
                double a = double.Parse(Console.ReadLine());
                if (a >= 5.5)
                {
                    Console.WriteLine("Excellent!");
                }
                else
                {
                    //to do nothing :)
                }
            }
            public static void GreaterNumber()
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Max(a, b));
            }
            public static void EvenOrOdd()
            {
                double a = double.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            public static void PasswordGuess()
            {
                string pass = "s3cr3t!P@ssw0rd";
                string uinput = Console.ReadLine();
                if (uinput == pass)
                {
                    Console.WriteLine("Welcome");

                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }

            }
            public static void NumberOT()
            {
                double  num= double.Parse(Console.ReadLine());
                if (num < 100)
                {
                    Console.WriteLine("Less than 100");
                }
                else if (num >= 100 && num <= 200)
                {
                    Console.WriteLine("Between 100 and 200");
                }
                else if (num > 200)
                {
                    Console.WriteLine("Greater than 200");
                }
            }
            public static void SpeedInfo()
            {
                double speed = double.Parse(Console.ReadLine());
                if(speed <= 10)
                {
                    Console.WriteLine("slow");
                }
                else if (speed>10 && speed <= 50)
                {
                    Console.WriteLine("average");
                }
                else if (speed > 50 && speed <= 150)
                {
                    Console.WriteLine("fast");
                }
                else if (speed >150&&speed <= 1000)
                {
                    Console.WriteLine("ultra fast");
                }
                else
                {
                    Console.WriteLine("extremely fast");
                }
            }
            public static void AreaOfFigures()
            {
                //square, rectangle, circle или triangle
                string area = Console.ReadLine();
                if (area == "square")
                {
                    double a=double.Parse(Console.ReadLine());
                    Console.WriteLine((a * a).ToString("0.000"));
                }
                else if (area == "rectangle")
                {
                    double a = double.Parse(Console.ReadLine());
                    double b=double.Parse(Console.ReadLine());
                    Console.WriteLine((a * b).ToString("0.000"));
                }
                else if (area == "circle")
                {
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine((Math.PI*r*r).ToString("0.000"));
                }
                else if (area == "triangle")
                {
                    double a = double.Parse(Console.ReadLine());
                    double b  = double.Parse(Console.ReadLine());
                    Console.WriteLine((a * b / 2).ToString("0.000"));
                }
                else
                {
                    Console.WriteLine("Out of my list");
                }
            }
        }
    }
    namespace exer
    {
        public class l2
        {
            public static void SumSeconds()
            {
                int Ftime=int.Parse(Console.ReadLine());
                int Stime=int.Parse(Console.ReadLine());
                int Ttime=int.Parse(Console.ReadLine());

                int totaltime = Ftime + Stime + Ttime;
                int min=totaltime/60;
                int sec=totaltime%60;
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}",min,sec);
                }
                else
                {
                    Console.WriteLine($"{min}:{sec}");
                }
            }
            public static void BonusScore()
            {
                double num=double.Parse(Console.ReadLine());
                double bonusscore = 0.0;
                if (num < 100)
                {
                    bonusscore = 5;
                   
                }
                else if (num > 1000)
                {
                    bonusscore = (num * 0.1);
                }
                else  
                {
                    bonusscore = (num * 0.2);
                }
              
                if (num % 2 == 0)
                {
                    bonusscore+= 1;
                }
                else if (num % 10 == 5)
                {
                    bonusscore += 2;
                }
                Console.WriteLine(bonusscore);
                Console.WriteLine(num + bonusscore);
            }
            public static void TimePlus15Minutes()
            {
                int hour = int.Parse(Console.ReadLine());
                int minute = 15+int.Parse(Console.ReadLine());


                if (minute > 59)
                {
                    hour++;
                    minute = minute - 60;
                    if (minute < 10)
                    {
                        if (hour == 24) { hour = 0; }
                        Console.WriteLine($"{hour}:0{minute}");
                    }
                    else
                    {
                        if (hour == 24) { hour = 0; }
                        Console.WriteLine($"{hour}:{minute}");
                    }
                }
                else
                {
                    if (hour == 24) { hour = 0; }
                    Console.WriteLine($"{hour}:{minute}");
                }
                
            }
            public static void ToyShop()
            {
                double puzzle = 2.6;
                double spk = 3;
                double bear = 4.1;
                double minion = 8.2;
                double truck = 2;
                double VacantionPrice=double.Parse(Console.ReadLine());
                double npuzzle=double.Parse(Console.ReadLine());    
                double nspk=double.Parse(Console.ReadLine());
                double nbear=double.Parse(Console.ReadLine());
                double nminion=double.Parse(Console.ReadLine());
                double ntruck=double.Parse(Console.ReadLine());
                double toytotalprice=(puzzle*npuzzle)+(spk*nspk)+(bear*nbear)+(minion*nminion)+(truck*ntruck);
                double totalsum=npuzzle+nspk+nbear+nminion+ntruck;
                if(totalsum>=50)
                {
                    toytotalprice = toytotalprice - (toytotalprice * 0.25);
                    toytotalprice = toytotalprice - (toytotalprice * 0.1);
                    if (toytotalprice >= VacantionPrice)
                    {
                        double pr =toytotalprice - VacantionPrice;
                        Console.WriteLine($"Yes! {pr.ToString("0.00")} lv left.");
                    }
                    else
                    {
                        double pr = Math.Max(toytotalprice,VacantionPrice)-Math.Min(toytotalprice,VacantionPrice);
                        Console.WriteLine($"Not enough money! {pr.ToString("0.00")} lv needed.");
                       
                    }
                }
                else
                {
                  
                    toytotalprice = toytotalprice - (toytotalprice * 0.1);
                    if (toytotalprice >= VacantionPrice)
                    {
                        double pr = Math.Round(toytotalprice - VacantionPrice,2);
                        Console.WriteLine($"Yes! {pr.ToString("0.00")} lv left.");
                    }
                    else
                    {
                        double pr = Math.Max(toytotalprice, VacantionPrice) - Math.Min(toytotalprice, VacantionPrice);
                        Console.WriteLine($"Not enough money! {pr.ToString("0.00")} lv needed.");

                    }
                }
            }
            public static void GodzillaVsKong()
            {
                double budget=double.Parse(Console.ReadLine());
                double nstat=double.Parse(Console.ReadLine());
                double priceclothing=double.Parse(Console.ReadLine());
                double dk = budget * 0.1;
                double clpricewithoutdiscount = nstat * priceclothing;
                double clpricewithdiscount=(nstat * priceclothing)-(nstat*priceclothing*0.1);
                if (nstat >= 150)
                {
                    double totalprice = clpricewithdiscount + dk;
                    if (totalprice <= budget)
                    {
                        Console.WriteLine($"Action!\nWingard starts filming with {(budget - totalprice).ToString("0.00")} leva left.");//
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money!\nWingard needs {(totalprice - budget).ToString("0.00")} leva more.");
                    }
                }
                else
                {
                    double totalprice = clpricewithoutdiscount + dk;
                    if (totalprice <= budget)
                    {
                        Console.WriteLine($"Action!\nWingard starts filming with {(budget - totalprice).ToString("0.00")} leva left.");//
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money!\nWingard needs {(totalprice - budget).ToString("0.00")} leva more.");
                    }

                }
                    
            }
            public static void WorldSwimmingRecord()
            {
                double recordinsec=double.Parse(Console.ReadLine());
                double ppinmeters=double.Parse(Console.ReadLine());
                double timeinsec=double.Parse(Console.ReadLine());
                double irec = (ppinmeters * timeinsec) + (Math.Truncate((ppinmeters/15))*12.5);

              
            if (irec < recordinsec)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(irec).ToString("0.00")} seconds.");

                }
                else
                {
                    Console.WriteLine($"No, he failed! He was {Math.Abs((irec-recordinsec)).ToString("0.00")} seconds slower.");
                }
            }
            public static void Shoping()
            {
                double vcprice=250.0;
                double budget =double.Parse(Console.ReadLine());
                double vcnum=double.Parse(Console.ReadLine());
                double cpunum=double.Parse(Console.ReadLine());
                double rampnum=double.Parse(Console.ReadLine());
                double cpuprice = (vcprice*vcnum) * 0.35;
                double ramprice = (vcprice*vcnum) * 0.1;
                if (vcnum > cpunum)
                {
                    double total=((vcprice*vcnum)+ (cpuprice*cpunum)+(ramprice*rampnum));
                    total = total - (total * 0.15);
                    if (total <= budget)
                    {
                        Console.Write($"You have {(budget - total).ToString("0.00")} leva left!");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(total - budget).ToString("0.00")} leva more!");
                    }
                }
                else
                {
                    double total = ((vcprice * vcnum) + (cpuprice * cpunum) + (ramprice * rampnum));
                    
                    if (total <=budget)
                    {
                        Console.Write($"You have {(budget - total).ToString("0.00")} leva left!");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(total - budget).ToString("0.00")} leva more!");
                    }
                }
            }
            public static void LunchBreak()
            {
                //Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде 1/4 от времето за почивка. 
                string name=Console.ReadLine();
                int times=int.Parse(Console.ReadLine());
                double breaktime=double.Parse(Console.ReadLine());
                double relaxtime = breaktime * 0.125;
                double breakt = breaktime * 0.25;
                double esttime = (breaktime-(relaxtime+breakt));
                if(esttime >= times)
                {
                    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Round((times-esttime),MidpointRounding.AwayFromZero)} minutes free time.");
                }
                else
                {
                    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Abs(Math.Round((times - esttime),MidpointRounding.AwayFromZero))} more minutes.");
                }
            }
            public static void FlowerShop()
            {
                double Magnolias = 3.25;
                double Hyacinths =4;
                double Roses = 3.50;
                double Cacti = 8;
                double nMagnolias = double.Parse(Console.ReadLine());
                double nHyacinths = double.Parse(Console.ReadLine());
                double nRoses = double.Parse(Console.ReadLine());
                double nCacti = double.Parse(Console.ReadLine());
                double giftprice = double .Parse(Console.ReadLine()); 
                double ttprice=Magnolias*nMagnolias+Hyacinths*nHyacinths+Roses*nRoses+Cacti*nCacti;
                double cleanprice = ttprice - (ttprice * 0.05);
                if (cleanprice >= giftprice)
                {
                    Console.WriteLine($"She is left with {Math.Truncate(cleanprice - giftprice)} leva.");

                }
                else
                {
                    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftprice - cleanprice)} leva.");
                }

            }
            public static void FuelTank()
            {
                string fuel=Console.ReadLine();
                double level=double.Parse(Console.ReadLine());

                if ((level >= 25) && (fuel.ToLower() == "gas" || fuel.ToLower() == "diesel" || fuel.ToLower() == "gasoline"))
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }

                else if (((level < 25) && (fuel.ToLower() == "gas" || fuel.ToLower() == "diesel" || fuel.ToLower() == "gasoline"))){

                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
                else {
                    Console.WriteLine($"Invalid fuel!");
                }
                
            }
            public static void FuelTankPartTwo()
            {
                double GasolinePrice = 2.22;
                double DieselPrice = 2.33;
                double GasPrice = 0.93;
                string FuelType=Console.ReadLine();
                double AmountOfFuel=Double.Parse(Console.ReadLine());
                string HaveDiscountCard = Console.ReadLine();
                double gasdiscount = 0.08;
                double dieseldiscount = 0.12;
                double gasolinediscount = 0.18;
                if (FuelType.ToLower() == "gas")
                {

                    if(HaveDiscountCard.ToLower() == "yes" && AmountOfFuel>=20&&AmountOfFuel<=25)
                    {
                        double total = (GasPrice*AmountOfFuel)-(AmountOfFuel*gasdiscount);
                         total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "yes" && AmountOfFuel > 25)
                    {
                        double total = (GasPrice * AmountOfFuel) - (AmountOfFuel * gasdiscount);
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if(HaveDiscountCard.ToLower() == "no" && AmountOfFuel >= 20 && AmountOfFuel <= 25)
                    {
                        double total = (GasPrice * AmountOfFuel);
                        total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "no" && AmountOfFuel > 25)
                    {
                        double total = (GasPrice * AmountOfFuel);
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }

                    else
                    {
                        double total = (GasPrice * AmountOfFuel) ;
                       
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }

                }
                else if (FuelType.ToLower() == "gasoline")
                {
                    if (HaveDiscountCard.ToLower() == "yes" && AmountOfFuel >= 20 && AmountOfFuel <= 25)
                    {
                        double total = (GasolinePrice * AmountOfFuel) - (AmountOfFuel * gasolinediscount);
                        total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "yes" && AmountOfFuel > 25)
                    {
                        double total = (GasolinePrice * AmountOfFuel) - (AmountOfFuel * gasolinediscount);
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "no" && AmountOfFuel >= 20 && AmountOfFuel <= 25)
                    {
                        double total = (GasolinePrice * AmountOfFuel);
                        total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "no" && AmountOfFuel > 25)
                    {
                        double total = (GasolinePrice * AmountOfFuel);
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else
                    {
                        double total = (GasolinePrice * AmountOfFuel);

                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                }
                else if (FuelType.ToLower() == "diesel")
                {
                    if (HaveDiscountCard.ToLower() == "yes" && AmountOfFuel >= 20 && AmountOfFuel <= 25)
                    {
                        double total = (DieselPrice * AmountOfFuel) - (AmountOfFuel * dieseldiscount);
                        total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "yes" && AmountOfFuel > 25)
                    {
                        double total = (DieselPrice * AmountOfFuel) - (AmountOfFuel * dieseldiscount);
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "no" && AmountOfFuel >= 20 && AmountOfFuel <= 25)
                    {
                        double total = (DieselPrice * AmountOfFuel) ;
                        total = total - (total * 0.08);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else if (HaveDiscountCard.ToLower() == "no" && AmountOfFuel > 25)
                    {
                        double total = (DieselPrice * AmountOfFuel) ;
                        total = total - (total * 0.10);
                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                    else
                    {
                        double total = (DieselPrice * AmountOfFuel) ;

                        Console.WriteLine($"{total.ToString("0.00")} lv.");
                    }
                }


                

                
            }
        }
    }
}
