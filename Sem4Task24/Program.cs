// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// *Измерить скорость выполнения алгоритма

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//1) вводим число от пользователя -> ReadData
//2) вычисляем сумму -> ?
//3) выводим результат -> PrintResult

// 1-5 1+2+3+4+5=

//Вариант решения 1
int SimpleSum(int numA)
{
    int sumOfNumber = 0;
    for (int i = 1; i <= numA; i++)
    {
        //sumOfNumber = sumOfNumber + i;
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

//Вариант решения 2 - по формуле Гаусса
int GausseSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber=(numA*(numA+1))/2;
    return sumOfNumber;
}

int numberA = ReadData("Введите число A: ");

//Скорость выполнения решения 1
DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now-d1);

//Скорость выполнения решения 2
DateTime d2 = DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма чисел от 1 до "+ numberA + " (простой)равна " + res1);
PrintResult("Сумма чисел от 1 до "+ numberA + " (Гаусса)равна " + res2);
