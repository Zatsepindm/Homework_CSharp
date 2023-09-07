// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCrossLine(double p1, double d1, double p2, double d2)
{
    double x;
    double y;
    x = (d2 - d1) / (p1 - p2);
    x = Math.Round(x, 2);
    y = p2 * x + d2;
    y = Math.Round(y, 2);
    System.Console.WriteLine($"Координаты точки пересечения прямых ({x}, {y})");
}

System.Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
    System.Console.WriteLine("Прямые параллельны");
else
    FindCrossLine(k1, b1, k2, b2);