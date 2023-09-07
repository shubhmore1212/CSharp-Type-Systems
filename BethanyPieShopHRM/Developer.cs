
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
            double wageBeforeTax = wage * 12;
            double taxAmount = wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }

    //JuniorDeveloper cannot be derived from sealed type 'Developer'
    //public class JuniorDeveloper:Developer
    //{
    //}
}
