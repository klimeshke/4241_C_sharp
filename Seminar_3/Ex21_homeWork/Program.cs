// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.WriteLine("введите 1 число координату X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 1 число координату Y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 1 число координату Z: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите 2 число координату X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 2 чесло координату Y: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 2 число координату Z: ");
int z2 = int.Parse(Console.ReadLine()!);

double num = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + 
                                  (y1 - y2) * (y1 - y2) +
                                  (z1 - z2) * (z1 - z2)), 2);

Console.WriteLine($"Растояние между A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {num}");