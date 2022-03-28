using System;

namespace Fibonacci_ededlerinin_cemini_tapmaq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daxil etdiyiniz edede qeder olan Fibonacci ededlerinin cemi: ");
            Console.WriteLine(GetSumOfFibonacci(a));   
        }

        public static int GetSumOfFibonacci(int a)
        {
            int sum = 0;
            int num1 = 0;
            int num2 = 1;
            int num3 = num1 + num2;

            while (num1 < a)
            {

                sum += num1;
                num1 = num2;
                num3 = num1 + num2;
            }

            return sum;
        }
    }
}
