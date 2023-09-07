using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Researcher : Employee
    {
        public Researcher(string name, int empId, double wage) : base(name, empId, wage)
        {
        }

        public override void GiveBonus()
        {
            wage += 100;
            Console.WriteLine($"Researcher Gets Bonus : {wage}");
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = wage * 18;
            double taxAmount = wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }
}
