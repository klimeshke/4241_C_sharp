﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

// for (int i = 1; i < num; i++)
// {
//     int result = i * i;
//     Console.Write($"{result}, ");
// }
// Console.Write($"{num * num}");

for (int i = 1; i < num; i++)
{
    int result = i * i;
    Console.Write(result + ", ");
}
Console.Write($"{num * num} ");