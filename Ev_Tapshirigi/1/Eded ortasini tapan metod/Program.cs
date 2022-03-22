using System;

namespace Eded_ortasini_tapan_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin; ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Ikinci ededi daxil edin; ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Ededlerin ededi ortasi; ");
            Console.WriteLine(GetNumericalAvarage(a, b));

            int average = (GetNumericalAvarage(a, b));

            if (average > 10)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ededi orta 10'dan boyukdur");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ededi orta 10'dan kicikdir");
            }

        }
        public static int GetNumericalAvarage(int a, int b)
        {
            int average;
            average = (a + b) / 2;
            return average;
        }

    }
}
