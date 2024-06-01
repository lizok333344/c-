using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введите строку для шифрования:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите значение сдвига (целое число):");
        int shift = int.Parse(Console.ReadLine());

        
        string encrypted = CaesarCipher(input, shift);

        
        Console.WriteLine("Зашифрованная строка:");
        Console.WriteLine(encrypted);
    }

    static string CaesarCipher(string text, int shift)
    {
        char[] buffer = text.ToCharArray();
        
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            
            
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((((letter + shift) - offset) % 26) + offset);
            }
            
            buffer[i] = letter;
        }
        
        return new string(buffer);
    }
}