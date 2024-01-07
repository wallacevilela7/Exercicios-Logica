using System;
using System.Runtime.InteropServices;
using System.Xml;

class URI
{
    static void Main(string[] args)
    {
        double totalQtd = double.Parse(Console.ReadLine());

        //Notas
        int nCem;
        int nCinquenta;
        int nVinte;
        int nDez;
        int nCinco;
        int nDois;

        //Moedas
        double mUmReal;
        double mCinquentaCent;
        double mVinteCincoCent;
        double mDezCent;
        double mCincoCent;
        double mUmCent;



        nCem = (int) totalQtd / 100;
        totalQtd %= 100;
        nCinquenta = (int) totalQtd / 50;
        totalQtd %= 50;
        nVinte = (int)totalQtd / 20;
        totalQtd %= 20;
        nDez = (int) totalQtd / 10;
        totalQtd %= 10;
        nCinco = (int) (totalQtd / 5);
        totalQtd %= 5;
        nDois = (int)totalQtd / 2;
        totalQtd %= 2;

        mUmReal = (int)totalQtd / 1;
        totalQtd %= 1;
        mCinquentaCent = Math.Floor(totalQtd / 0.50);
        totalQtd %= 0.5;
        mVinteCincoCent = Math.Floor(totalQtd / 0.25);
        totalQtd %= 0.25;
        mDezCent = Math.Floor(totalQtd / 0.10);
        totalQtd %= 0.10;
        mCincoCent = Math.Floor(totalQtd / 0.05);
        totalQtd %= 0.05;
        mUmCent = totalQtd / 0.01;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{nCem} nota(s) de R$ 100.00");
        Console.WriteLine($"{nCinquenta} nota(s) de R$ 50.00");
        Console.WriteLine($"{nVinte} nota(s) de R$ 20.00");
        Console.WriteLine($"{nDez} nota(s) de R$ 10.00");
        Console.WriteLine($"{nCinco} nota(s) de R$ 5.00");
        Console.WriteLine($"{nDois} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{mUmReal} moeda(s) de R$ 1.00");
        Console.WriteLine($"{mCinquentaCent:F0} moeda(s) de R$ 0.50");
        Console.WriteLine($"{mVinteCincoCent:F0} moeda(s) de R$ 0.25");
        Console.WriteLine($"{mDezCent:F0} moeda(s) de R$ 0.10");
        Console.WriteLine($"{mCincoCent:F0} moeda(s) de R$ 0.05");
        Console.WriteLine($"{mUmCent:F0} moeda(s) de R$ 0.01");
    }
}