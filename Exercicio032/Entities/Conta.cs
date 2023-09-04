using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Exercicio032.Entities
{
    public class Conta
    {
        private int Id { get; set; }
        public string Nome { get; set; }
        private double Saldo { get; set; }

        public Conta(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Conta(int id, string nome, double depositoInicial) : this(id, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public bool Saque(double quantia)
        {
            if(quantia > (Saldo - 5.00))
            {
                return false;
            }
            else
            {
                Saldo -= quantia + 5.00;
                return true;
            }
        }
        public override string ToString()
        {
            return "Titular: "
                + Nome
                + ", "
                + " R$: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
