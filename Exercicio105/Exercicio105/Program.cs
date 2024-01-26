
while (true)
{
    if(!int.TryParse(Console.ReadLine(), out int qtdGrupo))
    {
        break;
    }

    int element = 0;
    List<int> list = new List<int>();

    string[] input = new string[qtdGrupo];
    input = Console.ReadLine().Split(' ');

    for (int i = 0; i < input.Length; i++)
    {
        element = int.Parse(input[i]);
        list.Add(element);
    }

    Console.WriteLine(GetBigger(list));
}

static int GetBigger(List<int> list)
{
    int bigger = list.Max(x => x);
    if (bigger < 10) return 1;
    else if (bigger >= 10 && bigger < 20) return 2;
    else return 3;
}
