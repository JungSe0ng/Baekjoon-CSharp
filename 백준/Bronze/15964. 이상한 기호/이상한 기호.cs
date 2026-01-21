using System.Xml;

int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


long Calculate(int A, int B)
{
    long output = (A + B) * (A - B);
    return output;
}

Console.WriteLine(Calculate(inputArray[0], inputArray[1]));