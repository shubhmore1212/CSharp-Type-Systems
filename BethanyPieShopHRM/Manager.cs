using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Manager : Employee
    {
        public Manager(string name, int empId, double wage) : base(name, empId, wage)
        {
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = Wage * 10;
            double taxAmount = Wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }
}
