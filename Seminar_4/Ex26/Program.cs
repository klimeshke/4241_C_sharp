// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();

Console.WriteLine("Введите число: ");
int inputInt = GetIntInput();
int count = HowMuchNum(inputInt);
Console.WriteLine($"В числе {inputInt} количество цифр {count}");

int GetIntInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

int HowMuchNum(int a)
{
    int countReturn = 0;
    while (a > 0)
    {
        a /= 10;
        countReturn++;
    }
    return countReturn;

}