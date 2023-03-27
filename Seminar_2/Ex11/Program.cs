Console.Clear();

int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int firstNum = num / 100;
int thirdNum = num % 10;

int result = firstNum * 10 + thirdNum;
Console.WriteLine($"Число {result}");

// Console.WriteLine($"Число {firstNum}{thirdNum}");