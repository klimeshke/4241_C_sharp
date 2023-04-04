// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до (А)
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
// <тип_возращаемого_значения> <название_функции>(<параметры>)
// {
//
// }

Console.WriteLine("Введите число A");
int inputInt = GetIntInput();
int sum = SumFrom1ToA(inputInt);
Console.WriteLine(sum);
 
 
 
int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
 
int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}

