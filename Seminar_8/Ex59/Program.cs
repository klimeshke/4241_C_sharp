// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Clear();
int rows = 4;
int columns = 4;
int minRandom = 1;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);
PrintMatrix(mass);
Console.WriteLine();
int[] massiveIdexesMinElem = MatrixMinElemIndexes(mass);
PrintArray(massiveIdexesMinElem);
int[,] resultMatrix = RemoveMinRowColumn(mass, massiveIdexesMinElem[0], massiveIdexesMinElem[1]);
Console.WriteLine();
PrintMatrix(resultMatrix);


int[,] RemoveMinRowColumn(int[,] matrix, int minRow, int minColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == minRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == minColumn) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[] MatrixMinElemIndexes(int[,] array)
{
    int rowMinElem = 0;
    int columnMinElem = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[rowMinElem, columnMinElem])
            {
                rowMinElem = i;
                columnMinElem = j;
            }
        }
    }
    return new int[] { rowMinElem, columnMinElem };
}

int[,] FillArrayRandomInt(int rowsArray, int columnsArray, int min, int max)
{
    int[,] arrayRandom = new int[rowsArray, columnsArray];
    for (int i = 0; i < rowsArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arrayRandom[i, j] = new Random().Next(min, max);
        }
    }
    return arrayRandom;
}

void PrintMatrix(int[,] prMatrix)
{
    for (int i = 0; i < prMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < prMatrix.GetLength(1); j++)
        {
            Console.Write($"{prMatrix[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[] prArray)
{
    for (int i = 0; i < prArray.Length; i++)
    {
        Console.Write($"{prArray[i]} ");
    }
}