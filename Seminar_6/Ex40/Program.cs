// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
 
int a = ReadNumberFromConsole("Введите длину стороны A");
int b = ReadNumberFromConsole("Введите длину стороны B");
int c = ReadNumberFromConsole("Введите длину стороны C");
 
bool isTriagleExists = IsTriangleExists(a,b,c);
if (isTriagleExists)
    Console.WriteLine("Треугольник существует");
else
    Console.WriteLine("Треугольник не существует");
 
 
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
