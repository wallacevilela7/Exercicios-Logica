int linhas = int.Parse(Console.ReadLine());

for(int i = 1; i <= linhas; i++)
{
    Console.WriteLine($"{i} {i*i} {i*i*i}");
    Console.WriteLine($"{i} {(i*i)+1} {(i*i*i)+1}");
}