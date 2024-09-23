using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите чётное число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b%2==0)
            {
                Console.WriteLine("Введённое число является чётным");
            }
            else 
            {
                Console.WriteLine("Введённое число не является чётным");
            }
        }
    }
}