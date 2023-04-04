// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();

Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Таблица кубов чисел от 1 до {numberN}");
for (int i = 1; i < numberN; i++)
{
    double result = Math.Pow(i, 3);
    Console.Write(result + ", ");
}
Console.Write(Math.Pow(numberN, 3));