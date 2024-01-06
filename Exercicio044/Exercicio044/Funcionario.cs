using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio044
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Imposto { get; set; }
        public double SalarioBruto { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, double imposto, double salarioBruto)
        {
            Nome = nome;
            Imposto = imposto;
            SalarioBruto = salarioBruto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double pct)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (pct/100));
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, $ {SalarioLiquido():F2}";
        }
    }
}
