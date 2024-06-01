using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Определение списка недопустимых слов
        List<string> forbiddenWords = new List<string> { "плохое", "запрещенное", "недопустимое" };
        
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        
        string result = ReplaceForbiddenWords(input, forbiddenWords, out int replacements);
        
        Console.WriteLine("Результат:");
        Console.WriteLine(result);
        
        Console.WriteLine("Статистика:");
        Console.WriteLine($"Количество замененных слов: {replacements}");
    }

    static string ReplaceForbiddenWords(string text, List<string> forbiddenWords, out int replacements)
    {
        replacements = 0;

        foreach (string word in forbiddenWords)
        {
            string replacement = new string('*', word.Length);
            int wordIndex = text.IndexOf(word, StringComparison.OrdinalIgnoreCase);

            while (wordIndex != -1)
            {
                text = text.Substring(0, wordIndex) + replacement + text.Substring(wordIndex + word.Length);
                replacements++;
                wordIndex = text.IndexOf(word, wordIndex + replacement.Length, StringComparison.OrdinalIgnoreCase);
            }
        }

        return text;
    }
}using System;
using System.Collections.Generic;