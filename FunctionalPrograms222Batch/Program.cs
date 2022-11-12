using System;

namespace FunctionalPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Functional Programs");

            while (true)
            {

                Console.WriteLine("Select the Program to execute\n1:Flip Coin \n2:Leap year\n3:Power of Two\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin.FlipTheCoin();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("**************************");
            }
            
        }
    }
}
