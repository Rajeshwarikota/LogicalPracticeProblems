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
            Console.WriteLine("\n1:Fibanocci\n2:Prime\n3:Perfect\n4:Reverse\n5:StopWatch\n6:Tempconversion\n7:NewtonSqrt\n8:Binary\n11:Exit");
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
                case 5:
                    StopWatch.StopWatchSimulation();
                    break;
                case 6:
                    TemperatureConversion.Conversions();
                    break;
                case 7:
                    NewtonSqrtMethod.SqrtMethod();
                    break;
                case 8:
                    BinaryConversion.BinaryNo();
                    break;

                default:
                    Console.WriteLine("Enter the Above Option");
                    break;
            }
                    Console.ReadLine();
        }
    }
}
