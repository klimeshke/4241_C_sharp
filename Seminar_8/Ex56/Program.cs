// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] matrix = FillMatrixRandomInt(4, 4, 1, 10);
int minRow = 0;
Console.WriteLine("Задан массив:");
Console.WriteLine();
PrintMatrix(matrix);
MaxRowsMatrixSum(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка");

int[,] FillMatrixRandomInt(int rowsMatrix, int columnsMatrix, int min, int max)
{
    int[,] arrayRandom = new int[rowsMatrix, columnsMatrix];
    for (int i = 0; i < rowsMatrix; i++)
    {
        for (int j = 0; j < columnsMatrix; j++)
        {
            arrayRandom[i, j] = new Random().Next(min, max);
        }
    }
    return arrayRandom;
}

void PrintMatrix(int[,] PrMatrix)
{
    for (int i = 0; i < PrMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < PrMatrix.GetLength(1); j++)
        {
            Console.Write($"{PrMatrix[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MaxRowsMatrixSum(int[,] marix)
{
    int sumRow = int.MaxValue; // присваеваем максимальное значение для сравнения чтобы как надо работало условие ЕСЛИ
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0; // присваеваем начальное значение для суммы, будет обнулятся при переходе на новую строку
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < sumRow)
        {
            sumRow = sum;
            minRow = i + 1; // +1 т.к. нам нужен номер строки а не индекс
        }
    }
    return minRow;
}