﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class ComputeQuotientAndReminder
    {
        public void computeQR()
        {
            //variables
            int Quotiet;
            int Reminder;
            //Taking input from user
            Console.WriteLine("Enter the Devident");
            int divident=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Deviser");
            int deviser = int.Parse(Console.ReadLine());
            //computation
            Quotiet=divident / deviser;
            Reminder=divident % deviser;
            Console.WriteLine("Quotient = {0} and Reminder = {1}",Quotiet,Reminder);

        }
    }
}
