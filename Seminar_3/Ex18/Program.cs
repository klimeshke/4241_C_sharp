// Напишите программу, которая по заданному номеру четверти
// выводит диапазон значерний Х У
Console.Clear();

Console.WriteLine("Введите номер четверти:");
int part = int.Parse(Console.ReadLine()!);

if (part == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (part == 2)
{
    Console.WriteLine("X > 0, Y < 0");
}
else if (part == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (part == 4)
{
    Console.WriteLine("X < 0, Y > 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}