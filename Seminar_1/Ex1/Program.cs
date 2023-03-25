// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.Clear();

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");
//double check = (num2 * num2);

//if (check == num1)
if (num1 == num2 * num2)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}