// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Вариант 1
// Ввод числа из консоли
int ReadData(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine() ?? "0";
    int number = Convert.ToInt32(value);
    return number;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
// Вариант 1
/*{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {arr[i]}");
    }
}*/

// Вариант 2
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Считаем количество положительных элементов в массиве
int CountPositiveNumbers(int[] arr)
{
    int count = 0;
   
    for (int i = 0; i < arr.Length; i++)
    {
        // Проверяем, является ли текущий элемент положительным
        if (arr[i] > 0)
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

int length = ReadData("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
int count = CountPositiveNumbers(array);
PrintResult($"Количество чисел больше 0 = {count}");

// Вариант 2: регулярные выражения

/*using System.Text.RegularExpressions;
Console.Clear();

int numOfKeyPresses = ReadInt("Введите количество нажатий: ");  // Ввод пользователем количества нажатий.
string data = KeyPresses("Введите строку: ", numOfKeyPresses);  // Получение нажатий с клавиатуры.
//Console.WriteLine(data);
int count = CountPositiveNumbers(data);                         // Подсчет положительных чисел в строке.
PrintResult($"\nВведено чисел больше нуля: {count}");           // Вывод результата в консоль.

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Получение нажатий с клавиатуры.
string KeyPresses(string msg, int numOfKeyPresses)
{
    Console.Write(msg);
    string data = string.Empty;
    
    for (int i = 0; i < numOfKeyPresses; i++)
    {
        var keyInfo = Console.ReadKey();
        data += keyInfo.KeyChar;
    }

    return data;
}

// Подсчет положительных чисел в строке с использованием регулярных выражений.
int CountPositiveNumbers(string input)
{
    string pattern = @"[-]?[0-9]+";
    MatchCollection matches = Regex.Matches(input, pattern);

    int count = 0;
    foreach (Match match in matches)
    {
        if (int.Parse(match.Value) > 0) { count++; }
    }
    return count;
}

// Вывод результата в консоль.
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}*/
