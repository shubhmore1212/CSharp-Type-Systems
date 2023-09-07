using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Employee : IEmployee, IComparable<Employee>
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public double Wage { get; set; }
        public string? EmployerName { get; set; }

        public static double taxRate = 0.15;

        public Employee(string name, int empId, double wage, string employerName)
        {
            Name = name;
            EmpId = empId;
            this.Wage = wage;
            EmployerName = employerName;
        }

        public Employee(string name, int empId, double wage)
        {
            Name = name;
            EmpId = empId;
            this.Wage = wage;
        }

        public virtual double ReceiveWage()
        {
            return Wage;
        }

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name : {Name}\nEmp ID : {EmpId}\nwage :{Wage}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"No Bonus : {Wage}");
        }

        public int CompareTo(Employee? otherEmployee)
        {
            if(otherEmployee == null) return 0;

            if(EmpId > otherEmployee.EmpId)
            {
                return 1;
            }else if (EmpId < otherEmployee.EmpId)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
