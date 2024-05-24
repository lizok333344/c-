
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите шестизначное число: ");
        string inputNumber = Console.ReadLine();

        
        if (inputNumber.Length == 6 && int.TryParse(inputNumber, out _))
        {
           
            Console.Write("Введите номер первого разряда для обмена (1-6): ");
            int position1 = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Введите номер второго разряда для обмена (1-6): ");
            int position2 = int.Parse(Console.ReadLine()) - 1;

            
            if (position1 >= 0 && position1 < 6 && position2 >= 0 && position2 < 6)
            {
               
                char[] digits = inputNumber.ToCharArray();

                
                char temp = digits[position1];
                digits[position1] = digits[position2];
                digits[position2] = temp;

                string result = new string(digits);
                Console.WriteLine("Результат обмена: " + result);
            }
            else
            {
                Console.WriteLine("Введены некорректные номера разрядов. Допустимые значения от 1 до 6.");
            }
        }
        else
        {
            Console.WriteLine("Введено некорректное число. Пожалуйста, введите шестизначное число.");
        }
    }
}