// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.
Console.Clear();
 
int[] array = new int[] {1,2,3,4,5,6,7,8,0};
PrintArray(array);
int[] newArray = CorrectCopyAndIncrementArray(array);
PrintArray(newArray);
PrintArray(array);
 
 
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
 
int[] WrongCopyAndIncrementArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] + 1;
    }
    return array;
}
 
int[] CorrectCopyAndIncrementArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] + 1;
    }
    return newArray;
}