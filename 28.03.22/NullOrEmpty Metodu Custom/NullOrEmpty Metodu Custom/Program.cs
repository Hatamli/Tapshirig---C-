using System;

namespace NullOrEmpty_Metodu_Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write a text: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine(IsNullOrEmptyCustom(text));
        }

        public static bool IsNullOrEmptyCustom(string text)
        {
            if (text == " " && text == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
