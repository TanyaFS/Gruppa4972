// №13 Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет. 

void Variant1()
{
    Console.WriteLine("Способ 1");
    Console.WriteLine("Введите число: ");

    int num = int.Parse(Console.ReadLine() ?? "0");
    char[] digitChar = num.ToString().ToCharArray();

    if (num > 99)
    {
        Console.WriteLine(digitChar[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Variant1();

void Variant2()
{
    Console.WriteLine("Способ 2");
    Console.WriteLine("Введите число: ");
    // Чтение возможного большого значения из консоли
    long num = long.Parse(Console.ReadLine() ?? "0");
    // Вычесление длины числа
    double numLen = Math.Floor(Math.Log10(num)+1);
    // Переменная для вычисления позиции
    int position = (int)numLen - 3;

    if (num > 99)
    {
        // Вычисление позиции нужной цифры
        long result = (num / (int)Math.Pow(10, position) % 10);
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Variant2();