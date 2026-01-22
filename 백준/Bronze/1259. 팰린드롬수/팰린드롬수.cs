using System.Text;

StringBuilder stringBuilder = new StringBuilder();

while (true)
{
    string input = Console.ReadLine();
    if (input == "0")
        break;
    string temp = "";
    for (int i = 0; i < input.Length; i++)
    {
        temp += input[input.Length - 1 - i];
    }
    if(temp == input)
        stringBuilder.AppendLine("yes");
    else
        stringBuilder.AppendLine("no");
}
Console.WriteLine(stringBuilder.ToString());