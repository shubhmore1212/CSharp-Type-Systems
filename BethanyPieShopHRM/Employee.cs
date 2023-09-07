using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public double wage { get; set; }

        public static double taxRate = 0.15;

        public Employee(string name, int empId, double wage)
        {
            Name = name;
            EmpId = empId;
            this.wage = wage;
        }

        public abstract double ReceiveWage();

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name : {Name}\nEmp ID : {EmpId}\nwage :{wage}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"No Bonus : {wage}");
        }
    }
}
