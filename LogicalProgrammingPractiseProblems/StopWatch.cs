using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    internal class StopWatch
    {
        public static void StopWatchSimulation()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
            stopwatch.Elapsed);

        }
    }
}
