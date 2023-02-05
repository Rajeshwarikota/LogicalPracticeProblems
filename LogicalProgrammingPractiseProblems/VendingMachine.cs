using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
     class VendingMachine
    {
        public static void Notes()
        {
            Console.WriteLine("Enter the Amount");
            int amount = Convert.ToInt32(Console.ReadLine()); ;
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int notecount = 0;
            for (int i = 7; i >= 0; i--)
            {
                if (notes[i] <= amount)
                { 
                    amount = amount - notes[i];
                    Console.Write(notes[i] + ",");
                    i += 1;
                    notecount++;
                }
                if (amount == 0)
                {

                    break;
                }
            }
            Console.WriteLine("Total no of minimum notes returned by vending machine:{0} ",notecount);
        }
    }
}
