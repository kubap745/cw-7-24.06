using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int number, dividend, divisorCount = 0;
        Console.WriteLine("Podaj liczbę naturalną większą niż 5: ");
        number = inputValue();

        if (number <= 5)
        {
            Console.WriteLine($"Liczby pierwsze będące dzielnikami tej liczby to: 0");
        }
        else
        {
            Console.WriteLine($"Liczby pierwsze będące dzielnikami liczby {number} to:");
            Console.WriteLine();

            for (dividend = 2; dividend <= number; dividend++)
            {
                if (number % dividend == 0 && IsPrime(dividend))
                {
                    divisorCount++;
                    Console.WriteLine("" + divisorCount + ")" + dividend);

                }
            }
        }
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}