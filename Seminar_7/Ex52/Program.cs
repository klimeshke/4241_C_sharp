// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] matrix = FillMatrixRandomInt(4, 4);
PrintMatrix(matrix);
ColumnAveragesMatrix(matrix);


int[,] FillMatrixRandomInt(int rowsMatrix, int columnsMatrix)
{
    int[,] martixRandom = new int[rowsMatrix, columnsMatrix];
    for (int i = 0; i < rowsMatrix; i++)
    {
        for (int j = 0; j < columnsMatrix; j++)
        {
            martixRandom[i, j] = new Random().Next(1, 100);
        }
    }
    return martixRandom;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ColumnAveragesMatrix(int[,] matrix)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double averages = sum / matrix.GetLength(0);
        Console.Write($"{averages}; ");
        sum = 0;
    }
}
