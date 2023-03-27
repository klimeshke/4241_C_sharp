/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
Если второе число не кратно превому числу, то программа выводит остаток от деления. */

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток от деления {num1 % num2}");
}