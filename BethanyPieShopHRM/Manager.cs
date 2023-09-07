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
            double wageBeforeTax = wage * 10;
            double taxAmount = wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }
}
