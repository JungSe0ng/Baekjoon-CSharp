int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


int Calculate(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp += (arr[i] * arr[i]);
    }
    temp = temp % 10;
    return temp;
}

Console.WriteLine(Calculate(inputArray));