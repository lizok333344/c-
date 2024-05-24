
using System;

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите первую цифру: ");
        string digit1 = Console.ReadLine();

        Console.Write("Введите вторую цифру: ");
        string digit2 = Console.ReadLine();

        Console.Write("Введите третью цифру: ");
        string digit3 = Console.ReadLine();

        Console.Write("Введите четвертую цифру: ");
        string digit4 = Console.ReadLine();

       
        if (IsDigit(digit1) && IsDigit(digit2) && IsDigit(digit3) && IsDigit(digit4))
        {
           
            string result = digit1 + digit2 + digit3 + digit4;

            
            Console.WriteLine("Сформированное число: " + result);
        }
        else
        {
          
            Console.WriteLine("Введены некорректные значения. Пожалуйста, введите только цифры.");
        }
    }

   
    static bool IsDigit(string input)
    {
        return input.Length == 1 && char.IsDigit(input[0]);
    }
}