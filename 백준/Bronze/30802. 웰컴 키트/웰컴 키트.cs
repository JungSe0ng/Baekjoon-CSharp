int n = int.Parse(Console.ReadLine());
int[] sizeArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] countArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int sizeOutput = 0;
for (int i = 0; i < sizeArray.Length; i++)
{
    sizeOutput += sizeArray[i] / countArray[0];
    if (sizeArray[i] % countArray[0] != 0)
        sizeOutput++;
}

Console.WriteLine(sizeOutput);
Console.WriteLine($"{n / countArray[1]} {n % countArray[1]}");