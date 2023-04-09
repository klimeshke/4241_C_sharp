// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();

Console.WriteLine("Введите число N: ");
int numN = GetIntInput();
int product = GetProdNum(numN);
Console.WriteLine($"Произведение чисел от 1 до N = {product}");


int GetIntInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

int GetProdNum(int n)
{
    int amountN = 1;
    for (int i = 1; i <= n; i++)
    {
        amountN = amountN * i;
    }
    return amountN;
}


