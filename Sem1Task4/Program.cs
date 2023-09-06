// №4 Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int num3 = int.Parse(Console.ReadLine()??"0");

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine(max);