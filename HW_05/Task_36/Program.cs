// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
void FindSum (int[] array)
{
    int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
        sum = sum + array[i];
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {sum}");
}


Console.WriteLine("Введите размерность одномерного массива");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    int[] array = new int[N];
    FillArray(array);
    PrintArray(array);
    FindSum(array);
}
else
    System.Console.WriteLine("Введите значение размерности массива больше 0");


