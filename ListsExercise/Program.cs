using System;
using System.Collections.Generic;
using System.Linq;
namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Exer
    {
        public static void Train()
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPass = int.Parse(Console.ReadLine());
            string commnad;
            while ((commnad = Console.ReadLine()) != "end")
            {
                string[] ninp = commnad.Split();
                if (ninp[0] == "Add")
                {
                    wagon.Add(int.Parse(ninp[1]));
                }
                else
                {
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + int.Parse(ninp[0]) <= maxPass)
                        {
                            wagon[i] += int.Parse(ninp[0]);
                            break;
                        }
                    }
                }
            }
        }
    }
}

