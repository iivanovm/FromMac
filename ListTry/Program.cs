using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ListTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab.ListManipulationAdvanced();
        }
    }

    public class Lab
    {
        public static void SumAdjacentEqualNumbers()
        {

            List<double> number = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < number.Count - 1; i++)
            {
                if (number[i] == number[i + 1])
                {
                    number[i] += number[i + 1];
                    number.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", number));
        }

        public static void GaussTrick()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int lenghtm = numbers.Count;
           for (int i = 0; i <lenghtm/2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        public static void MergingLists()
        {
            List<int> num1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int choice = 0;
            
                if (num1.Count >= num2.Count)
                {
                    choice = num1.Count;
                }
                else
                {
                    choice = num2.Count;
                }
                for (int i = 0; i<choice; i++)
                {

                    if (i < num1.Count)
                    {
                        result.Add(num1[i]);
                    }
                    if (i < num2.Count)
                    {
                        result.Add(num2[i]);
                    }
                    
                }
                Console.WriteLine(String.Join(" ", result));
        }

        public static void ListofProducts()
        {
            int numberOfProduct = int.Parse(Console.ReadLine());
            List<string> product = new List <string>();
            string input = String.Empty;
            for (int i = 0; i < numberOfProduct; i++)
            {
                input = Console.ReadLine();
                product.Add(input.ToString());
            }
            product.Sort();
            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine($"{i+1}.{product[i]}");
            }     
        }

        public static void RemoveNegativesandReverse()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newnumbers = new List<int>();
            for (int i = 0; i <numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newnumbers.Add(numbers[i]);
                }
            }
            if (newnumbers.Count!=0)
            {
                newnumbers.Reverse();
                Console.WriteLine(String.Join(" ", newnumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }

        public static void ListManipulationBasics()
        {
            List<int> printNum = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            string[] command = input.Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add": int a = int.Parse(command[1]);printNum.Add(a) ; break;
                    case "Remove": int b = int.Parse(command[1]); printNum.Remove(b); break;
                    case "RemoveAt": int c = int.Parse(command[1]); printNum.RemoveAt(c); break;
                        case "Insert": int d = int.Parse(command[1]); int e = int.Parse(command[2]); printNum.Insert(e,d); break;
                    default:;break;
                }
                input = Console.ReadLine();
                command = input.Split();
            }
            Console.WriteLine(String.Join(" ",printNum));
        }

        public static void ListManipulationAdvanced()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> modnumbers = new List<int>();
            string command = Console.ReadLine();
            string[] scommand = command.Split();
            string result = string.Empty;
            while (scommand[0] != "end")
            {
                modnumbers = numbers;
                result = string.Empty;
                switch (scommand[0])
                {
                   
                    case "Contains": int a = int.Parse(scommand[1]); Console.WriteLine(numbers.Contains(a) ? "Yes" : "No such number"); break;
                    case "PrintEven": foreach (int n in numbers) { if (n % 2 == 0) { } };Console.WriteLine(result); break;
                    case "PrintOdd": foreach (int n in numbers) { if (n % 2 != 0) { modnumbers.Add(n); } }; Console.WriteLine(string.Join(" ",modnumbers)); break;
                    case "GetSum": Console.WriteLine(numbers.Sum()); break;
                    case "Filter": string b = scommand[1].ToString(); int c = int.Parse(scommand[2]);
                        switch (scommand[1].ToString())
                        {
                            //'<', '>', ">=", "<="
                            case "<": foreach(int n in numbers) { if (n < int.Parse(scommand[2])) { Console.Write(string.Join(" ", n)); } }; break;
                            case ">": foreach (int n in numbers) { if (n > int.Parse(scommand[2])) { Console.Write(string.Join(" ", n)); } }; break;
                            case ">=": foreach (int n in numbers) { if (n >= int.Parse(scommand[2])) { Console.Write(string.Join(" ", n)); } }; break;
                            case "<=": foreach (int n in numbers) { if (n <= int.Parse(scommand[2])) { Console.Write(string.Join(" ", n)); } }; break;
                        };break;
                    default:;break;
                }
                command = Console.ReadLine();
                scommand = command.Split();
            }
        }
    }
}
