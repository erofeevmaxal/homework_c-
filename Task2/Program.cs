using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа по одному. Для завершения ввидите 0.");
            float sum = 0;

            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out float number))
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    continue;
                }

                if (number == 0)
                {
                    break;
                }

                sum += number;
                Console.WriteLine($"Текущая сумма: {sum}");
            }
        }
    }
}