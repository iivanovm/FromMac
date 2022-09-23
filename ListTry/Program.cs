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
            Lab.ListManipulationBasics();
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
            string command ;
            while ((command= Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "Add": int a = int.Parse(Console.ReadLine());printNum.Add(a);break;
                    case "Remove": int b = int.Parse(Console.ReadLine()); printNum.Remove(b); break;
                    case "RemoveAt": int c = int.Parse(Console.ReadLine()); printNum.RemoveAt(c); break;
                    case "Insert": int d = int.Parse(Console.ReadLine()); int e = int.Parse(Console.ReadLine()); printNum.Insert(d,e); break;
                    default:;break;
                }
            }
            Console.WriteLine(String.Join(" ",printNum));
        }
    }
}
