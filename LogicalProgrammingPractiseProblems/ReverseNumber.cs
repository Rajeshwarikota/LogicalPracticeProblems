using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
     class ReverseNumber
    {
        public static void Reversing()
        {
            int Number, remainder, reverse = 0;
            Console.WriteLine("Enter a number ");
            Number = Convert.ToInt32(Console.ReadLine());
            while (Number > 0)
            {
                remainder = Number % 10;
                reverse = (reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine(" The Reverse Number is: " + reverse);
        }
    }
}
