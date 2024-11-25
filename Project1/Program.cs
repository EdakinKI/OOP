// Это суепер программа надо её отправить напроверку в Министерство Разработки классных приложений
using System;

class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.WriteLine("Введите число n (от 15 до 30)");
            string n = Console.ReadLine();
            int number;
            // Попытка преобразования строки в целое число
            if (int.TryParse(n, out number) && number >= 15 && number <= 30)
            {
                int j = number;
                int i = 2;
                int result = f(number, i, j) - 1;

                Console.WriteLine($"f({n}) = {result}");

                break; // Выход из цикла, если ввод корректен
            }
            else if (int.TryParse(n, out number) && number == 1)
            {
                Console.WriteLine($"f({n}) = 1");
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, попробуйте снова.");
            }
        }
    }

    static int f(int n, int i, int j)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return f(n - 1, i + 1, j) + j / i;
        }
    }
}

