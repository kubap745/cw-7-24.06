using System;

namespace program_z_zajęć
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabela =
            {
                {1,2,3,4,5},
                {6,7,8,9,0},
                {10,11,12,13,14},
                {1,3,3,4,5 } 
            };
            NajbardziejPodobneWiersze(tabela, out int row1, out int row2);
            Console.WriteLine($"Najbardziej podobne wiersze to: {row1} i {row2}");
        }
        static void NajbardziejPodobneWiersze(int[,] tabela, out int row1, out int row2)
        {
            long najmniejszaRoznica = long.MaxValue;
            int iloscWierszy = tabela.GetLength(0);
            int iloscKolumn = tabela.GetLength(1);
            row1 = 0;
            row2 = 0;
            for (int i = 0; i < iloscWierszy; i++)
            {
                for (int j = i + 1; j < iloscWierszy; j++)
                {
                    long roznica = wyliczRoznice(tabela, i, j);
                    if (roznica < najmniejszaRoznica)
                    {
                        najmniejszaRoznica = roznica;
                        row1 = i;
                        row2 = j;
                    }
                }
            }
        }
        static long wyliczRoznice(int[,] tabela, int i, int j)
        {
            int iloscKolumn = tabela.GetLength(1);
            long roznica = 0;

            for (int kol = 0; kol < iloscKolumn; kol++)
            {
                roznica += (long)Math.Pow(tabela[i, kol] - tabela[j, kol], 2);
            }
            return roznica;
        }

    }
}
