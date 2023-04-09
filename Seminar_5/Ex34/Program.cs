// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
// Основной код
Console.WriteLine("Введите длину массива: ");
int arrayLength = ReadNumberFromConsole();
int[] array = new int[arrayLength];
ArrayFillPrint(array);
Console.WriteLine($"Количество четных чисел в массиве: {ArrayPositiveCount(array)}");
// Функция считывания с консоли V
int ReadNumberFromConsole()
{
    string input = Console.ReadLine()!;
    return int.Parse(input);
}
// Функция заполнения и вывода в консоль массива V
void ArrayFillPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i != array.Length - 1)
            Console.Write(array[i] + ", ");
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}
// Фунция подсчёта количества положительных чисел в массиве V
int ArrayPositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
