using System.Globalization;

String phrase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
char[] phraseArray = new char[phrase.Length];

//copiar uma string para um array de char posição por posição
for (int i = 0; i < phrase.Length; i++)
{
    phraseArray[i] = phrase[i];
}
if (!int.TryParse(Console.ReadLine(), out int x));


for(int i = 0; i < x; i++)
{
    if(i < x - 1)Console.Write(phraseArray[i]);
    else Console.Write($"{phraseArray[i]}\n");
}