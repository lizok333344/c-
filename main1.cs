
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число в диапазоне от 1 до 100: ");
        string input = Console.ReadLine();
        int number;
        
        if (int.TryParse(input, out number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введенное число не находится в диапазоне от 1 до 100.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введенное значение не является числом.");
        }
    }
}