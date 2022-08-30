using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreJavaProgram
{
    internal class PowerOfTwo
    {
        public static void tableOf2()
        {
            int i, n;
            Console.WriteLine("enter the number ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)

            {


                Console.WriteLine("{0}*{1}={2} ", n, i, n * i);
            }
        }
    }
}
