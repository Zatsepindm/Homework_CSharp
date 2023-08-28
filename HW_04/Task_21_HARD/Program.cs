// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

int[] CoorInputA(int A)
{
    int[] array = new int[A];
    for (int i = 0; i < A; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю координату токи А");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] CoorInputB(int B)
{
    int[] array = new int[B];
    for (int i = 0; i < B; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю координату токи B");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
double Dist(int[] X, int[] Y, int Z)
{
    int Sum = 0;
    for (int i = 0; i < Z; i++)
    {
        Sum = Sum + (Y[i] - X[i]) * (Y[i] - X[i]);
    }
    double Distance = Math.Sqrt(Sum);
    return Distance;
}


Console.WriteLine("Введите размерность N N-мерного пространства");
int N = Convert.ToInt32(Console.ReadLine());
int[] CIA = CoorInputA(N);
int[] CIB = CoorInputB(N);
double Length = Dist(CIA, CIB, N);
System.Console.WriteLine($"Расстояние между точками A и B в {N}-мерном пространстве равно: {Length}");

