using System;
using System.Text;

namespace Baekjoon_CSharp
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i < N + 1; i++)
                stringBuilder.AppendLine(i.ToString());

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}