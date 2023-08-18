
namespace Exercicio027.Entities
{
    internal class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2)  + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
        }
    }
}
