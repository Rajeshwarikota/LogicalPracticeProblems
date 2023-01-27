using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class PerfectNumber
    {
        public static void perfectNo()
        {
            int number, sum = 0,n;
            Console.WriteLine("Enter the number to check Perfect Number or not");//6
            number = Convert.ToInt32(Console.ReadLine());
            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
               {
                Console.WriteLine("Entered number is a Perfect Number");
               }
            else  
            {
                Console.WriteLine("Entered number is not a Perfect Number");
            }
              
           
        }
    }
}
