// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 100;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(array[i], 2);
}
void PrintArray(double[] array)
{
    foreach (double item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
void FindDiff(double[] array)
{
    double digitmax = array[0];
    double digitmin = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > digitmax)
            digitmax = array[i];
        else if (array[i] < digitmin)
            digitmin = array[i];
    }
    diff = digitmax - digitmin;
    diff = Math.Round(diff, 2);
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diff}");

}

Console.WriteLine("Введите размерность одномерного массива");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    double[] array = new double[N];
    FillArray(array);
    PrintArray(array);
    FindDiff(array);
}
else
    System.Console.WriteLine("Введите значение размерности массива больше 0");