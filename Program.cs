// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("");
Console.WriteLine("\t Задача 52");
int[,] array = GetArray(7, 9, 0, 9);
PrintArray(array);
ArithmeticMean(array);

void ArithmeticMean(int[,] inArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {

            arithmeticMean = arithmeticMean + array[j, i];

        }
        arithmeticMean = arithmeticMean / inArray.GetLength(0);
        Console.Write($"{arithmeticMean:F2}; ");

    }
    Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
    Console.WriteLine(". ");
    Console.WriteLine("");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; \t");
        }
        Console.SetCursorPosition(Console.CursorLeft - 7, Console.CursorTop);
        Console.WriteLine(" ]");
    }
    Console.WriteLine("");
}