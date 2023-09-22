// No38 Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементом массива.

// Заполняем одномерный массив из вещественных чисел
double[] GenArray(int length, double lowBorder, double highBorder)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (highBorder - lowBorder) + lowBorder;
    }

    return array;
}

// Печатаем результат
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(string.Format("{0:0.00}", arr[i]) + ", ");
    }
    Console.WriteLine(string.Format("{0:0.00}", arr[arr.Length - 1]) + "]");
}

// Находим разницу между максимальным и минимальным элементом массива
double FindDifference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    
    // Перебираем элементы массива и находим максимальный и минимальный элемент
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }

        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    // Возвращаем разницу между максимальным и минимальным элементом массива
    return max - min;
}

double[] array = GenArray(12, -9, 9);
PrintArray(array);

double difference = FindDifference(array);

// Печатаем разницу с 2 знаками после запятой
Console.WriteLine("Разница: " + string.Format("{0:0.00}", difference));