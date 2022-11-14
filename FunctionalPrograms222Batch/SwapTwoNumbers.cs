using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class SwapTwoNumbers
    {
        public void SwapNums()
        {
            Console.WriteLine("Enter  first number ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int a = Num1 * Num2;
            int Num3 = a / Num2;
            int Num4 = a / Num1;

            Console.WriteLine("before swap  -->  Num1 = " + Num1 + "  num2 = " + Num2);
            Console.WriteLine("after swap  -->  Num1 = " + Num4 + "  num2 = " + Num3);
        }
    }
}
