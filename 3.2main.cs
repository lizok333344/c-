using System;

class Program
{
    static void Main()
    {
        // Примеры использования метода
        Console.WriteLine(IsPalindrome(1221)); // true
        Console.WriteLine(IsPalindrome(3443)); // true
        Console.WriteLine(IsPalindrome(7854)); // false
    }

    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int length = numStr.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numStr[i] != numStr[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}