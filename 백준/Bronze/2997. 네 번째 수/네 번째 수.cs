string[] inputArray = Console.ReadLine().Split(' ');
int[] intArray = new int[3];

for (int i = 0; i < intArray.Length; i++)
    intArray[i] = int.Parse(inputArray[i]);

for (int i = 0; i < intArray.Length - 1; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] > intArray[j])
        {
            int temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}

int difference = intArray[1] - intArray[0];

if (difference == intArray[2] - intArray[1])
{
    Console.WriteLine(intArray[2] + difference);
}
else
{
    int[] tempArray = new int[2];
    for (int i = 0; i < intArray.Length - 1; i++)
    {
        tempArray[i] = intArray[i + 1] - intArray[i];
    }

    if (tempArray[0] > tempArray[1])
    {
        Console.WriteLine(intArray[0] + tempArray[1]);
    }
    else
    {
        Console.WriteLine(intArray[1] + tempArray[0]);
    }
}