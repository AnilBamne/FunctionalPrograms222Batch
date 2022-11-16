using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class HarmonicNumber
    {
        public void harmonicNum()
        {
            //Taking user input
            Console.WriteLine("Enter the value");
            int N = Convert.ToInt32(Console.ReadLine());
            //variable initialization
            float harmonic = 1;
            //computing harmonic number
            if(N > 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    harmonic = harmonic + (float)1 / i;
                }
                Console.WriteLine("The Nth harmonic Number is \n" + harmonic);
            }
            else
            {
                Console.WriteLine("Invallid Number");
            }
        } 
    }
}
