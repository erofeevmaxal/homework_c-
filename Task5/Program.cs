using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TOP_WORDS_WE_WANT = 3;
            Console.WriteLine("Введите текст в одну строку");
            string input = Console.ReadLine();

            if (input == null || input == "")
            {
                Console.WriteLine("Мне от тебя нужен непустой текст, хитрец");
            }
            List<char> separators = new List<char> { '.', ';', '?', '!' };
            string[] sentences = input.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            separators.Add(' ');
            string[] words = input.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"всего слов: {words.Count()}");
            Console.WriteLine($"всего предложений: {sentences.Count()}");

            Dictionary<string, int> wordCounter = words
                .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(
                    group => group.Key,
                    group => group.Count()
                );

            var topWords = wordCounter
                .OrderByDescending(w => w.Value)
                .Take(TOP_WORDS_WE_WANT);

            double averageWordLength = words.Length > 0 ? words.Average(w => w.Length) : 0;

            Console.WriteLine("Самые частые слова:");
            foreach (var word in topWords)
            {
                Console.WriteLine($"  '{word.Key}': {word.Value} раз");
            }
            Console.WriteLine($"Средняя длина слова: {averageWordLength:F2} символов");

        }
    }
}