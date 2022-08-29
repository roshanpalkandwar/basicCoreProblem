using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreJavaProgram
{
    internal class flipCoin
    {
        public static void calculatePercentage()
        {
            int headCount=0,tailCount=0;
            double headPercentage;
            double tailPercentage;

            Console.WriteLine("please enter the value of flip");
            int flipcoin=Convert.ToInt32(Console.ReadLine());

            if(flipcoin>0)
            {
                for(int i=0;i<flipcoin;i++)
                {
                    Random random = new Random();
                    double number=random.NextDouble();
                    if(number>0.5)
                    {
                        Console.WriteLine("head");
                        headCount++;
                    }
                    else
                    {
                        Console.WriteLine("tail");
                        tailCount++;
                    }

                }
                headPercentage=headCount*100/flipcoin;
                tailPercentage=tailCount*100/flipcoin;
                Console.WriteLine("head percentage  " + headPercentage + "  " + "tail parcentage  " + tailPercentage);
            }
            else
            {
                Console.WriteLine("enter the positive number");
            }
        }
    }
}
