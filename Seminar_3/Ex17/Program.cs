// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и  выдаёт номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введтие координату X:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введтие координату Y:");
int y = int.Parse(Console.ReadLine()!);
 
if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Четверть 1");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("Четверть 2");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("Четверть 3");
    }
    else if(x > 0 && y < 0)
    {
        Console.WriteLine("Четверть 4");
    }
}
else
{
    Console.WriteLine("X или Y равны нулю!");
}