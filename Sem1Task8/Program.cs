// №8 Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

int N = int.Parse(Console.ReadLine()??"0");
int i = 0;

while (i <= N)
{
    Console.WriteLine(i);
    i = i + 2;
}