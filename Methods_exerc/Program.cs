using System;
using System.Linq;
using System.Xml.Linq;

namespace Methods_exerc
{
    internal class Program
    {
        static void Main()
        {
            PasswordValidator();
        }

        static void VowelsCount()
        {
            string name = Console.ReadLine();
            string[] nstr=name.Split();
            int count=0;
        foreach (char s in name.ToLower())
            {
                if (s== 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void CharacterInRang()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int start = Math.Min((int)a,(int)b);
            int end = Math.Max((int)b,(int)a);
            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i+" ");
            }
        }

        static void PasswordValidator()
        {
            string pass=Console.ReadLine();
            if (PassChekLeng(pass) && PassCheckConsist(pass) && PassCheckTwoDigit(pass))
            {
                Console.WriteLine("Password is valid");
            }
            if (!PassChekLeng(pass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!PassCheckConsist(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!PassCheckTwoDigit(pass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool PassChekLeng(string pass)
        {
            bool IsValid = false;
            if (pass.Length >=6 && pass.Length <= 10)
            {
               IsValid = true;
            }
            else
            {
                IsValid = false;
            }
            return IsValid;
        }
        static bool PassCheckConsist(string pass)
        {
            bool IsValid = false;
            foreach (char c in pass)
            {
                if(((int)c>=48&&(int)c<=57) || ((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122))
                {
                    IsValid=true;
                }
                else
                {
                    IsValid=false;
                    break;
                }
            }
            return IsValid;
        }
        static bool PassCheckTwoDigit(string pass)
        {
            bool IsValid = false;
            foreach (char c in pass)
            {
                if ((int)c >= 48 && (int)c <= 57)
                {
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                }
            }
          return IsValid;
        }
    }
}
