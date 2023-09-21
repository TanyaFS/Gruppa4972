// №35 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,значения которых лежат в отрезке [10,99].

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим количество элементов в заданном диапазоне

// Вариант 1
/*int CountElm(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= x && arr[i] <= y)
        {
            count++;
        }
    }
    return count;
}*/

// Вариант 2
int CountElm(int[] arr, int elm)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(123, 0, 1000);
PrintArray(array);

// Вариант 1
//int x = 10;
//int y = 99;
//int count = CountElm(array, x, y);

// Вариант 2
int elm = new Random().Next(10, 100);
int count = CountElm(array, elm);
PrintResult($"{count} элементов в заданном диапазоне");