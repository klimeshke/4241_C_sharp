﻿﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
  if (numberM < numberN)
  {
    Console.WriteLine(FindSumNaturalNumbers(numberM, numberN));
  }
  else if (numberM > numberN)
  {
    Console.WriteLine(FindSumNaturalNumbers(numberN, numberM));
  }
  else
  {
    Console.WriteLine($"Числа M и N равны!");
  }
}
else
{
  Console.WriteLine("Вы ввели не натуральное число!");
}

int FindSumNaturalNumbers(int m, int n)
{

  if (m == n) return m;
  else return m + FindSumNaturalNumbers(m + 1, n);
}