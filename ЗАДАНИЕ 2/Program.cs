using System;

namespace zadanie2;
internal class Program
{
    static void Main(string[] args)
    {
        double s;
        Console.Write("Введите радиус круга: ");
        int b = Convert.ToInt32(Console.ReadLine());
        s = Math.PI * Math.Pow(b, 2);
        Console.Write(s);

    }
}

