using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class FibanocciSeries
    {
        public static void Fibanocci()
        { 
         int n1=0,n2=1,n3,i;
            Console.WriteLine("Enter the Number Of Elements");
            int number = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine(n1+" "+n2+" ");//printing 0 and 1
            for (i = 2; i < number; i++)//loopstart from 2 because already 0 and 1 are printed
            {
                n3 = n1 + n2;
                Console.WriteLine(n3+" ");
                n1 = n2;
                n2= n3;
            }
        }
    }
}
