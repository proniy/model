using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Генерация случайного числа от 1 до 100

            Console.WriteLine($"Случайное число: {randomNumber}");
        }
    }
}