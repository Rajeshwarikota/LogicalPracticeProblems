using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems");
            Console.WriteLine("\n1:FibanocciSeries\n2:PrimeNumber\n3:PerfectNumber\n4:ReverseNumber\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibanocciSeries.Fibanocci();
                    break;
                case 2:
                    PrimeNumber.PrimeOrNot();
                    break;
                case 3:
                    PerfectNumber.perfectNo();
                    break;
                case 4:
                    ReverseNumber.Reversing();
                    break;
                default:
                    Console.WriteLine("Enter the Above Option");
                    break;
            }
                    Console.ReadLine();
        }
    }
}
