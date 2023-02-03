using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class NewtonSqrtMethod
    {
        //public static double Sqrt(double a, int times)
        //{
        //    if (a < 0)
        //        throw new Exception("Can not sqrt a negative number");
        //    double x = 1;
        //    while (times-- > 0)
        //        x = x / 2 + a / (2 * x);
        //    Console.WriteLine(x);
        //    return x;
        //}
        public static void SqrtMethod()
        {
            double c, epsilon = 1e-15;
            Console.WriteLine("Enter a Number");
            c = Convert.ToDouble(Console.ReadLine());
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t / 2.0 );
               
            }
            Console.WriteLine(t);

        }
    }

}
