using System;

namespace NastedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building();
        }

        public static void Combinations()
        {
            int input = int.Parse(Console.ReadLine());
            int cntCombo = 0;
            for (int x1 = 0; x1 <= input; x1++)
            {
                for (int x2 = 0; x2 <= input; x2++)
                {
                    for (int x3 = 0; x3 <= input; x3++)
                    {
                        if (x1 + x2 + x3 == input)
                        {
                            cntCombo++;
                        }
                    }
                }
            }
            Console.WriteLine(cntCombo);
        }

        public static void SumofTwoNumbers()
        {
            int intervalstart = int.Parse(Console.ReadLine());
            int intervalstop = int.Parse(Console.ReadLine());
            int magicnum = int.Parse(Console.ReadLine());
            int cntcombo = 0;
            for (int start = 0; start <= intervalstart; start++)
            {
               
                for (int stop = 0; stop <= intervalstop; stop++)
                {
                    Console.WriteLine($"==>{start}:{stop}\n");
                   
                    //if (start + stop == magicnum)
                    //{
                    //    break;
                    //}
                    
                }
                
            }
            
        }

        public static void Building()
        {
            int levennum=int.Parse(Console.ReadLine());
            int roomnum=int.Parse(Console.ReadLine());
            for (int level = levennum;level>0; level--)
            {
                for (int room=0;room < roomnum; room++)
                {
                    if (level % 2 == 0 && level != levennum)
                    {
                        Console.Write($"O{level}{room} ");
                    }
                   
                    else if (level % 2 != 0 && level!=levennum)
                    {
                        Console.Write($"A{level}{room} ");
                    }
                    if (level == levennum)
                    {
                        Console.Write($"L{level}{room} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
