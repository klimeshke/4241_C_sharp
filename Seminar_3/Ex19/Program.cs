// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int numberFiveDigits = int.Parse(Console.ReadLine()!);

int digitOne = numberFiveDigits / 10000;
int digitTwo = numberFiveDigits / 1000 % 10;
int digitFour = numberFiveDigits / 10 % 10;
int digitFive = numberFiveDigits % 10;

if (digitOne == digitFive && digitTwo == digitFour)
{
    Console.WriteLine("Ура палиндром! ");
}
else
    Console.WriteLine("Нет, не палиндром :( ");