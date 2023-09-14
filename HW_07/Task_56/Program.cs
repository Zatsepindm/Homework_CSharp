// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]}  ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] CreateArray2(int[,] array)
{
    int[] matrix = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
        matrix[i] = sum;
    }
    return matrix;
}

void FindMin(int[] array)
{
    int min = array[0];
    int position = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            position = i + 1;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов строки, равная {min}, находится в {position}-й строке массива");
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(rows, cols);
PrintArray(matrix);
FindMin(CreateArray2(matrix));