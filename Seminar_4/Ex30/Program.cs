// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке
Console.Clear();

int[] array = new int[8];
ArrayFillPrint(array);

void ArrayFillPrint(int[] collect)
{
    for (int i = 0; i < collect.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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
