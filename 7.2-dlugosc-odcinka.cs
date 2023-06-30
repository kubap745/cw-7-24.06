using System;

public class MyProgram
{
    public static void Main()
    {
        float  x1, y1, x2, y2;
        decimal długość;
        Console.WriteLine("Podaj współrzędną X pierwszego punktu");
        x1 = inputValue();
        Console.WriteLine("Podaj współrzędną Y pierwszego punktu");
        y1 = inputValue();
        Console.WriteLine("Podaj współrzędną X drugiego punktu");
        x2 = inputValue();
        Console.WriteLine("Podaj współrzędną Y drugiego punktu");
        y2 = inputValue();
        długość = (decimal) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Długość odcinka o współrzędnych {x1},{y1} i {x2},{y2} wynosi {długość}");
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}