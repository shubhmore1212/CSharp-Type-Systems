using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public interface IEmployee
    {
        string EmployerName { get; set; }
        double ReceiveWage();
        void GiveBonus();
        void DisplayEmployeeDetails();
    }
}
