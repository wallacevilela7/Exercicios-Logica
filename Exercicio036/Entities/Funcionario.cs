using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio036.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        private double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(double pct)
        {
            Salario += (Salario * pct/100);
        }

        public override string ToString()
        {
            return "#" +Id + ":" + " " + Nome + " R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
