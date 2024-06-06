using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Примеры использования метода
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] resultArray = FilterArray(originalArray, filterArray);

        // Вывод результата
        Console.WriteLine(string.Join(" ", resultArray)); // 1 2 -1
    }

    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        // Преобразование filterArray в HashSet для увеличения производительности поиска
        var filterSet = new HashSet<int>(filterArray);

        // Фильтрация оригинального массива
        return originalArray.Where(x => !filterSet.Contains(x)).ToArray();
    }
}