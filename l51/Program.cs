using System;
using System.Collections;

namespace l51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OddEvenPosition();
            //double num;

            //do
            //{
            //    num = double.Parse(Console.ReadLine());
            //    if (num < 0) { break; };
            //    Console.WriteLine($"Result: {num * 2:0.00}");
            //}
            //while (num > 0);
            //Console.WriteLine("Negative number!");

        }

        public static void PF()
        {
            double money = double.Parse(Console.ReadLine());
            double yeartolive = double.Parse(Console.ReadLine());
            double currenty = 1800.00;
            double yearold = 18.00;
            double PaySum = 0.00;
            for (currenty = 1800; currenty <= yeartolive; currenty++, yearold++)
            {
                if (currenty % 2 == 0)
                {
                    PaySum += 12000;
                }
                else if (currenty % 2 != 0)
                {
                    PaySum += 12000 + 50 * yearold;
                }
            }

            Console.WriteLine(PaySum <= money ? $"Yes! He will live a carefree life and will have {(money - PaySum):0.00} dollars left." : $"He will need {(PaySum - money):0.00} dollars to survive.");
        }

        public static void Hospital()
        {
            double Day = double.Parse(Console.ReadLine());
            double Doctors = 7;
            double Pacient;
    
            double Treated = 0.00;
            double UnTreated = 0.00;
           
            for (int i = 1; i <=Day; i++)
            {
                Pacient=double.Parse(Console.ReadLine());
                if ((i % 3 == 0) && (UnTreated > Treated))
                {
                    Doctors++;
                }
                if (Pacient > Doctors)
                {
                    Treated += Doctors;
                    UnTreated += Pacient - Doctors;
                }
                else
                {
                    Treated += Pacient;
                }
            }
            Console.WriteLine($"Treated patients: {Treated}.\nUntreated patients: {UnTreated}.");
          
        }
        public static void Logistic()
        {
            double NumOfNT=double.Parse(Console.ReadLine());
            double bus = 0;
            double truck = 0;
            double train = 0;
            double Tons = 0.00;
            double SumTns = 0.00;
            double TotalSum=0.0;
            for (int i = 1; i <=NumOfNT; i++)
            {
               Tons = double.Parse(Console.ReadLine());
                SumTns+=Tons;
                if (Tons <= 3)
                {
                    bus += Tons;
                    TotalSum += Tons * 200;
                }
                else if (Tons >=4 && Tons <= 11)
                {
                    truck+=Tons;
                    TotalSum += Tons * 175;
                }
                else
                {   train+=Tons;
                    TotalSum += Tons * 120;
                }
            }
            Console.WriteLine($"{TotalSum / SumTns:0.00}");
            Console.WriteLine($"{(bus / SumTns*100):0.00}%");
            Console.WriteLine($"{(truck / SumTns*100):0.00}%");
            Console.WriteLine($"{(train / SumTns*100):0.00}%");
        }

        public static void Grades()
        {
            double Student=double.Parse(Console.ReadLine());
            double Avg = 0.00;
            int r1 = 0;
            int r2= 0;
            int r3= 0;
            int r4= 0;
            double StdRslt;
            for(int i=0; i<Student; i++)
            {
                StdRslt=double.Parse(Console.ReadLine());
                Avg += StdRslt;
                if(StdRslt >=2.00 && StdRslt <=2.99)
                {
                    r1++;
                }
                else if (StdRslt >=3&&StdRslt <= 3.99)
                {
                    r2++;
                }
                else if (StdRslt >=4&&StdRslt <= 4.99)
                {
                    r3++;
                }
                else if (StdRslt >= 5)
                {
                    r4++;
                }
            }
            Console.WriteLine($"Top students: {(r4 / Student * 100):0.00}%\nBetween 4.00 and 4.99: {(r3 / Student * 100):0.00}%\nBetween 3.00 and 3.99: {(r2/Student*100):0.00}%\nFail: {(r1/Student*100):0.00}%\nAverage: {(Avg/Student):0.00}");
        }

        public static void GameOfIntervals()
        {
            double num=double.Parse(Console.ReadLine());
            double Score = 0;
            double input = 0.00;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int r6 = 0;
            for (int i = 0; i < num; i++)
            {
                input=double.Parse(Console.ReadLine());
                
                if (input >= 0 && input <= 9)
                {
                    Score += input * 0.2;
                    r1++;
                }
                else if (input>=10 && input <= 19)
                {
                    Score += input * 0.3;
                    r2++;
                }
                else if (input >= 20 && input <= 29)
                {
                    Score += input * 0.4;
                    r3++;
                }
                else if (input >= 30 && input <= 39)
                {
                    Score += 50;
                    r4++;
                }
                else if (input >=40&&input<=50)
                {
                    Score += 100;
                    r5++;
                }
                else if (input < 0 || input > 50)
                {
                    Score = Score / 2;
                    r6++;
                }
               
            }
            Console.WriteLine($"{Score:0.00}\nFrom 0 to 9: {(r1 / num * 100):0.00}%\nFrom 10 to 19: {(r2 / num * 100):0.00}%\nFrom 20 to 29: {(r3 / num * 100):0.00}%\nFrom 30 to 39: {(r4 / num * 100):0.00}%\nFrom 40 to 50: {(r5 / num * 100):0.00}%\nInvalid numbers: {(r6 / num * 100):0.00}%");
        }
        public static void Bills()
        {
            double Months=double.Parse(Console.ReadLine());
            double Water = 20.00;
            double Inet = 15.00;
            double Other = 0.00;
            double Electricity = 0.00;
            double Esum = 0.00;
            double TotalPay = 0.00;
            for (int i = 0; i < Months; i++)
            {
                Electricity=double.Parse(Console.ReadLine());
                Esum+=Electricity;
                Other += (Water + Inet + Electricity)+((Water + Inet + Electricity)*0.20);

                TotalPay += (Electricity + Other+Water+Inet);
            }
            //TotalPay+=(Months*Water)+(Months*Inet);
            Console.WriteLine($"Electricity: {Esum:0.00} lv\nWater: {(Water*Months):0.00} lv\nInternet: {(Inet*Months):0.00} lv\nOther: {Other:0.00} lv\nAverage: {((Esum+(Water*Months)+(Inet*Months)+Other)/Months):0.00} lv");    
        }

        public static void FootballLeague()
        {
            double StadionCapacity=double.Parse(Console.ReadLine());    
            double FansNumber=double.Parse(Console.ReadLine());
            int GrpA = 0;
            int GrpB = 0;
            int GrpV = 0;
            int GrpG = 0;
            for(int i = 0; i < FansNumber; i++)
            {
                string FansTeam=Console.ReadLine();
                if (FansTeam.ToLower() == "a" )
                {
                    GrpA++;
                }
                else if (FansTeam.ToLower() == "b")
                {
                    GrpB++;
                }
                else if (FansTeam.ToLower() == "v")
                {
                    GrpV++;
                }
                else if (FansTeam.ToLower() == "g")
                {
                    GrpG++;
                }
            }
            Console.WriteLine($"{(GrpA / FansNumber * 100):0.00}%\n{(GrpB / FansNumber * 100):0.00}%\n{(GrpV / FansNumber * 100):0.00}%\n{(GrpG/FansNumber*100):0.00}%\n{(FansNumber/StadionCapacity*100):0.00}%");
        }

        public static void EqualPairs()
        {
            int n=2*int.Parse(Console.ReadLine());
            double [] arr=new double[n];
            double [] arr1 = new double[arr.Length];
            double num;
            double Max=0;
            double Min=0;
            double ef=0;
            bool IfEqual;
            for (int i=0; i< n; i++)
            {
                num=double.Parse(Console.ReadLine());
                arr[i] = num;
            }
            for (int i=0; i+1< arr.Length; i+=2)
            {
                IfEqual = arr1[i]==arr[i] + arr[i + 1];
                arr1[i]= arr[i]+arr[i+1];

                if (IfEqual)
                {
                    ef = arr1[i]; 
                }
                else if (arr[i] > Max)
                {
                    Max= arr[i];
                }
                else if (arr[i] < Min)
                {
                    Min= arr[i];
                }
            }
            Console.WriteLine($"min;{Min}--Max:{Max}---ef:{ef}");
        }
        public static void clock()
        {
            for (int i=0; i<24; i++)
            {
                for (int j=0; j<60; j++)
                {
                    for(int k=0; k<60; k++)
                    {
                        Console.WriteLine($"{i} : {j} : {k}");
                    }
                   
                }
            }
        }
        public static void OddEvenPosition()
        {
            double oddsum = 0;
            double evensum = 0;
            double oddmin = 0;
            double oddmax = 0;
            double evenmin = 0;
            double evenmax = 0;
            double n = double.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                double num=double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    evensum += num;
                    if (num > evenmax)
                    {
                        evenmax = num;
                    }
                    
                     if (num < evenmin)
                    {
                        evenmin = num;
                    }
                   
                }
                else if (num % 2 != 0)
                {
                    oddsum += num;
                    if (num > oddmax)
                    {
                        oddmax = num;
                    }
                   
                    if (num < oddmin)
                    {
                        oddmin = num;
                    }
                    
                }
            }
            Console.WriteLine($"OddSum= {oddsum:0.00},");
            Console.WriteLine(oddmin == 0||oddmin==50 ? "OddMin= No," : $"OddMin= {oddmin:0.00},");
            Console.WriteLine(oddmax == 0 ? "OddMin= No," : $"OddMin= {oddmax:0.00},");
            Console.WriteLine($"EvenSum= {evensum:0.00},");
            Console.WriteLine(evenmin == 0||evenmin==50 ? $"EvenMin= No," : $"EvenMin= {evenmin:0.00},");
            Console.WriteLine(evenmax == 0 ? $"EvenMax= No" : $"EvenMax= {evenmax:0.00}");
        }
    }
}      
