using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class LargestOfThreeNumbers
    {
        public void findLargest()
        {
            Console.WriteLine("Enter  first number ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third number ");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("First number : " + Num1 + " is largest");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("Second number : " + Num2 + " is largest");
            }
            else if (Num3 > Num1 && Num3 > Num2)
            {
                Console.WriteLine("Third number : " + Num3 + " is largest");
            }



        }
    }
}
