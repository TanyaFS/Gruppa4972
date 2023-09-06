//Напишите программу, которая будет выдавать
//название дня недели по заданному номеру

int day = int.Parse(Console.ReadLine()??"0");

string[] dayOfWeek = new string[7];

dayOfWeek[0]="Понедельник";
dayOfWeek[1]="Вторник";
dayOfWeek[2]="Среда";
dayOfWeek[3]="Четверг";
dayOfWeek[4]="Пятница";
dayOfWeek[5]="Суббота";
dayOfWeek[6]="Воскресенье";

Console.WriteLine(dayOfWeek[day-1]);

// Решение 2:
// switch (day)