using System;

namespace ArrayMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Random для генерации случайных чисел
            Random rand = new Random();

            // Объявляем массив из 20 целых чисел
            int[] numbers = new int[20];

            // Заполняем массив случайными числами от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101); // Случайное число в диапазоне [1, 100]
            }

            // Находим минимальное и максимальное значение в массиве
            int min = numbers[0];
            int max = numbers[0];

            // Проходим по всему массиву и ищем min и max
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i]; // Обновляем минимальное значение
                }

                if (numbers[i] > max)
                {
                    max = numbers[i]; // Обновляем максимальное значение
                }
            }

            // Выводим массив, минимальное и максимальное значения
            Console.WriteLine("Массив случайных чисел: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nМинимальное значение: " + min);
            Console.WriteLine("Максимальное значение: " + max);
        }
    }
}
