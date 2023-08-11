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

            bool nullCoordinate = false;

            while (!nullCoordinate)
            {
                Console.WriteLine("Digite as Coordenadas do plano cartesiano (x,y)");
                Console.Write("X : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y : ");
                int y = int.Parse(Console.ReadLine());

                if (x == 0 || y == 0)
                {
                    nullCoordinate = true;
                }
                else if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if( x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto quadrante");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}