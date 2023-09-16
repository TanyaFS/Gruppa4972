// No25 Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Решение
// 2^3=2*2*2=8

long MyPow(int numA, int numB)
{
    long res = 1;
    while (numB > 0)
    {
        res = res * numA;
        numB = numB - 1;
    }

    return res;
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
Console.WriteLine(MyPow(numA, numB));