using System;

class Program
{
    static void Main()
    {
        
        int[,] array = new int[5, 5];
        Random rand = new Random();
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(-100, 101); 
            }
        }

        
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        
        int minElement = int.MaxValue;
        int maxElement = int.MinValue;
        int minIndex = 0, maxIndex = 0;
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minIndex = i * array.GetLength(1) + j; 
                }
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxIndex = i * array.GetLength(1) + j; 
                }
            }
        }

        
        if (minIndex > maxIndex)
        {
            int temp = minIndex;
            minIndex = maxIndex;
            maxIndex = temp;
        }

        
        int sum = 0;
        for (int k = minIndex + 1; k < maxIndex; k++)
        {
            int i = k / array.GetLength(1);
            int j = k % array.GetLength(1);
            sum += array[i, j];
        }

    
        Console.WriteLine($"Минимальный элемент: {minElement}");
        Console.WriteLine($"Максимальный элемент: {maxElement}");
        Console.WriteLine($"Сумма элементов между минимальным и максимальным: {sum}");
    }
}