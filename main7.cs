
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите первое число: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Введите второе число: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                
                int start = Math.Min(num1, num2);
                int end = Math.Max(num1, num2);

                
                Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод первого числа.");
        }
    }
}