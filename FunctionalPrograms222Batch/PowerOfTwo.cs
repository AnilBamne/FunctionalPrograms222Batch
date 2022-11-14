using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    class PowerOfTwo
    {
        public void computePower()
        {
            Console.WriteLine("Enter the limit (less than 32) to compute the power");
            int N=Convert.ToInt32(Console.ReadLine());
            if (N > 0 && N < 32)
            {
                for (int i = 1; i <= N; i++)
                {
                    double result = Math.Pow(i, 2);
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Incorrect limit value");
            }
            
        }
    }
}
