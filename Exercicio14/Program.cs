/*
 * Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
    que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
    qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
    Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
    mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
    RENDA          Imposto de Renda
  de 0.0 a 2.000            Isento
  2.001 até 3.000           8%
  3.000 até 4.500           18%
  acima de 4.500            28%
 */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário:  ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double taxValue = TaxCalculator(salary);

            if (taxValue == 0.0)
            {
                Console.WriteLine("Valor do Imposto de Renda: Isento");
            }
            else
            {
                Console.WriteLine($"Valor do Imposto de Renda R$ {taxValue.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
        static double TaxCalculator(double x)
        {
            double tax = double.MinValue;
            double value = double.MinValue;

            if (x <= 2000)
            {
                value = 0.0;
            }
            else if (x > 2000 && x <= 3000)
            {
                tax = 0.08;
                value = (x - 2000.0) * 0.08;
            }
            else if (x > 3000 && x <= 4500)
            {
                tax = 0.18;
                value = (x - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else if (x > 4.500)
            {
                tax = 0.28;
                value = (x - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            return value;
        }
    }
}