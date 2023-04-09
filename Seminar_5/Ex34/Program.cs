// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();

Console.WriteLine("Введите длину массива: ");
int arrayLength = ReadNumberFromConsole();
int[] array = new int[arrayLength];
ArrayFillPrint(array);
Console.WriteLine($"Количество четных чисел в массиве: {ArrayPositive(array)}");

int ReadNumberFromConsole()
{
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

void ArrayFillPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}

int ArrayPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
