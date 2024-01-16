int option = 0;
int gasolina = 0;
int alcool = 0;
int diesel = 0;


while(option != 4)
{
    option = int.Parse(Console.ReadLine());
    switch (option) {
        case 1: alcool++;break;
        case 2: gasolina++;break;
        case 3: diesel++;break;
        case 4: option = 4; break;
        default: break;
    }
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");