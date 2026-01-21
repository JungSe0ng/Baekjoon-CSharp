string input = Console.ReadLine();
string output = "";

for (int i = 0; i < input.Length; i++)
{
    if (char.IsUpper(input[i]))
        output += char.ToLower(input[i]);
    else
        output += char.ToUpper(input[i]);
}
Console.WriteLine(output);