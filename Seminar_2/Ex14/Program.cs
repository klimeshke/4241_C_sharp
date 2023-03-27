// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if (num % 7 == 0 && num % 23 == 0) // %% - оператор логического И   || - оператор логического ИЛИ
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно");
}