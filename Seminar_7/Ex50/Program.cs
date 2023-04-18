// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int[,] matrix = FillMatrixRandomInt(4, 4);
int rowPosition = ReadNumberIntFromConsole("Введите позицию строки: ");
int columnPosition = ReadNumberIntFromConsole("Введите позицию столбца: ");
Console.WriteLine();
PrintMatrix(matrix);
FindPositionInMatrix(matrix, rowPosition, columnPosition);


int ReadNumberIntFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

int[,] FillMatrixRandomInt(int rowsMatrix, int columnsMatrix)
{
    int[,] martixRandom = new int[rowsMatrix, columnsMatrix];
    for (int i = 0; i < rowsMatrix; i++)
    {
        for (int j = 0; j < columnsMatrix; j++)
        {
            martixRandom[i, j] = new Random().Next(1, 99);
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

void FindPositionInMatrix(int[,] findMatrix, int rowNum, int columnNum) // найти как вывести
{
    if (findMatrix.GetLength(0) < rowNum || findMatrix.GetLength(1) < columnNum)
        Console.WriteLine("Такой позиции в массиве нет");
    else
        Console.WriteLine($"На этой позиции число {findMatrix[rowNum - 1, columnNum - 1]}");
}