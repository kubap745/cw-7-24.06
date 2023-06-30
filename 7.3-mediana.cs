using System;

public class MyProgram
{
    public static void Main()
    {
        int n,temp;
        float mediana;
        Console.WriteLine("Podaj rozmiar tabeli(max. 100)");
        n = inputValue();
        while (n>100 || n<=0)
        {
            Console.WriteLine("Podaj rozmiar tabeli(max. 100)");
            n = inputValue();
        }
        int[] tabela = InsertValue(n);
        int[] posortowana = SetSort(tabela,n);
        temp = posortowana.Length;
        if(temp%2==0)
        {
            mediana = (posortowana[temp/2-1]+posortowana[temp/2])/2;
        }
        else
        {
            mediana = posortowana[(1 + temp) / 2-1];
        }
        Console.WriteLine("Zbiór liczb wygląda tak :");
        Console.WriteLine();
        for (int i = 0; i < posortowana.Length; i++)
        {
            Console.Write(posortowana[i]);
            if(i+1< posortowana.Length)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine($"\nWartośc mediany to : {mediana}");
    }
    private static int[] InsertValue(int aov)
    {
        int a, b;
        int[] tablica = new int[aov];
        Random generator = new Random();
        Console.WriteLine("Podaj początek przedziału");
        a = inputValue();
        Console.WriteLine("Podaj koniec przedziału");
        b = inputValue();
        for (int i = 0; i < aov; i++)
        {
            tablica[i] = generator.Next(a, b);
        }
        return tablica;
    }
    private static int[] SetSort(int[] tablica, int aov)
    {
        int[] tablica_2 = new int[aov];
        for (int i = 0; i < tablica.Length; i++)
        {
            if (i == 0)
            {
                tablica_2[i] = tablica[i];
            }
            else
            {
                for (int y = i; y > 0; y--)
                {
                    if (tablica_2[y - 1] > tablica[i])
                    {
                        tablica_2[y] = tablica_2[y - 1];
                        tablica_2[y - 1] = tablica[i];
                    }
                    else
                    {
                        tablica_2[y] = tablica[i];
                        break;
                    }
                }
            }
        }
        return tablica_2;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
