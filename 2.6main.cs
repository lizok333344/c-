using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        
        string result = CapitalizeSentences(input);
        
        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }

   static string CapitalizeSentences(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        StringBuilder result = new StringBuilder(text.Length);

        bool newSentence = true;

        foreach (char c in text)
        {
            if (newSentence && char.IsLetter(c))
            {
                result.Append(char.ToUpper(c, CultureInfo.InvariantCulture));
                newSentence = false;
            }
            else
            {
                result.Append(c);
            }

            if (c == '.'  c == '?')
            {
                newSentence = true;
            }
        }

        return result.ToString();
    }
}