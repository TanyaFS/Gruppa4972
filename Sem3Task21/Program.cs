// No21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// Мое решение вне программы
/*{
    double res = 0;
    result = Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2) + Math.Pow(pointA[1]-pointB[1], 2) + Math.Pow(pointA[2]-pointB[2], 2));
    return res;
}*/


/*using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        // Введите свое решение ниже
        double result = 0;
        result = Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2) + Math.Pow(pointA[1]-pointB[1], 2) + Math.Pow(pointA[2]-pointB[2], 2));
        return result;

    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}*/

// *Осуществить возможность ввода всех точек в одну строку
// *Вывод сообщения и вызов метода DistanceCalculation

double Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";

    string[] valuesArray = values.Split(",");
    int xA = Convert.ToInt32(valuesArray[0]);
    int yA = Convert.ToInt32(valuesArray[1]);
    int zA = Convert.ToInt32(valuesArray[2]);
    int xB = Convert.ToInt32(valuesArray[3]);
    int yB = Convert.ToInt32(valuesArray[4]);
    int zB = Convert.ToInt32(valuesArray[5]);

    return DistanceCalculation(xA, yA, zA, xB, yB, zB);
}


//A (3,6,8); B (2,1,-7)
// Расчёт расстояния
double DistanceCalculation(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2)
                     + Math.Pow(Math.Abs(yA - yB), 2)
                     + Math.Pow(Math.Abs(zA - zB), 2));
}

Console.WriteLine(Prompt("Введите 6 чисел через запятую (xA,yA,zA,xB,yB,zB): "));