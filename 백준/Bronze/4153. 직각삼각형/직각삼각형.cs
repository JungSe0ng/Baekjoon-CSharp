using System.Text;

StringBuilder stringBuilder = new StringBuilder();

while (true)
{
    string input = Console.ReadLine();
    if (input == "0 0 0")
        break;

    long[] tempArray = Array.ConvertAll(input.Split(' '), long.Parse);

    for (int i = 0; i < tempArray.Length; i++)
    {
        for (int j = i; j < tempArray.Length - 1; j++)
        {
            if (tempArray[j] > tempArray[j + 1])
            {
                long temp = tempArray[j];
                tempArray[j] = tempArray[j + 1];
                tempArray[j + 1] = temp;
            }
        }
    }

    if (tempArray[0] * tempArray[0] + tempArray[1] * tempArray[1] == tempArray[2] * tempArray[2])
        stringBuilder.AppendLine("right");
    else
        stringBuilder.AppendLine("wrong");
}

Console.WriteLine(stringBuilder);