using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SName=Console.ReadLine();
            int ClassCnt = 1;
            int ClassEx = 0;
            double GradeSum=0;
            while(ClassCnt<13)
            {
                double grade=double.Parse(Console.ReadLine());
                GradeSum += grade;
                if (grade < 4)
                {
                    ClassEx++;
                    if (ClassEx >= 2)
                    {
                        Console.WriteLine($"{SName} has been excluded at {ClassCnt} grade");
                        Environment.Exit(0);
                    }
                }
              
                else
                {
                    ClassCnt++;
                }
               

            }
            Console.WriteLine($"{SName} graduated. Average grade: {(GradeSum / 12):0.00} ");
    
        }
    }
}
