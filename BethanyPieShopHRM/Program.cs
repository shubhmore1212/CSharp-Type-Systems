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

            mgr.DisplayEmployeeDetails();
            Console.WriteLine(mgr.ReceiveWage());
            mgr.GiveBonus();

            rsh.DisplayEmployeeDetails();
            Console.WriteLine(rsh.ReceiveWage());
            rsh.GiveBonus();
        }
    }
}