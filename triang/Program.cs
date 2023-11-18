using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите периметр");
        double perim = Convert.ToDouble(Console.ReadLine());
        double side = perim / 3;
        double square = Math.Sqrt(3 * Math.Pow(side, 4) / 16);
        Console.WriteLine("Сторона                   " + "Площадь" + "\n" + side + "\t" + square);

    }
}