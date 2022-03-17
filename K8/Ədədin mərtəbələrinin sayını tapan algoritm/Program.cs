using System;

namespace Ədədin_mərtəbələrinin_sayını_tapan_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7878;
            int floor = 0;

            while (a > 0)
            {
                a /= 10;
                floor++;
            }

            Console.WriteLine(floor);

        }
    }
}
