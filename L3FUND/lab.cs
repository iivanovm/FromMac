using System.Linq;
using System;

internal class lab
{
    public static void DayOfWeek()
    {
        int wday = int.Parse(Console.ReadLine());
        string[] weekday = { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        if (wday < 1 || wday > 7)
        {
            Console.WriteLine("Invalid Day!");
        }
        else
        {

            Console.WriteLine(weekday[wday]);
        }
    }

    public static void PrintReverNumberOrder()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numarr = new int[num];
        string newarr = string.Empty;
        for (int i = 0; i < num; i++)
        {
            numarr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = numarr.Length - 1; i >= 0; i--)
        {
            Console.Write(numarr[i] + " ");
        }
    }

    public static void RoundingNumber()
    {
        double[] notround = Console.ReadLine().Split().Select(double.Parse).ToArray();
        int[] rnum = new int[notround.Length];
        for (int i = 0; i < notround.Length; i++)
        {
            rnum[i] = (int)Math.Round(notround[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{notround[i]} => {rnum[i]}");
        }

    }

    public static void ReverseArrayofStrings()
    {
        var items = Console.ReadLine().Split(' ').ToArray();
        for (int i = 0; i < items.Length / 2; i++)
        {
            var oldElement = items[i];
            items[i] = items[items.Length - 1 - i];
            items[items.Length - 1 - i] = oldElement;
        }

        Console.WriteLine(string.Join(" ", items));
    }

    public static void SumEvenNum()
    {
        var inpt = Console.ReadLine();
        string[] nums = inpt.Split(' ');
        int sum = 0;
        int[] newnum = nums.Select(int.Parse).ToArray();
        for (int i = 0; i < newnum.Length; i++)
        {
            if (newnum[i] % 2 == 0)
            {
                sum += newnum[i];
            }
            else
            {
                // to do nothing
            }
        }
        Console.WriteLine(sum);

    }

    public static void EvenandOddSubtraction()
    {
        var items = Console.ReadLine();
        string[] newnum = items.Split(' ');
        int[] nm = newnum.Select(int.Parse).ToArray();
        int evensum = 0;
        int oddsum = 0;
        int rezult = 0;
        for (int i = 0; i < nm.Length; i++)
        {
            if (nm[i] % 2 == 0)
            {
                evensum += nm[i];
            }
            else
            {
                oddsum += nm[i];
            }
        }
        rezult = evensum - oddsum;
        Console.WriteLine(rezult);
    }

    public static void EqualArrays()
    {
        var arr1 = Console.ReadLine();
        var arr2 = Console.ReadLine();
        int sum = 0;
        bool isNotEqual = false;
        string[] narr1 = arr1.Split(' ');
        string[] narr2 = arr2.Split(' ');
        int[] arr1n = narr1.Select(int.Parse).ToArray();
        int[] arr2n = narr2.Select(int.Parse).ToArray();
        string index = string.Empty;
        for (int i = 0; i < arr1n.Length; i++)
        {
            if (arr1n[i] == arr2n[i])
            {
                sum += arr1n[i];
            }
            else
            {
                sum = 0;
                index += i.ToString();
                isNotEqual = true;
                break;
            }
        }
        if (isNotEqual)
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        }
        else
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }

    public static void CondenseArrayToNumber()
    {
        //int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //int finalResult = 0;
        //int firstLength = originalArray.Length - 1;
        //for (int i = 0; i < firstLength; i++)
        //{
        //    int[] modifiedArray = new int[originalArray.Length - 1];
        //    for (int j = 0; j < modifiedArray.Length; j++)
        //        modifiedArray[j] = originalArray[j] + originalArray[j + 1];
        //    originalArray = modifiedArray;
        //    finalResult = modifiedArray[0];
        //}
        //Console.WriteLine(finalResult);

        var inputArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var count = inputArr.Length;
        while (count > 1)
        {
            for (int i = 0; i < count - 1; i++)
            {
                inputArr[i] = inputArr[i] + inputArr[i + 1];
                Console.Write("{0}{1}", inputArr[i], i == count - 2 ? string.Empty : " ");
            }

            Console.WriteLine();
            count--;
        }
    }
}