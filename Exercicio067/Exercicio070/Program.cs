using System.Text;

StringBuilder sb = new StringBuilder();
bool isPrimeiroLoop = true;

while (true)
{
    int X = int.Parse(Console.ReadLine());

    if (X == 0)
        break;

    if (!isPrimeiroLoop)
        sb.Append('\n');

    for (int i = 1; i <= X; i++)
    {
        sb.Append(i);

        if (i < X)
            sb.Append(' ');
    }

    isPrimeiroLoop = false;
}

Console.WriteLine(sb);