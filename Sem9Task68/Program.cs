// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// A(0, n) = n + 1
// A(m, 0) = A(m - 1, 1)
// A(m, n) = A(m - 1, A(m, n - 1))
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }

    return 0;
}


int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int res = Ackerman(m, n);
Console.WriteLine($"A(m,n) = {res}");
