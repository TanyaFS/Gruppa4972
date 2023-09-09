// №15 Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным. 

void Variant1()
{
    Console.WriteLine("Способ 1");
    int day = int.Parse(Console.ReadLine() ?? "0");

    string[] dayOfWeek = new string[7];

    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    }
    else if (day > 7)
    {
        Console.WriteLine("Число выходит за пределы возможного");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Variant1(); 

void Variant2()
{
    Console.WriteLine("Способ 2");
    int day = int.Parse(Console.ReadLine() ?? "0");
    
    var days = new Dictionary<int, string>()
    {
        [1] = "Понедельник",
        [2] = "Вторник",
        [3] = "Среда",
        [4] = "Четверг",
        [5] = "Пятница",
        [6] = "Суббота",
        [7] = "Воскресенье",
    };
    
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да, {0}", days[day]);
    }
    else if (day > 7)
    {
        Console.WriteLine("Число выходит за пределы возможного");
    }
    else
    {
        Console.WriteLine("Нет, это {0}", days[day]);
    }
    
}
Variant2(); 