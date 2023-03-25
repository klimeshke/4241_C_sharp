// Напишите программу, которая на вход принимает число и выдаёт, является ли оно четным
Console.Clear();

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num % 2 == 0)
    Console.WriteLine("Число четное!");
else
    Console.WriteLine("Число НЕчетное!");
