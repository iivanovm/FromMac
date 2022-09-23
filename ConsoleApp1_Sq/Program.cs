using System;
using System.Collections.Generic;
nDraw.draw();
/*
class Program
{
    static void Main(string[] args)
    {
        //create list
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Toyota", 1250000));
        cars.Add(new Car("Tata", 1300000));
        cars.Add(new Car("Honda", 1150000));

        //for each element in the list
        cars.ForEach(delegate (Car car) {
            Console.WriteLine(car.name + " - " + car.price);
        });
    }
}

class Car
{
    public string name;
    public int price;
    public Car(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}
*/

class StringConcatenationInLoop
{
    public static void Main(string[] args)
    {
        
        String n2 = Console.ReadLine();
        String numberList="";
        for (int i = 0; i < n2.Length; i++)
        {
            
            Console.WriteLine(n2[i]);
        }
        Console.WriteLine(numberList);
    }
}

class nDraw
{
    public static void draw()
    {
        int a = 90;
        int b = 30;
        string name=Console.ReadLine();


        Console.WriteLine();
        for(int j = 0; j < b/2; j++)
        {
            Console.Write("*");
            for (int d = 0; d < a-2; d++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
        }
        for (int j = 0; j < name.Length; j++)
        {
            Console.Write(name[j]);
            for (int d = 0; d < a - 2; k++)
            {
                Console.Write(" ");
            }
            Console.Write(name[j]);
            Console.WriteLine();
        }
        for (int j = 0; j <b- name.Length; j++)
        {
            Console.Write("*");
            for (int d = 0; d < a - 2; d++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
        }

    }
}