// See https://aka.ms/new-console-template for more information
Console.Clear();

int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма положительных чисел: {CalcSumPositive(array)}, Сумма отрицательных чисел: {CalcSumNegative(array)}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[^1]);
}

int CalcSumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int CalcSumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
