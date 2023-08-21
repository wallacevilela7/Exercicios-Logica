
namespace Exercicio031
{
    internal static class ConversorDeMoeda
    {
        public static double CalcDolarPraReal(double cotacaoDolar, double valorEmDolar)
        {
            return (cotacaoDolar * valorEmDolar) + ((cotacaoDolar * valorEmDolar) * 0.06);
        }
    }
}
