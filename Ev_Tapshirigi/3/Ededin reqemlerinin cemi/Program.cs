using System;

namespace Ededin_reqemlerinin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin; ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ededin reqemlerinin cemi; ");
            Console.WriteLine(GetSumOfNumbers(a));
        }

        public static int GetSumOfNumbers(int a)
        {
            int sum = 0;

            while (a > 0)
            {
                sum += (a % 10);
                a = a / 10;
            }

            return sum;
        }
    }
}
