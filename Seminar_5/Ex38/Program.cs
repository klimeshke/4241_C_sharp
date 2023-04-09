// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
// Основной код
double[] array = { 3, 7, 22, 2, 78 };
ArrayPrint(array);
Console.Write($"{ArrayMax(array) - ArrayMin(array)}");
// Функция поиска максимального значения в массиве V
double ArrayMax(double[] array)
{
    double maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxArray < array[i])
            maxArray = array[i];
    }
    return maxArray;
}
// Функция поиска минимального значения в массиве V
double ArrayMin(double[] array)
{
    double minArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minArray > array[i])
            minArray = array[i];
    }
    return minArray;
}
// Функция вывода в консоль массива V
void ArrayPrint(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + " -> ");
    }
}