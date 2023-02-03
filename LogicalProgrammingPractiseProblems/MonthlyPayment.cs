using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class MonthlyPayment
    {
        public static void Monthlypay()
        {
            int principal, n, year;
            double payment, r, Rate;
            Console.WriteLine("Enter the parincipal Amount");
            principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the No of Yeras");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest");
            Rate = Convert.ToDouble(Console.ReadLine());
            n = 12 * year;
            r = Rate / (12 * 100);
            payment = (principal * r) / (1 -(Math.Pow((1 + r),(-n) )));
            Console.WriteLine("Monthly payment :" + payment);
        }
    }
}
