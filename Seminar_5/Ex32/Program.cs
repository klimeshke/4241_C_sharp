// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();

int[] array = {-4, -8, 8, 2};
ArrayPrint(array);
Console.Write(" --> ");
// ArrayChangeSymbol(array[0], array[1], array[2], array[3]);
ArrayChangeSymbol(array);
ArrayPrint(array);

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}

void ArrayChangeSymbol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
