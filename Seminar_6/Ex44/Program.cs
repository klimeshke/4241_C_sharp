// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
 
Console.Clear();
 
int n = ReadNumberFromConsole("Введите сколько чисел фибоначи надо вывести");
int[] fibArray = GetFibNumbers(n);
PrintArray(fibArray);
 
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
    string input = Console.ReadLine();
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
 
int[] GetFibNumbers(int n)
{
    int[] result = new int[n];
    if (n >= 2)
        result[1] = 1;
 
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}