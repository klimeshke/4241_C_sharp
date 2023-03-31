// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// sqrt((x1-x2)^2 + (y1-y2)^2)

// double answer = Math.Sqrt(100);
// double sqr = Math.Pow(100, 3);
// Console.WriteLine(sqr);
Console.Clear();

Console.WriteLine("введите 1 число координату X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 1 число координату Y: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите 2 число координату X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 2 чесло координату Y: ");
int y2 = int.Parse(Console.ReadLine()!);

double num = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), 3);

Console.WriteLine($"Растояние между A({x1},{y1}); B({x2},{y2}) -> {num}");