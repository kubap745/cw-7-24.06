
using System;

public class MyProgram
{
    public static void Main()
    {
        int czas,sekundy,minuty,godziny;
        czas = inputValue();
        godziny = czas / 3600;
        minuty = (czas % 3600)/60;
        sekundy = (czas % 3600)%60;
        string upłyneło = $"{godziny:00}:{minuty:00}:{sekundy:00}";
        Console.WriteLine($"Od 00:00:00 upłyneło {upłyneło}");
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
