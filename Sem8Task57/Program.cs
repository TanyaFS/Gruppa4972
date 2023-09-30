// №57 Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.

// Вариант 1
// Вывод сообщения и запись введённых данных
/*int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void IntRandom2DArray(int[,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minElement, maxElement + 1);
}
// Ищет частоту появления чисел в массиве
Dictionary<int, int> Frequency(int[,] array)
{
    // Частотный словарь (ключ - элемент массива, значение - количество таких же элементов)
    Dictionary<int, int> freqDict = new Dictionary<int, int>();

    // Перебор элементов массива и проверка наличия значения в словаре
    foreach (int value in array)
    {
        if (freqDict.ContainsKey(value))
            freqDict[value]++;
        else
            freqDict.Add(value, 1);
    }

    return freqDict;
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine();
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}
// Выводит словарь в консоль
void OutputFrequencyDictionary(Dictionary<int, int> freqDict, string message)
{
    Console.WriteLine();
    Console.WriteLine(message);

    foreach(KeyValuePair<int,int> pair in freqDict)
    {
        Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
}

// Получение данных от пользователя
int m = Prompt("Введите количество столбцов в массиве: ");
int n = Prompt("Введите количество строк в массиве: ");
// Границы для случайного заполнения массива 
int minElement = 0;
int maxElement = 10;

int[,] array = new int[n, m];
IntRandom2DArray(array, minElement, maxElement); // Заполнение массива

Dictionary<int, int> freqDict = Frequency(array); // Заполнение словаря

Output2DArray(array, "Массив: "); // Вывод массива
OutputFrequencyDictionary(freqDict, "Частотный словарь: "); // Вывод словаря*/

// Вариант 2 (с доски)
using System.Collections.Generic;

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

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

/*void Print1DArray(int[] array1D)
{
    for (int i = 0; i < array1D.Length; i++)
    {
        Console.Write(array1D[i] + "\t");
    }
}*/

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int [] FreqDic(int[,] arr, int length)
{
    int[] dic = new int[length];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           dic[arr[i, j]]++;
        }
    }

    return dic;
}

int[,] arr2D = Fill2DArray(3,4,10,0);
Print2DArray(arr2D);
int[] freqDic = FreqDic(arr2D, 11);
Print1DArray(freqDic);
Console.WriteLine();