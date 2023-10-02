// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Рекурсивно генерируем строку, состоящую из чисел от N до 1.
void GenLineRec(int num)
{
    Console.Write(num+" ");
    if (num <= 1)
    {
    }
    else
    {
        GenLineRec(num-1);
    }
}

// Считываем число N из консоли
int num = ReadData("Введите число N: ");
// Генерируем строку, состоящую из чисел от N до 1
GenLineRec(num);
Console.WriteLine();