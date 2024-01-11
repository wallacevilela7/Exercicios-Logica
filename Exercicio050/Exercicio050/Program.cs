using System;
using System.Xml.Serialization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());

            double imposto = 0.0;

            if(valor < 0.00)
            {
                Environment.ExitCode = 0;
            }
            else if( valor >= 0.00 && valor <= 2000.00)
            {
                imposto = 0.0;
            }
            else if(valor > 2000.00 && valor <= 3000.00)
            {
                valor = valor - 2000.00;
                imposto = valor * 0.08;
                
            }
            else if(valor > 3000.00 && valor <= 4500.00)
            {
                valor = valor - 2000.00;
                double taxa1 = 1000.00 * 0.08;
                double taxa2 = (valor - 1000.00) * 0.18;
                imposto = taxa1 + taxa2;
            }
            else if(valor > 4500.00)
            {
                valor = valor - 2000.00;
                double taxa1 = 1000.00 * 0.08;
                double taxa2 = 1500.00 * 0.18;
                double taxa3 = (valor - 2500.00) * 0.28;
                imposto = taxa1 + taxa2 + taxa3;
            }

            string isento = imposto == 0 ? "Isento" : string.Empty;

            if(isento != string.Empty)
            {
                Console.WriteLine(isento);
            }
            else
            {
                Console.WriteLine($"R$ {imposto:F2}");
            }
        }
    }
}