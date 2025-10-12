using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TOP_WORDS_NUMBER = 3;
            Console.WriteLine("Введите текст в одну строку");
            string input = Console.ReadLine();

            if (input == null || input == "")
            {
                Console.WriteLine("Ошибка: пустая строка");
            }
            char[] sentencesSeparators = ['.', ';', '?', '!'];
            char[] wordsSeparators = ['.', ';', '?', '!', ',', ':'];

            string[] sentences = input.Split(sentencesSeparators, StringSplitOptions.RemoveEmptyEntries);
            string[] words = input.Split(wordsSeparators, StringSplitOptions.RemoveEmptyEntries);

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
                .Take(TOP_WORDS_NUMBER);

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