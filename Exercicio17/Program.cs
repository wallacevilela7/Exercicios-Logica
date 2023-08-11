/*
 * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo.
 */


using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("1.Álcool\n2.Gasolina\n3.Diesel\n4.Fim");
            Console.WriteLine("Escolha o seu tipo de combustível favorito:  ");
            int option = int.Parse(Console.ReadLine());

            while (option != 4)
            {

                if (option == 1)
                {
                    alcool++;
                }
                else if (option == 2)
                {
                    gasolina++;
                }
                else if (option == 3)
                {
                    diesel++;
                }

                option = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}