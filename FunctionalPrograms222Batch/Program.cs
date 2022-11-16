using System;

namespace FunctionalPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //main branch welcome message
            Console.WriteLine("Welcome To Functional Programs");
            //select the class to execute(user input)
            Console.WriteLine("Select the Program to execute\n\n1:Flip Coin \n2:Leap year\n3:Power of Two\n4:Harmonic Number\n5:Prime Factorization\n6:Quotient and Reminder\n7:Swap Two Numbers\n8:Even Or Odd\n9:Vovel Or Consonent\n10:Largest Among Three Numbers");
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
                    EvenOrOdd obj = new EvenOrOdd();
                    obj.checkEvenOdd();
                    break;
                case 9:
                    VovelOrConsonent vc = new VovelOrConsonent();
                    vc.checkVowel();
                    break;
                case 10:
                    LargestOfThreeNumbers largestOfThreeNumbers = new LargestOfThreeNumbers();
                    largestOfThreeNumbers.findLargest();
                    break;
                default:
                    break;
            }
            Console.WriteLine("**************************");


        }
    }
}
