using System;

namespace Baekjoon_CSharp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int A = int.Parse(inputArray[0]);
            int B = int.Parse(inputArray[1]);

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
    }
}