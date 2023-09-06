// №2 Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()??"0");

int max = num1;

if (num1 > num2)
{
    Console.Write("max = ");
    Console.WriteLine(max = num1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(max = num2); 
}