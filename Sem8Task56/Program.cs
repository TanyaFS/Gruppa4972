// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Печатаем массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод для нахождения номера строки с наименьшей суммой элементов
int MinSumRaw(int[,] arr)
{
    int outN = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumRaw = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRaw = sumRaw + arr[i, j];
        }

        if (sumRaw < sum)
        {
            sum = sumRaw;
            outN = i;
        }
    }

    return outN;
}


int[,] arr2D = Fill2DArray(3,4,10,0);
Print2DArray(arr2D);
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumRaw(arr2D) + 1}");