using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class PrimeNumber
    {
        public static void PrimeOrNot()
        {
            int number;
            Console.WriteLine("Enter a number to check Prime or Not");
            number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;                
                }
            }
            if (count == 2)
            {
                Console.WriteLine("The Entered number is prime number");
            }
            else 
            {
                Console.WriteLine("The Entered number is not a prime number");
            }
        }
    }
}
