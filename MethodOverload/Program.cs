using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 7));
            Console.WriteLine(Add(0.50m, 0.50m));
            Console.WriteLine(Add(5, 7, true));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isDollar)
        {
            if(isDollar == true && (num1 + num2) >= 1)
            {
                return $"{num1 + num2} dollars";
            }
            else
            {
                return $"{num1 + num2}";
            }
        }
    }
}
