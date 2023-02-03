using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class BinaryConversion
    {
        public static void BinaryNo()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int quotient;
            string remainder = "";
            while (num >= 1)
            {
                quotient = num / 2;
                remainder += (num % 2).ToString();
                num = quotient;
            }
            String binary = "";
            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                binary = binary + remainder[i];
            }
            Console.WriteLine("The binary format for given number is {0}" ,binary);
        }
    }
}
