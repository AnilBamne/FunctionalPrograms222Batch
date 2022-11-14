using System;

namespace FunctionalPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Functional Programs");
            Console.WriteLine("Select the Program to execute\n\n1:Flip Coin \n2:Leap year\n3:Power of Two\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip=new FlipCoin();
                    flip.FlipTheCoin();
                    break;
                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.checkLeapYear();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.computePower();
                    break;
                default:
                    break;
            }
            Console.WriteLine("**************************");


        }
    }
}
