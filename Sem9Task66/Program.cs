// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вычисляем сумму натуральных элементов в промежутке от M до N
int SumElements(int m, int n)
{
    if (m == n)
    {
        return n;
    }

    return m + SumElements(m + 1, n);
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int sum = SumElements(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}");
