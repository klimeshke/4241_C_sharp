// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();

int[] array = { 6, 7, 19, 345, 3 };
Console.WriteLine("Введите искомое число: ");
int number = ReadNumberFromConsole();
Console.Write(number + "; ");
ArrayPrint(array);
bool result = FindNumberInArray(array, number);

if (FindNumberInArray(array, number) == true)
    Console.Write(" -> Да");
else
    Console.Write(" -> Нет");

bool FindNumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}
int ReadNumberFromConsole()
{
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

void ArrayPrint(int[] array)
{
    Console.Write("массив [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i] + "]");
        }
    }
}