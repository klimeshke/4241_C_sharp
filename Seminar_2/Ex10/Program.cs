/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

Console.WriteLine("Введите трёхзначтное число: ");
int number = int.Parse(Console.ReadLine()!);

while (number > 100) // > 100 т.к. для вычисления 2й цифры нам тоже нужно / 10
{
    number = number / 10;
}
int num2 = number % 10;
    
Console.WriteLine($"Вторая цифра {num2}");
