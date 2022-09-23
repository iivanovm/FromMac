using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Net.Http.Headers;
using System.ComponentModel;

namespace Methods_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string m = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Lab.MathOperations(a,m,b)); 
        }
    }

                   
                
    internal class Lab
    {
        // IT's Methods - Lab  task
        public static void SignOfIntegerNumbers()
        {
            //Task 01
            int num = int.Parse(Console.ReadLine());    
            if(num== 0)
            {
                Console.WriteLine($"The number {num} is zero. ");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive. ");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative. ");
            }
        }

        public static string Grades(double input) 
        {
            string result=string.Empty;
            if (input >= 2 && input <=2.99) { result="Fail"; }
            else if (input >= 3.00 && input <= 3.49) { result = "Poor"; }
            else if (input >= 3.50 && input <= 4.49) { result = "Good"; }
            else if (input >= 4.50 && input <= 5.49) { result = "Very good"; }
            else if (input >= 5.50 && input <=6.00) { result = "Excellent"; }
            return result;
        }

        public static void Calculation()
        {
            string calcType=Console.ReadLine();
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            switch (calcType.ToLower())
            {
                case "add": Console.WriteLine(add(a,b));break;
                case "multiply": Console.WriteLine(multiply(a, b)); break;
                case "subtract": Console.WriteLine(subtract(a, b)); break;
                case "divide": Console.WriteLine(divide(a, b)); break;

            }

        }

        public static double add(int a , int b)
        {
            double result = a+b;
            return result;
        }
        public static double multiply(int a, int b)
        {
            double result = a * b;
            return result;
        }
        public static double subtract(int a, int b)
        {
            double result = a - b;
            return result;
        }
        public static double divide(int a, int b)
        {
            double result = a / b;
            return result;
        }

        public static void PrintingTriangle()
        {
            int num = int.Parse(Console.ReadLine());
           for(int i = 1; i <=num; i++)
            {
                PrintLine(1, i);
            }
           for (int i=num-1; i>=0; i--)
            {
                PrintLine(1,i);
            }
        }
        public static void PrintLine(int start,int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

       public static void Orders()
        {
            var productPrice = new Dictionary<string, double>
            {
                {"coffee", 1.50 },
                { "water", 1.00 },
                { "coke", 1.40 },
                { "snacks", 2.00 }
            };
            string chproduct = Console.ReadLine();
        int quantity=int.Parse(Console.ReadLine());
            Console.WriteLine($"{(productPrice.GetValueOrDefault(chproduct.ToLower(),1)*quantity):f2}");
        }

        public static int CalculateRectangleArea(int a,int b)
        {
            return a * b;
        }

        public static void RepeatString()
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            for(int i = 0; i < repeat; i++)
            {
                Console.Write(input);
            }
        }

        public static void MathPower()
        {
            double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(a,b));
        }

        public static void GreaterofTwoValues()
        {
            string dateType = Console.ReadLine();
            switch (dateType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string resultString = GetMax(firstString, secondString);
                    Console.WriteLine(resultString);

                    break;
            }
        }
        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        public static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }
        public static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);
            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static void  MultiplyEventbyOdds()
        {
            int input = int.Parse(Console.ReadLine());
            int ninp=input;
            int[] arr=new int[input.ToString().Length];
            for(int i = 0; i < input.ToString().Length; i++)
            {
                arr[i] = ninp%10;
                ninp/=10;
            }
            
           Console.WriteLine(GetSumOfEvenDigits(arr)*GetSumOfOddDigits(arr));
        }

        public static int GetSumOfEvenDigits(int [] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    sum += Math.Abs(n[i]);
                    
                }
            }
            return sum;
        }
        public static int GetSumOfOddDigits(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    sum += Math.Abs(n[i]);
                }
            }
            return sum;
        }

        public static double  MathOperations(double a, string m,double b)
        {
            double res = 0;
            switch (m)
            {
                case "*":res = a*b;break;
                case "/":res = a / b;break;
                case "+":res = a + b;break;
                case"-":res = a - b;break;
                
            }
           
            return res;
        }

    }
}
