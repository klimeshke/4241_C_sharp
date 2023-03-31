/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Clear();

Console.WriteLine("Введите трёхзначтное число: ");
int number = int.Parse(Console.ReadLine()!);

while (number > 1000)
{
    number = number / 10;
}

if (number < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра --> {number % 10}");
}
