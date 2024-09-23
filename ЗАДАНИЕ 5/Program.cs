using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст человека: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 18)
            {
                Console.WriteLine("Ненужна тебе такая машина брат");
            }
            else
            {
                Console.WriteLine("Молодчина брат");
            }
        }
    }
}