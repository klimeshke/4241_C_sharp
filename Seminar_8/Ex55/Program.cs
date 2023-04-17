/*
    Задача 55: Задайте двумерный массив. Напишите программу,
    которая заменяет строки на столбцы. В случае, если это
    невозможно, программа должна вывести сообщение для
    пользователя.
*/

Console.Clear();
int rows = ReadNumberIntFromConsole("Введите строки: "); ;
int columns = ReadNumberIntFromConsole("Введите столбца: "); ;
int minRandom = -9;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);
PrintArray(mass);

if (rows == columns)
{
    // ReplaceRowsToColumns(mass);
    // PrintArray(mass);
    ReplaceRowsToColumns2(mass);
    PrintArray(mass);
}
else
{
    System.Console.WriteLine("Такой массив заменить строки на столбцы нельзя");
}

void ReplaceRowsToColumns(int[,] array)
{
    int length = array.GetLength(0);

    for (int i = 0; i < length - 1; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }


    }
}

void ReplaceRowsToColumns2(int[,] array)
{
    int length = array.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int ReadNumberIntFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
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

void PrintArray(int[,] PrArray)
{
    for (int i = 0; i < PrArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrArray.GetLength(1); j++)
        {
            Console.Write($"{PrArray[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}