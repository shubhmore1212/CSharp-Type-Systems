using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    enum EmployeeType
    {
        Manager,
        Research,
        HR
    }
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfhoursWorked;
        private double wage;
        private double?  hourlyRate;

        private EmployeeType employeeType;
        public static double taxRate = 0.15;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public Employee(string firstName, string lastName, string email, int numberOfhoursWorked, double wage, double? hourlyRate, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
            this.numberOfhoursWorked = numberOfhoursWorked;
            this.wage = wage;
            this.hourlyRate = hourlyRate ?? 10;
            this.employeeType = employeeType;
            FirstName = firstName;
            LastName = lastName;
        }

        public double RecieveWage()
        {
            double wageBeforeTax = numberOfhoursWorked * hourlyRate.Value;
            double taxAmount=wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;
            
            return wage;
        }
    }
}
