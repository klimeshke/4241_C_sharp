// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int[] array = new int[4];
ArrayFillPrint(array);
Console.Write(ArraySumOdd(array));


void ArrayFillPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (i != array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "] -> ");
    }
}

int ArraySumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            sum += array[i];
    return sum;
}