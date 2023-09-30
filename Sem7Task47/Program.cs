// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;

public class Answer {
    public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
        // Введите свое решение ниже
        System.Random rnd = new System.Random();
        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                //  matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
                double randomNumber = minLimitRandom + rnd.NextDouble() * (maxLimitRandom - minLimitRandom);
                array[i,j] = randomNumber;
            }
        }

        return array;
    }

    public static void PrintArray(double[, ] matrix) {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               // Console.Write($"{matrix[i, j]:f2}\t");
                Console.Write("{0:f1}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }
   
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int m, n, minLimitRandom, maxLimitRandom;

        if (args.Length >= 4) {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
            minLimitRandom = int.Parse(args[2]);
            maxLimitRandom = int.Parse(args[3]);

            double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

            // Выберем случайные индексы трех элементов матрицы array
            int row1 = new Random().Next(0, m);
            int col1 = new Random().Next(0, n);
            int row2 = new Random().Next(0, m);
            int col2 = new Random().Next(0, n);
            int row3 = new Random().Next(0, m);
            int col3 = new Random().Next(0, n);

            // Проверяем, являются ли выбранные элементы дробными числами
            bool isFractional1 = (array[row1, col1] % 1) != 0;
            bool isFractional2 = (array[row2, col2] % 1) != 0;
            bool isFractional3 = (array[row3, col3] % 1) != 0;

            // Если два из трех элементов не являются дробными числами, то бросаем исключение
            if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
            {
                Console.WriteLine("Все ок!");
            }
            else
            {
                throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
            }
        } else {
            m = 3;
            n = 4;
            minLimitRandom = -10;
            maxLimitRandom = 10;
      
            double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintArray(result);
        }
    }
}

//  * При выводе матрицы показывать каждую цифру разного цвета. Вывод числа ограничить до 2 знака после запятой.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countColumn = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
double[,] matrix = CreateRandomMatrix(countRow, countColumn, minValue, maxValue);
PrintMatrix(matrix);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными вещественными значениями.
double[,] CreateRandomMatrix(int countRow, int countColumn, int minValue, int maxValue)
{
    Random random = new Random();
    double[,] matrix = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = (maxValue - minValue) * random.NextDouble() + minValue;
        }
    }
    return matrix;
}
// Вывод двумерного массива на экран.
void PrintMatrix(double[,] matrix)
{
    int countRow = matrix.GetLength(0);
    int countColumn = matrix.GetLength(1);

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            string formattedNumber = matrix[i, j].ToString("0.00");
            DisplayColoredText(formattedNumber);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

// Вывод каждого символа случайным цветом.
void DisplayColoredText(string text)
{
    foreach (char c in text)
    {
        ConsoleColor randomColor;

        // Символы, отличные от цифр оставляем белыми.
        if (Char.IsDigit(c)) { randomColor = GetRandomConsoleColor(); }
        else { randomColor = ConsoleColor.White; }

        Console.ForegroundColor = randomColor;
        Console.Write(c);
        Console.ResetColor();
    }
}

// Получение случайного цвета для текста.
ConsoleColor GetRandomConsoleColor()
{
    Random random = new Random();
    ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
    return colors[new Random().Next(colors.Length)];
}

/*// * При выводе матрицы показывать каждую цифру разного цвета. Вывод числа ограничить до 2 знака после запятой.

Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countColumn = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
double[,] matrix = CreateRandomMatrix(countRow, countColumn, minValue, maxValue);
PrintMatrix(matrix);

// Методы:
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными вещественными значениями.
double[,] CreateRandomMatrix(int countRow, int countColumn, int minValue, int maxValue)
{
    Random random = new Random();
    double[,] matrix = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = (maxValue - minValue) * random.NextDouble() + minValue;
        }
    }
    return matrix;
}
// Вывод двумерного массива на экран.
void PrintMatrix(double[,] matrix)
{
    int countRow = matrix.GetLength(0);
    int countColumn = matrix.GetLength(1);

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            string formattedNumber = matrix[i, j].ToString("0.00");
            DisplayColoredText(formattedNumber);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

// Вывод каждого символа случайным цветом.
void DisplayColoredText(string text)
{
    foreach (char c in text)
    {
        ConsoleColor randomColor;

        // Символы, отличные от цифр оставляем белыми.
        if (Char.IsDigit(c)) { randomColor = GetRandomConsoleColor(); }
        else { randomColor = ConsoleColor.White; }

        Console.ForegroundColor = randomColor;
        Console.Write(c);
        Console.ResetColor();
    }
}

// Получение случайного цвета для текста.
ConsoleColor GetRandomConsoleColor()
{
    Random random = new Random();
    ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
    return colors[new Random().Next(colors.Length)];
}*/