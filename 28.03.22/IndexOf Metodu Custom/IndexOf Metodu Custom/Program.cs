using System;

namespace IndexOf_Metodu_Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write text: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please, write the character you want to find: ");
            char x = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(CustomIndexOf(text, x));

        }

        public static int CustomIndexOf(string text, char x)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == x)
                {
                    return 0;
                }
            }         
        }
        
    }
}
