// Задача №42 Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

//Вариант 1
string DecToBin(int num)
{
    string line ="";
    while(num>0)
    {
        line = num%2+line;
        num=num/2;
    }
    return line;
}

// Вариант 2: Переводит число в двоичное, используя рекурсию
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
}

// Вариант 3: готовая функция в c#
//String bin = Convert.ToString(a, 2);
//String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);

int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
Console.WriteLine();
Console.Write($"Двоичное представление числа(Recurent): {DecToBinRec(number)}");
Console.WriteLine();
Console.WriteLine( Convert.ToString(number, 2));
Console.WriteLine( Convert.ToString(number, 8));
Console.WriteLine( Convert.ToString(number, 16));
