// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] matrix1 = FillMatrixRandomInt(2, 2, 1, 10);
int[,] matrix2 = FillMatrixRandomInt(2, 2, 1, 10);
int[,] resultMatrix = new int[2, 2];
Console.WriteLine("Даны 2 матрицы:");
Console.WriteLine();
PrintMatrix(matrix1);
PrintMatrix(matrix2);
MultipleMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine("Результирующая матрица будет:");
Console.WriteLine();
PrintMatrix(resultMatrix);


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

void MultipleMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int multiple = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiple += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = multiple;
            multiple = 0;
        }
    }
}