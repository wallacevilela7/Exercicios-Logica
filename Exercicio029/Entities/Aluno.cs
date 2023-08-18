
namespace Exercicio029.Entities
{
    internal class Aluno
    {
        public String Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Media { get; set; }

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalculaMedia()
        {
            Media = Nota1 + Nota2 + Nota3;
            return Media;
        }
        public string VerificaAprovacao()
        {
            if(Media >= 60)
            {
                return "Aprovado";
            }
            else
            {
                double faltou = 60.00 - Media;
                return $"Reprovado\nFaltaram {faltou} pontos";
            }
        }
    }
}
