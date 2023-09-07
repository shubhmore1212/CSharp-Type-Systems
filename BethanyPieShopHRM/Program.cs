using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingEnumeration();
            UsingStruct();
            Console.WriteLine();
        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Harish";
            employee.Wage = 1250;
            employee.Work();
        }

        private static void UsingEnumeration()
        {
            EmployeeType manager = EmployeeType.Manager;
            EmployeeType research = EmployeeType.Research;
            CalculateWage(1000, manager);
            CalculateWage(1000, research);
        }

        private static void CalculateWage(int baseWage,EmployeeType empType)
        {
            int calculateWage;

            if (empType == EmployeeType.Manager)
            {
                calculateWage = baseWage*3;
            }
            else
            {
                calculateWage = baseWage*2;
            }

            Console.WriteLine(calculateWage);
        }
    }

    enum EmployeeType
    {
        Sales,          //0
        Manager,        //1
        Research,       //2
        StoreManager=99 //99
    }

    //Struct represent a custom data-structure,value type,can contain methods and other members
    //can say light weight classes
    struct Employee
    {
        public string Name;
        public int Wage;

        public void Work()
        {
            Console.WriteLine($"{Name} is now doing work.");
        }
    }

} 