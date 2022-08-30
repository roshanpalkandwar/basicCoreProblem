using System;

namespace basicCoreJavaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to basic java core program");
            Console.WriteLine("chooes option\n1. flip coin\n2.leap year or not\n3.power of two\n4.harmonic series\n5.the prime factor\n6.check even & odd number\n7.Quotient and Remainder\n8.swap number\n9.find greter value\n10.check alphabet is vowel or consonant");
            double opt = Convert.ToDouble(Console.ReadLine());



            switch (opt)
            {
                case 1:
                    flipCoin.calculatePercentage();
                    break;
                case 2:
                    leapYear.leapYear1();
                    break;
                case 3:
                    PowerOfTwo.tableOf2();
                    break;
                case 4:
                    HarmonicPoblem.harmonic();
                    break;
                case 5:

                    prime_factor p1 = new prime_factor();
                    p1.PrimeFactors();
                    break;
                case 6:
                    evenOddNumber.number();
                    break;
                    case 7:

                    QuotientAndRemainder.Calculate();
                    break;
                case 8:
                    swap.swapNumber();
                    break;
                case 9:
                    largestNumber.threeLagerNumber();
                    break;
                case 10:
                    checkalphabet.VowelOrConsonant();
                    break;
            }
        }
    }
}