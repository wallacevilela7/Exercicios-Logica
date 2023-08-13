/*
 * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o 
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a 
situação.
 */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de X e Y: ");
            Console.Write("X : ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Y : ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(FindQuadrant(x,y));
        }
        static string FindQuadrant(double x, double y)
        {
            string quadrant;

            if (x > 0 && y > 0) quadrant = "Q1";
            else if (x < 0 && y > 0) quadrant = "Q2";
            else if (x < 0 && y < 0) quadrant = "Q3";
            else if (x > 0 && y < 0) quadrant = "Q4";
            else if (x != 0 && y == 0) quadrant = "Eixo X";
            else if (x == 0 && y != 0) quadrant = "Eixo Y";
            else quadrant = "Origem";

            return quadrant;
        }
    }
}