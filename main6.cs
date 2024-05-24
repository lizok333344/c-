
using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Выберите вариант конверсии:");
        Console.WriteLine("1: Перевести из Фаренгейта в Цельсий");
        Console.WriteLine("2: Перевести из Цельсия в Фаренгейт");
        Console.Write("Введите 1 или 2: ");
        string choice = Console.ReadLine();

        
        if (choice == "1")
        {
            
            Console.Write("Введите температуру в Фаренгейтах: ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсиях: {celsius:F2}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод температуры.");
            }
        }
        else if (choice == "2")
        {
            
            Console.Write("Введите температуру в Цельсиях: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit:F2}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод температуры.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный выбор. Пожалуйста, введите 1 или 2.");
        }
    }
}