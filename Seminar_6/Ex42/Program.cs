// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
Console.Clear();
 
int decNumber = ReadNumberFromConsole("Введите десятичное число");
Console.WriteLine(DecToInt(decNumber));
 
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = buf;
    }
}
 
void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1] + "}");
}
 
int ReadNumberFromConsole(string message = "")
{
    if (message != "")
        Console.WriteLine(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}
 
bool IsTriangleExists(int a, int b, int c)
{
    if (a + b < c || b + c < a || c + a < b)
        return false;
    else
        return true;
 
    // if (a + b < c)
    //     return false;
    // else if (b + c < a)
    //     return false;
    // else if (c + a < b)
    //     return false;
    // else
    //     return true;
}
 
string DecToInt(int decimalNumber)
{
    string result = string.Empty; // тоже самое, что и ""
    while (decimalNumber > 0)
    {
        result = $"{decimalNumber % 2}" + result;
        decimalNumber /= 2;
    }
 
    return result;
}