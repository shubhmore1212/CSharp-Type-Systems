using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            //C# is by default pass by value
            //For pass by reference use ref or out
            //If using ref, then it is mandatory to initialize first
            //For out me can return multiple values
            Console.WriteLine($"Before Pass By Value Method {num1}");
            CheckForPassByValue(num1);
            Console.WriteLine($"After Pass By Value Method {num1}");

            Console.WriteLine($"Before Pass By Reference Method {num1}");
            CheckForPassByReference(ref num1);
            Console.WriteLine($"After Pass By Reference Method {num1}");

            //Using params Keyword
            //represents array to capture multiple parameters, available through array in method body
            //if before hand we don't know how many arguments are sent
            //params should be last
            int average = CalculateAverage(10, 20, 30, 40);
            Console.WriteLine(average);

            //Optional Parameter
            Console.WriteLine(CheckForOptionalParameters(10,20));//10+20+10=40
            Console.WriteLine(CheckForOptionalParameters(10,20,30));//10+20+30=60

            //Named Arguments
            //No need to follow order
            CheckForNamedParameters(num: 10, name: "Hello");

            Console.WriteLine(CalculateSum(10,20));
        }

        //Expresssion body syntax
        public static int CalculateSum(int num1, int num2) => num1 + num2;

        static void CheckForNamedParameters(string name,int num)
        {
            Console.WriteLine($"{name} and {num}");
        }

        private static int CalculateAverage(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }

            return sum / arr.Length;
        }

        static int CheckForOptionalParameters(int num1, int num2, int num3 = 10)
        {
            return num1 + num2 + num3;
        }

        static void CheckForPassByValue(int num)
        {
            num *= 10;
        }

        static void CheckForPassByReference(ref int num)
        {
            num *= 10;
        }

    }
}