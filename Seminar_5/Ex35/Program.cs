// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] array = new int[123];
FillArray(array, 1, 300);
PrintArray(array);
int count = CountNumbersInRange(array, 10, 99);
Console.WriteLine($"Количество чисел: {count}");


void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1); // тут прередаются значения из вызова фунции
    }
}

int CountNumbersInRange(int[] array, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min <= array[i] && array[i] <= max)
        {
            counter++;
        }
    }
    return counter;
}