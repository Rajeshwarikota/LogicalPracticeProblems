using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class NewtonSqrtMethod
    {
       
        public static void SqrtMethod()
        {
            int c;
            Console.WriteLine("Enter a Number");
            c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                double t = c;
                double epsilon = 1e-15;
                while (Math.Abs(t - (c / t)) > epsilon * t)
                {
                    t = ((c / t) + t) / 2;

                }
                Console.WriteLine("Square Root of {0} is {1}",c,t);
            }
            else 
            {
                Console.WriteLine("Enter positive integers");            
            }
        }
    }

}
