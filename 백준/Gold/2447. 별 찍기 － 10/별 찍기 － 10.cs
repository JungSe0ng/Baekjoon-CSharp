
using System.Text;

int n = int.Parse(Console.ReadLine());
char[,] board = new char[n, n];

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        board[i, j] = ' ';

void DrawStar(int x, int y, int size)
{
    if (size == 1)
    {
        board[x, y] = '*';
        return;
    }

    int newSize = size / 3;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (i != 1 || j != 1)
                DrawStar(x + i * newSize, y + j * newSize, newSize);
        }
    }
}

DrawStar(0, 0, n);

StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        stringBuilder.Append(board[i, j]);
    stringBuilder.AppendLine();
}

Console.WriteLine(stringBuilder.ToString());