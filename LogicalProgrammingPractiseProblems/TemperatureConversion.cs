using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class TemperatureConversion
    {
        public static void Conversions()
        {
            double celsius, fahrenheit;
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("\n1:Fahrenheit to Celsius\n2:Celsius to Fahrenheit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Temperature in Fahrenheit : ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * (5 / 9);
                    Console.WriteLine("{0} Fahrenheit in Celsius is {1}", fahrenheit, celsius);
                    break;
                case 2:
                    Console.WriteLine("Enter the Temperature in Celsius : ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (celsius * (9 / 5) + 32);
                    Console.WriteLine("{0} Celsius in Fahrenheit is {1}", celsius, fahrenheit);
                    break;
           
            }
        }
    }
}
