// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , 
// является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

bool ExistTriangle(int x, int y, int z)
{
    bool result = false;
    if (x < y + z && y < x + z && z < x + y)
        result = true;
    return result;
}
int FindPerimetr(int x, int y, int z)
{
    int perim = x + y + z;
    Console.WriteLine($"Периметр треугольника равен {perim}");
    return perim;
}
void FindArea(int x, int y, int z, double per)
{
    double area = Math.Round(Math.Sqrt((per / 2) * (per / 2 - x) * (per / 2 - y) * (per / 2 - z)), 2);
    System.Console.WriteLine($"Площадь треугольника равна {area}");
}
void CheckTriangle(double x, double y, double z)
{
    if (x == y && y == z && x == z)
    {
        System.Console.WriteLine("Треугольник равносторонний");
        System.Console.WriteLine("Значения углов треугольника в градусах равны 60, 60, 60");
    }
    else
    {
        double cosX = (y * y + z * z - x * x) / (2 * y * z);
        double X = Math.Round((Math.Acos(cosX) * 180 / Math.PI));
        double cosY = (x * x + z * z - y * y) / (2 * x * z);
        double Y = Math.Round((Math.Acos(cosY) * 180 / Math.PI));
        double Z = 180 - X - Y;
        if (X == Y || X == Z || Y == Z)
            System.Console.WriteLine("Треугольник равнобедренный");
        else if (X == 90 || Y == 90 || Z == 90)
            System.Console.WriteLine("Треугольник прямоугольный");
        System.Console.WriteLine($"Значения углов треугольника в градусах равны {X}, {Y}, {Z}");
    }
}

System.Console.WriteLine("Введите длину первой стороны треугольника");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длину второй стороны треугольника");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длину третьей стороны треугольника");
int c = Convert.ToInt32(Console.ReadLine());
if (ExistTriangle(a, b, c) == false)
    System.Console.WriteLine("Такой треугольник не существует");
else
{
    int perim = FindPerimetr(a, b, c);
    FindArea(a, b, c, perim);
    CheckTriangle(a, b, c);
}
