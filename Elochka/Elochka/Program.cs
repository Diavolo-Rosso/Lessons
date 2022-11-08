using System;
using System.Runtime.CompilerServices;

namespace Elochka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Высота елочки: ");
            int H = Int32.Parse(Console.ReadLine());
            string Z = "*";
            for (int i = 0; i < H; i++)
            {
                Console.WriteLine(Z);
                Z += "*";
            }
            Console.ReadLine();
        }
    }
}
