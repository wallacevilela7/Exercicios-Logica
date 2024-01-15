
int numValidas = 0;
double media = 0.0;
bool validaNota1 = false;
bool validaNota2 = false;
double n1 = 0.0, n2 = 0.0;

int novoCalculo = 0;

do
{
    do
    {
        double input1 = double.Parse(Console.ReadLine());
        validaNota1 = isValid(input1);

        if (validaNota1)
        {
            n1 = input1;
        }
        else
        {
            Console.WriteLine("nota invalida");
            do
            {
                input1 = double.Parse(Console.ReadLine());
                validaNota1 = isValid(input1);
                if (validaNota1) { n1 = input1; break; } else { Console.WriteLine("nota invalida"); }
            } while (validaNota1 == false);
        }

        double input2 = double.Parse(Console.ReadLine());
        validaNota2 = isValid(input2);

        if (validaNota2)
        {
            n2 = input2;
        }
        else
        {
            Console.WriteLine("nota invalida");
            do
            {
                input2 = double.Parse(Console.ReadLine());
                validaNota2 = isValid(input2);
                if (validaNota2) { n2 = input2; break; } else { Console.WriteLine("nota invalida"); }
            } while (validaNota2 == false);
        }


        media = (n1 + n2) / 2;
        Console.WriteLine($"media = {media:F2}");


        Console.WriteLine("novo calculo (1-sim 2-nao)");
        novoCalculo = int.Parse(Console.ReadLine());
        bool fazerNovoCalc = ValidaNovoCalculo(novoCalculo);

        if (fazerNovoCalc)
        {
            if (novoCalculo == 1)
            {
                numValidas = 0;
                validaNota1 = false;
                validaNota2 = false;
                n1 = 0.0;
                n2 = 0.0;
                media = 0.0;
            }
            else if (novoCalculo == 2) numValidas = 2;
        }


        else
        {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            do
            {
                novoCalculo = int.Parse(Console.ReadLine());
                fazerNovoCalc = ValidaNovoCalculo(novoCalculo);
                if(!fazerNovoCalc) Console.WriteLine("novo calculo (1-sim 2-nao)");
                if (novoCalculo == 1)
                {
                    numValidas = 0;
                    validaNota1 = false;
                    validaNota2 = false;
                    n1 = 0.0;
                    n2 = 0.0;
                    media = 0.0;
                }
                else if (novoCalculo == 2) numValidas = 2;
            } while (fazerNovoCalc == false);
        }

    } while (numValidas < 2);
} while (novoCalculo != 2);


static bool isValid(double x)
{
    return x >= 0 && x < 10.1;
}
static bool ValidaNovoCalculo(double y)
{
    return y == 1 || y == 2;
}