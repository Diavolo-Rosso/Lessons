using System;

namespace Replace_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название страны: ");
            string country = Console.ReadLine();
            Console.WriteLine("Введите название ее столицы: ");
            string city = Console.ReadLine();


            string quote = string.Format($"Столица государства {country} - город {city}, самый крупный город.");
            Console.WriteLine(quote);
        }
    }
}
