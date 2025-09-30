using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль для проверки:");
            string password = Console.ReadLine();
            bool isValid = true;

            if (password.Length < 8)
            {
                Console.WriteLine("длина должна быть не менее 8 символов.");
                isValid = false;
            }

            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Пароль должен содержать хотя бы одну цифру.");
                isValid = false;
            }

            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву.");
                isValid = false;
            }

            if (!password.Any(c => "!@#$%^&*".Contains(c)))
            {
                Console.WriteLine("Пароль должен содержать хотя бы один специальный символ из !@#$%^&*.");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Пароль соответствует всем критериям!");
            }
        }
    }
}