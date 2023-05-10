// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
IntCheck(num);

NaturalNumbers(num);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    else if (num < 0)
    {
        Console.WriteLine("Это не натуральное число");
        //break;
    }
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

int IntCheck(int num)
{
    num = 0;
    while (num < 0)
    {
        Console.WriteLine("Это не целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}