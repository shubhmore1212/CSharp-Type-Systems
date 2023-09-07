using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperations();
            ParsingOperations();
        }

        static void StringOperations()
        {
            string myString = "Hello";

            Console.WriteLine(myString.Length);
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Contains("Hello"));
            Console.WriteLine(myString.Replace("e", "a"));
            Console.WriteLine(myString.Substring(2, 3));

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" world");
            sb.AppendLine("!");
            Console.WriteLine(sb.ToString());
        }

        static void ParsingOperations()
        {
            Console.WriteLine("Enter Wage"); ;
            string? wage = Console.ReadLine();

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Success: ", wageValue);
            else
                Console.WriteLine("Failure");

            string hireDateString = "12/12/2020";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine(hireDate);

            var cultureInfo = new CultureInfo("nl-BE");
            string birthDateString = "28 March 1984"; //Dutch, spoken in Belgium
            var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            Console.WriteLine(birthDate);
        }
    }
}