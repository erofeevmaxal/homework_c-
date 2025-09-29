using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("температура в градусах Цельсия: ");
            string input = Console.ReadLine();
            float degreesCelsius = float.Parse(input);
            float degreesFahrenheit = degreesCelsius * 1.8f + 32;
            Console.WriteLine($"температура в градусах Фаренгейта: {degreesFahrenheit}");
        }
    }
}
