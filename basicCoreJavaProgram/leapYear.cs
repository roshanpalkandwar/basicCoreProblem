using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreJavaProgram
{
    internal class leapYear
    {
        public static void leapYear1()
        {
            Console.WriteLine("enter the year");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 4 == 0)
            {
                Console.WriteLine("this is leap year");
            }
            else
            {
                Console.WriteLine("this is not leap year");
            }
    }   }

}
