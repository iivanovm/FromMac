using Lecture1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            MoreExercise.SortNum();

        }
    }
}

namespace Lecture1
{




    internal class MoreExercise
    {
        public static void PadawanEquipment()
        {
            double amountOfMoney=double.Parse(Console.ReadLine());  
            int countOfStudent=int.Parse(Console.ReadLine());
            double freebelts = 0;
            double lightsabersPrice=double.Parse(Console.ReadLine());   
            double robesPrice=double.Parse(Console.ReadLine()); 
            double beltsPrice=double.Parse(Console.ReadLine());
            double sum = 0;
            if (countOfStudent > 6)
            {
                freebelts=countOfStudent/6.00;
            }
            sum=lightsabersPrice*(Math.Ceiling(countOfStudent+countOfStudent*0.10))+robesPrice*countOfStudent+beltsPrice*(countOfStudent-freebelts);

            if(sum<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {sum-amountOfMoney:f2}lv more.");
            }
        }

        public static void SortNum()
        {
            string [] temp=new string[3] ;
            for (int i=0; i<3; i++)
            {
                temp[i] = Console.ReadLine();
            }
            Array.Sort(temp);
            Array.Reverse(temp);
            foreach(string s in temp)
            {
                Console.WriteLine(s);
            }
        }
    }
}