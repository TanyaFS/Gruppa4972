// №33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// Вариант 1
// Вывод сообщения и запись введённых данных
/*
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Проверяет, есть ли число
string Check(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return $"Есть, индекс {i}";
    return "Нет";
}

// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}


int[] array = {1, -2, 5, 6, 58, 7, -3, -42, 63, 15};
OutputArray(array);

int element = Prompt("Введите число для поиска: ");

Console.WriteLine(Check(array, element));
*/

// Вариант 2

int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}

int FindElm(int[] arr, int elm)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return i;
        }
    }
    return -1;
}    

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int elm = int.Parse(Console.ReadLine() ?? "0");
    return elm;
}

int[] arr = GenArray(12,-9,9);
Console.WriteLine("Сгенерированный массив:");
PrintArray(arr);
int numberToFind = ReadData("Введите число для поиска: ");
int index = FindElm(arr, numberToFind);
if (index != -1)
{
    Console.WriteLine($"Число {numberToFind} присутствует в массиве на позиции {index}.");
}
else
{
    Console.WriteLine($"Число {numberToFind} отсутствует в массиве.");
}
