using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wielkość tablicy:");
        int wielkosc = int.Parse(Console.ReadLine());
        double[] tablica = new double[wielkosc];
        Random rand = new Random();
        for (int i = 0; i < wielkosc; i++)
        {
            tablica[i] = rand.NextDouble() * 100;
        }
        Console.WriteLine("Wyrazy z tablicy to:");
        Console.WriteLine();
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + "\t");
        }
        double srednia = ObliczanieSredniej(tablica, wielkosc);
        Console.WriteLine("\nŚrednia arytmetyczna dla powyższego zbioru liczb wynosi: " + srednia);

    }
    public static double ObliczanieSredniej(double[] tablica, int rozmiar)
    {
        if (rozmiar == 0)
        {
            return 0;
        }
        double suma = ObliczanieSredniej(tablica, rozmiar - 1) * (rozmiar - 1) + tablica[rozmiar - 1];
        return suma / rozmiar;
    }
}