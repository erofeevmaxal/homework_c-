using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            Console.WriteLine("Я загадал число от 1 до 10. Попробуйте угадать!");
            while (true)
            {
                Console.Write("Введите ваше число: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                    continue;
                }
                if (guess == targetNumber)
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {targetNumber}!");
                    break;
                }
                if (guess < targetNumber)
                {
                    Console.WriteLine("Подсказка: моё число больше!");
                }
                else
                {
                    Console.WriteLine("Подсказка: моё число меньше!");
                }
            }
        }
    }
}