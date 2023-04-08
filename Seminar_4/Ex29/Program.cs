// Задача 29: Напишите программу, которая приниматет на вход длину массива,
// минимальное значение массива и максимальное значение массива,
// создаёт массив с заданными параметрами и выводит значения на экран

// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]
Console.Clear();

Console.WriteLine("Длину массива: ");
int arrayLength = GetIntInput();
Console.WriteLine("Введите минимальное значение массива: ");
int arrayMin = GetIntInput();
Console.WriteLine("Введите максимальное значение массива: ");
int arrayMax = GetIntInput();
int[] array = new int[arrayLength];
ArrayFillPrint(array);

int GetIntInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

void ArrayFillPrint(int[] collect)
{
    for (int i = 0; i < collect.Length; i++)
    {
        array[i] = new Random().Next(arrayMin, arrayMax + 1);
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