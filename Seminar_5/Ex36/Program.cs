// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
// Основной код
int[] array = new int[4];
ArrayFillPrint(array);
Console.Write(ArraySumOddPosition(array));
// Функция заполнения и вывода в консоль массива V
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
// Функция суммы значений элементов на нечётных позициях массива V
int ArraySumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}