using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class PrimeFactorization
    {
        public void Factor()
        {
            //Taking user input
            Console.WriteLine("Enter the Number to find Prime Factors");
            int n=Convert.ToInt32(Console.ReadLine());
            //variable
            int factor=1;
            Console.WriteLine("Prime Factors are :");
            while (++factor<=n)
            {
                //computation
                if (n % factor == 0)
                {
                    Console.WriteLine(factor);
                    n=n/factor;
                }
            }
            
        }
    }
}
