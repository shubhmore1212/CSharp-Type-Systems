using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mgr = new Manager("Ken", 007, 1000.0);
            Employee rsh = new Researcher("Bob", 12, 1200.0);
            Employee dev = new Researcher("Amy", 1, 1300.0);

            mgr.DisplayEmployeeDetails();
            Console.WriteLine(mgr.ReceiveWage());
            mgr.GiveBonus();

            rsh.DisplayEmployeeDetails();
            Console.WriteLine(rsh.ReceiveWage());
            rsh.GiveBonus();

            dev.DisplayEmployeeDetails();
            Console.WriteLine(dev.ReceiveWage());
            dev.GiveBonus();

            List<Employee> empList = new List<Employee>();
            empList.Add(mgr);
            empList.Add(rsh);
            empList.Add(dev);

            empList.Sort();

            foreach(var emp in empList)
            {
                Console.WriteLine($"{emp.EmpId}  {emp.Name}");
            }
        }
    }
}