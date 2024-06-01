using System;

class Program
{
    static void Main()
    {
        
        int[] A = new int[5];
        double[,] B = new double[3, 4];

        
        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        
        Random rand = new Random();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = rand.NextDouble() * 100; 
            }
        }

        
        Console.WriteLine("Массив A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        
        Console.WriteLine("Массив B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]:F2} ");
            }
            Console.WriteLine();
        }

        
        double maxElement = double.MinValue;
        foreach (int num in A)
        {
            if (num > maxElement)
                maxElement = num;
        }
        foreach (double num in B)
        {
            if (num > maxElement)
                maxElement = num;
        }
        Console.WriteLine($"Общий максимальный элемент: {maxElement}");

       
        double minElement = double.MaxValue;
        foreach (int num in A)
        {
            if (num < minElement)
                minElement = num;
        }
        foreach (double num in B)
        {
            if (num < minElement)
                minElement = num;
        }
        Console.WriteLine($"Общий минимальный элемент: {minElement}");

        
        double totalSum = 0;
        foreach (int num in A)
        {
            totalSum += num;
        }
        foreach (double num in B)
        {
            totalSum += num;
        }
        Console.WriteLine($"Общая сумма всех элементов: {totalSum}");

        double totalProduct = 1;
        foreach (int num in A)
        {
            totalProduct *= num;
        }
        foreach (double num in B)
        {
            totalProduct *= num;
        }
        Console.WriteLine($"Общее произведение всех элементов: {totalProduct}");

       
        int evenSumA = 0;
        foreach (int num in A)
        {
            if (num % 2 == 0)
                evenSumA += num;
        }
        Console.WriteLine($"Сумма четных элементов массива A: {evenSumA}");

        
        double oddColumnsSumB = 0;
        for (int j = 1; j < B.GetLength(1); j += 2)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                oddColumnsSumB += B[i, j];
            }
        }
        Console.WriteLine($"Сумма нечетных столбцов массива B: {oddColumnsSumB}");
    }
}