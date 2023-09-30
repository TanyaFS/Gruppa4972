// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Вводим данные
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
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

// Метод для сортировки элементов каждой строки двумерного массива по убыванию
void SortArr(int[,] arr)
{
    // Перебираем строки массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Создаем временный массив для хранения элементов строки
        int[] buf = new int[arr.GetLength(1)];
        // Копируем элементы текущей строки во временный массив
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf[j] = arr[i, j];
        }
        
        // Сортируем элементы временного массива по возрастанию
        Array.Sort(buf);
        // Разворачиваем массив, чтобы элементы стали упорядочены по убыванию
        Array.Reverse(buf);
        
        // Копируем отсортированные элементы обратно в исходную строку массива
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = buf[j];
        }
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row,column,10,0);
Print2DArray(arr2D);
SortArr(arr2D);
Console.WriteLine("---------------------");
Print2DArray(arr2D);