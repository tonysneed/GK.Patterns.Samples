﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverReferences
{
    class Boss
    {
        public void OnWorkStarted()
        {
            Console.WriteLine("Boss: Work started");
        }

        public void OnWorkProgressed(int item)
        {
            Console.WriteLine("Boss: Working on {0}", item);
        }

        public void OnWorkCompleted()
        {
            Console.WriteLine("Boss: Work completed");
        }
    }
}
