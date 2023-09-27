// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

System.Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
