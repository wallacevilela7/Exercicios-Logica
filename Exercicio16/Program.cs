/*
 *  Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
    cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
    menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as Coordenadas do plano cartesiano (x,y)");
            while(x != 0 || y != 0)
            {
                Console.Write("X : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y : ");
                int y = int.Parse(Console.ReadLine());

                if (x > 0 & y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
            }
        }
    }
}