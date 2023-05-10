// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = NumberSumm(number);
Console.WriteLine(result);

int NumberSumm(int num)
{
    if (num == 0) return 0;
    else return num % 10 + NumberSumm(num / 10);
}




// Console.WriteLine("Input a number ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = Result(number);
// Console.Write($"{number} -> {result}");

// int Result(int n)
// {
//     if (n == 0) return 0;
//     else
//     {
//         // Result(n - 1);
//         return n % 10 + Result(n / 10);
//     }
// }