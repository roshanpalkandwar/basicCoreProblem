using System;

namespace basicCoreJavaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to basic java core program");
            Console.WriteLine("chooes option\n1. flip coin\n2.leap year or not\n3.power of two\n4.harmonic series\n5.the prime factor");
            double opt=Convert.ToDouble(Console.ReadLine());

           

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
            }
        }
    }
}