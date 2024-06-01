using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите арифметическое выражение (+ и - поддерживаются):");
        string input = Console.ReadLine();
        
        try
        {
            // Используем DataTable для вычисления выражения
            var result = new DataTable().Compute(input, null);
            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка в выражении: " + ex.Message);
        }
    }
}