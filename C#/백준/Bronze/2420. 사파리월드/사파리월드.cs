using System;

namespace Baekjoon_CSharp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            long n = long.Parse(inputArray[0]);
            long m = long.Parse(inputArray[1]);
            Console.WriteLine(Math.Abs(n - m));

        }
    }
}