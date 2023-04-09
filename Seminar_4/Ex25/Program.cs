// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.WriteLine("Введите число A: ");
int numA = GetIntInput();
Console.WriteLine("Введите число B: ");
int numB = GetIntInput();
int result = naturalDegree(numA, numB);
Console.WriteLine($"{numA} в сепени {numB} = {result}");

int GetIntInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

int naturalDegree(int firstNum, int secondNum)  // понимаю что функция тут не нужна. отрабатывал передачу переменных из глобальных в фукцию
{
    int degree = firstNum;
    for (int i = 1; i < secondNum; i++)
    {
        degree = degree * firstNum;
    }
    return degree;
}