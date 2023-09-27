// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double k1 = ReadData("Введите коэффициент k1: ");
double k2 = ReadData("Введите коэффициент k2: ");
double b1 = ReadData("Введите коэффициент b1: ");
double b2 = ReadData("Введите коэффициент b2: ");
// Поиск координат пересечения
(double x, double y) point = PointOfIntersection(k1, b1, k2, b2);
double X = point.x;
double Y = point.y;
PrintData($"Точка пересечения: x= {X}; y= {Y}");

// Метод считывания введенных данных
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных.\
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Находим точку пересечения
(double x, double y) PointOfIntersection (double k1, double b1, double k2, double b2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (X, Y);
}