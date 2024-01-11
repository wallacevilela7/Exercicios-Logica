using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int diaInicio = int.Parse(input1[1]);

            string[] input2 = Console.ReadLine().Split(new string[] { " : " }, StringSplitOptions.None);

            int horaInicio = int.Parse(input2[0]);
            int minutoInicio = int.Parse(input2[1]);
            int segundoInicio = int.Parse(input2[2]);

            DateTime dataInicio = new DateTime();
            dataInicio =  dataInicio.AddDays(diaInicio - 1);
            dataInicio =  dataInicio.AddHours(horaInicio);
            dataInicio =  dataInicio.AddMinutes(minutoInicio);
            dataInicio =  dataInicio.AddSeconds(segundoInicio);


            string[] input3 = Console.ReadLine().Split(' ');
            int diaFinal = int.Parse(input3[1]);

            string[] input4 = Console.ReadLine().Split(new string[] { " : " }, StringSplitOptions.None);

            int horaFinal = int.Parse(input4[0]);
            int minutoFinal = int.Parse(input4[1]);
            int segundoFinal = int.Parse(input4[2]);

            DateTime dataFinal = new DateTime();
            dataFinal = dataFinal.AddDays(diaFinal - 1);
            dataFinal = dataFinal.AddHours(horaFinal);
            dataFinal = dataFinal.AddMinutes(minutoFinal);
            dataFinal = dataFinal.AddSeconds(segundoFinal);

            TimeSpan duracao = dataFinal - dataInicio;
            
            int diasDuracao = duracao.Days;
            int horasDuracao = duracao.Hours;
            int minutosDuracao = duracao.Minutes;
            int segundosDuracao = duracao.Seconds;

            Console.WriteLine($"{diasDuracao} dia(s)");
            Console.WriteLine($"{horasDuracao} hora(s)");
            Console.WriteLine($"{minutosDuracao} minuto(s)");
            Console.WriteLine($"{segundosDuracao} segundo(s)");

        }
    }
}