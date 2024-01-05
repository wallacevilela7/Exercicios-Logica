using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio043
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
            return (2 * (Largura + Altura));
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) +  Math.Pow(Altura, 2));
        }
    }
}
