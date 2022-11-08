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


            string quote = string.Format("Столица государства {0} - город {1}, самый крупный город.", country, city);
            Console.WriteLine(quote);
        }
    }
}
