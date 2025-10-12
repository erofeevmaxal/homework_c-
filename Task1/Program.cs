using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("температура в градусах Цельсия: ");
            string input = Console.ReadLine();

            if (float.TryParse(input, out float degreesCelsius))
            {
                float degreesFahrenheit = degreesCelsius * 1.8f + 32;
                Console.WriteLine($"{degreesCelsius}°C = {degreesFahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Ошибка: некорректное число.");
            }
        }
    }
}
