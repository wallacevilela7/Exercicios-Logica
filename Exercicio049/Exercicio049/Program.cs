using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            // Passo 1: Leitura dos dados
            int horaInicial = int.Parse(input[0]);

            int minutoInicial = int.Parse(input[1]);

            int horaFinal = int.Parse(input[2]);

            int minutoFinal = int.Parse(input[3]);

            // Passo 2: Cálculo da diferença
            int tempoInicialEmMinutos = horaInicial * 60 + minutoInicial;
            int tempoFinalEmMinutos = horaFinal * 60 + minutoFinal;

            // Lidar com o caso em que o tempo final é menor que o tempo inicial
            if (tempoFinalEmMinutos < tempoInicialEmMinutos)
            {
                tempoFinalEmMinutos += 24 * 60;  // Adiciona 24 horas para considerar o próximo dia
            }

            int duracaoEmMinutos = tempoFinalEmMinutos - tempoInicialEmMinutos;

            // Passo 3: Garantir a duração mínima e máxima
            // Garantir duração mínima
            if (duracaoEmMinutos < 1)
            {
                duracaoEmMinutos += 24 * 60;  // Adiciona 24 horas
            }

            // Garantir duração máxima
            if (duracaoEmMinutos > 24 * 60)
            {
                duracaoEmMinutos %= 24 * 60;  // Reduz para menos de 24 horas
            }

            // Passo 4: Exibição do resultado
            int duracaoHoras = duracaoEmMinutos / 60;
            int duracaoMinutos = duracaoEmMinutos % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

        }
    }
}