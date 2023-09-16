// No29 Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

// Вызываем метод GenArr для создания массива из 8 случайных чисел
int[] numbers = GenArr(8);
{
    // Формируем строку, объединяя элементы массива через запятую и заключая их в квадратные скобки
    string output = "[" + string.Join(", ", numbers) + "]";

    // Выводим строку на экран
    Console.WriteLine(output);
}   

int[] GenArr(int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0,9); // Генерируем случайное целое число
    }

    return array;
}










