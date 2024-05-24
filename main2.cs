
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите значение: ");
        string inputValue = Console.ReadLine();
        
    
        Console.Write("Введите процент: ");
        string inputPercentage = Console.ReadLine();

    
        if (double.TryParse(inputValue, out double value) && double.TryParse(inputPercentage, out double percentage))
        {
            
            double result = (value * percentage) / 100;

            
            Console.WriteLine($"{percentage}% от {value} = {result}");
        }
        else
        {
            
            Console.WriteLine("Введены некорректные значения. Пожалуйста, введите числа.");
        }
    }
}