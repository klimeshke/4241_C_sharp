// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();

Console.WriteLine("Введите число: ");
int num = GetIntInput();
int sum = GetSumNum(num);



int GetIntInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

int GetSumNum(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value = value / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр числа {num} = {sum}");