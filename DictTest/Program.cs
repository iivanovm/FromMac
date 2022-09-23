using System;

namespace DictTest
{
    using System;
    using System.Collections.Generic;
    public static class Program
    {
        public static void Main(string[] args)
        {
            string se= Console.ReadLine();
            string ddd = "a";
            int a = 3;
            int b = 4;
            var d = new Dictionary<string, int> {
        {"a", a*b},
        {"roses", 2},
        {"z", 3},
        {"c", 4}
    };
            Console.WriteLine(d[se]);
            Console.WriteLine(d.Values.Count);
        }
    }
}
