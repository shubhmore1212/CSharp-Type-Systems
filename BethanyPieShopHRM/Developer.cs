
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public sealed class Developer : Employee
    {
        public Developer(string name, int empId, double wage) : base(name, empId, wage)
        {
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = Wage * 12;
            double taxAmount = Wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }

    //JuniorDeveloper cannot be derived from sealed type 'Developer'
    //public class JuniorDeveloper:Developer
    //{
    //}
}
