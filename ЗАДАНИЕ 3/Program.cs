using System;

namespace NameSurnameApp
{
    // Структура для хранения имени и фамилии
    struct Person
    {
        public string firstName;
        public string lastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Массив для хранения одного человека
            Person[] people = new Person[1];
            bool exit = false;

            while (!exit)
            {
                // Консольное меню
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести имя");
                Console.WriteLine("2. Ввести фамилию");
                Console.WriteLine("3. Вывести имя и фамилию");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите пункт меню: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        people[0].firstName = Console.ReadLine();
                        break;

                    case "2":
                        Console.Write("Введите фамилию: ");
                        people[0].lastName = Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine($"Результат: {people[0].lastName}, {people[0].firstName}");
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;

                    default:
                        Console.WriteLine("Неправильный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine(); // Пустая строка для разделения выводов
            }
        }
    }
}
