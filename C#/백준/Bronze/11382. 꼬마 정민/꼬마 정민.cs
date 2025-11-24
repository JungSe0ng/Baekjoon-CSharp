using System;

namespace Baekjoon_CSharp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            long A = long.Parse(inputArray[0]);
            long B = long.Parse(inputArray[1]);
            long C = long.Parse(inputArray[2]);

            Console.WriteLine(A + B + C);
        }
    }
}