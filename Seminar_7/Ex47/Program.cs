// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int rows = Convert.ToInt32(ReadNumberDoubleFromConsole("Введите m - количество строк: "));
int columns = Convert.ToInt32(ReadNumberDoubleFromConsole("Введите m - количество строк: "));
double[,] matrix = FillMatrixRandomDouble(rows, columns);
PrintMatrix(matrix);

double ReadNumberDoubleFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return double.Parse(input);
}

double[,] FillMatrixRandomDouble(int rowsMatrix, int columnsMatrix)
{
    double[,] martixRandom = new double[rowsMatrix, columnsMatrix];
    for (int i = 0; i < rowsMatrix; i++)
    {
        for (int j = 0; j < columnsMatrix; j++)
        {
            martixRandom[i, j] = Math.Round(new Random().NextDouble() * 10 - 5, 1);
        }
    }
    return martixRandom;
}

void PrintMatrix(double[,] matrix)
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