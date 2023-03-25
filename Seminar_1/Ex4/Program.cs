// Напишите программу, которая принимает на вход  три числа и выдаёт максимальное из этих чисел
Console.Clear();

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число: ");
int numC = int.Parse(Console.ReadLine() ?? "");

int max = numA;

if (max < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}

Console.WriteLine($"{max} большее из чисел");