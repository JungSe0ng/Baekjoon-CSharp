using System;

namespace Baekjoon_CSharp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            double A = double.Parse(inputArray[0]);
            double B = double.Parse(inputArray[1]);

            Console.WriteLine(A/B);
        }
    }
}