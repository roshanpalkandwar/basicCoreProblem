namespace basicCoreJavaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to basic java core program");
            Console.WriteLine("chooes option\n1. flip coin\n2.leap year or not");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    flipCoin.calculatePercentage();
                    break;
                    case 2:
                    leapYear.leapYear1();
                    break;
            }
        }
    }
}