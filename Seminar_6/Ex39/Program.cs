﻿// Перевернуть массив
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
PrintArray(array);
ReverseArray(array);
PrintArray(array);
 
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = buf;
    }
}
 
void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1] + "}");
}
