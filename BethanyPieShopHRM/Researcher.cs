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
            Wage += 100;
            Console.WriteLine($"Researcher Gets Bonus : {Wage}");
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = Wage * 18;
            double taxAmount = Wage * taxRate;

            return wageBeforeTax - taxAmount;
        }
    }
}
