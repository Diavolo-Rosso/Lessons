using System;
using System.Buffers;

namespace Cutting_Trim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "информатика";
            string s2 = s1.Substring(2, 5);

            string s3 = s1.Substring(7, 3);

            Console.WriteLine(s2);
            Console.WriteLine(s3);

        }
    }
}