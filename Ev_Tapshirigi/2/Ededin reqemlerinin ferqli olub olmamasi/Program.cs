using System;

namespace Ededin_reqemlerinin_ferqli_olub_olmamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uch reqemli eded daxil edin; ");
            int a = Convert.ToInt32(Console.ReadLine());

            int num1 = (a - (a % 100)) / 100;
            int num2 = ((a % 100) - ((a % 100) % 10)) / 10;
            int num3 = (a % 100) % 10;

            Console.WriteLine(GetDifferenceOfNumbers(num1, num2, num3));
        }

        public static int GetDifferenceOfNumbers(int num1, int num2, int num3)
        {
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Ededin reqemleri eynidir");
            }
            else
            {
                Console.WriteLine("Ededin reqemleri muxtelifdir");
            }

            return 0;

        }

    }
}
