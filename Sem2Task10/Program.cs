// №10 Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. 

Console.WriteLine("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine()??"0");

char[] digitChar = num.ToString().ToCharArray();

if (num < 1000 && num > 99)
{
    System.Console.Write(digitChar[1]);
}
else
{    
    Console.WriteLine("Число не трехзначное");
}