// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целое положительное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = NumberDegree(numberA, numberB);
Console.WriteLine(result);

int NumberDegree(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA * NumberDegree(numA, numB - 1);
}




/////
// Console.Write("Input a number A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Input a number B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }

//     return result;
// }

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine(exponentiation);