/*
 *  Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
    começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horario inicial: ");
            int initial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o horario final: ");
            int final = int.Parse(Console.ReadLine());

            Console.WriteLine(GetDuration(initial, final));
        }
        static string GetDuration(int x, int y)
        {
            int duration;
            if(x < y)
            {
                duration = y - x;
            }
            else
            {
                duration = 24 - x + y;
            }
            return $"A duração do foi de {duration} horas";
        }
    }
}