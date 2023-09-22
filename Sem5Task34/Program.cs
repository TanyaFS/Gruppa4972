// No34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Заполняем одномерный массив
int[] GenArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

// Считаем количество четных элементов в массиве
int CountEvn(int[] arr)
{
    // Инициализируем счетчик четных элементов
    int count = 0;
    // Проходим по массиву
    for (int i = 0; i < arr.Length; i++)
    {
        // Проверяем, является ли текущий элемент четным
        if (arr[i]%2 == 0)
        {
            // Если да, увеличиваем счетчик на 1
            count++;
        }
    }
    // Возвращаем значение счетчика
    return count;
}    

// Выводим сообщение на консоль
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Генерируем массив из 123 случайных чисел
int[] array = GenArray(123);
// Выводим содержимое массива на консоль
PrintArray(array);
// Считаем количество четных элементов в массиве
int count = CountEvn(array);
// Выводим количество четных элементов на консоль
PrintResult($"{count} четных элементов в заданном массиве");