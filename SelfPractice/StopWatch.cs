﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    public class StopWatch
    {
        public static void StopWatchIs()
        {
            Console.WriteLine("Press Enter to Start the StopWatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("Press Enter to stop a stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elapsed Time = " + (stop - start));
        }
    }
}
