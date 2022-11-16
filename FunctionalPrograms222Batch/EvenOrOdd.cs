using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class EvenOrOdd
    {
        public  void checkEvenOdd()
        {
            //Tacking user input.
            Console.WriteLine("Enter  a number ");
            int Num = Convert.ToInt32(Console.ReadLine());
            //performimng modulas operation to get reminder
            if (Num % 2 == 0)
            {
                Console.WriteLine("the number is Even number");
            }
            else
            {
                Console.WriteLine("the number is Odd number");
            }
        }
    }
}
