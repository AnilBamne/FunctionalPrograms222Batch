using System;

namespace FunctionalPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Functional Programs");
            Console.WriteLine("Select the Program to execute\n\n1:Flip Coin \n2:Leap year\n3:Power of Two\n4:Harmonic Number\n5:Prime Factorization\n6:Quotient and Reminder\n7:Swap Two Numbers");
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
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.harmonicNum();
                    break;
                case 5:
                    PrimeFactorization primeFactorization = new PrimeFactorization();
                    primeFactorization.Factor();
                    break;
                case 6:
                    ComputeQuotientAndReminder computeQuotientAndReminder = new ComputeQuotientAndReminder();
                    computeQuotientAndReminder.computeQR();
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.SwapNums();
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
            Console.WriteLine("**************************");


        }
    }
}
