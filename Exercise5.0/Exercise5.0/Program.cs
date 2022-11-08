using System;
using System.Globalization;

namespace Replace_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);

            Console.WriteLine("Введите X-ый символ: ");
            int x = Convert.ToInt32(Console.ReadLine());  // Перевод вводимой строки которая по умолчанию идет как string -> int
            Console.WriteLine(s[x]);

            Console.WriteLine("Введите Y-ый символ: ");
            int y = Convert.ToInt32(Console.ReadLine()); // Перевод вводимой строки которая по умолчанию идет как string -> int
            Console.WriteLine(s[y]);
        }
    }
}
