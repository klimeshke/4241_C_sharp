// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] matrix = FillMatrixRandomInt(4, 4, 1, 10);
Console.WriteLine("Задан массив:");
Console.WriteLine();
PrintMatrix(matrix);
SortMatrixRowsToMin(matrix);
Console.WriteLine("Отсортированный массив: ");
Console.WriteLine();
PrintMatrix(matrix);


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

void SortMatrixRowsToMin(int[,] sortMatrix)
{
    int rows = sortMatrix.GetLength(0);
    int columns = sortMatrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (sortMatrix[i, k] < sortMatrix[i, k + 1])
                {
                    int temp = sortMatrix[i, k];
                    sortMatrix[i, k] = sortMatrix[i, k + 1];
                    sortMatrix[i, k + 1] = temp;
                }
            }
        }
    }
}


