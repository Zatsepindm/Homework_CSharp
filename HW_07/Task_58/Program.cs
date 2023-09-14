// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]}\t");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] FindProduct(int[,] array1, int[,] array2)
{
    int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                resultMatrix[i, j] += array1[i, k] * array2[k, j];
    return resultMatrix;
}
int InsertRow()
{
    System.Console.WriteLine("Введите количество строк матрицы:");
    int row = Convert.ToInt32(Console.ReadLine());
    return row;
}
int InsertCol()
{
    System.Console.WriteLine("Введите количество столбцов матрицы:");
    int col = Convert.ToInt32(Console.ReadLine());
    return col;
}

int rows1 = InsertRow();
int cols1 = InsertCol();
System.Console.WriteLine();
int[,] matrix1 = CreateMatrix(rows1, cols1);
PrintMatrix(matrix1);
int rows2 = InsertRow();
int cols2 = InsertCol();
System.Console.WriteLine();
int[,] matrix2 = CreateMatrix(rows2, cols2);
PrintMatrix(matrix2);
if (cols1 != rows2)
{
    System.Console.WriteLine("Такие матрицы перемножить невозможно. Количество столбцов матрицы №1");
    System.Console.WriteLine("должно быть равно количеству строк матрицы №2");
}
else
{
    int[,] matrix3 = FindProduct(matrix1, matrix2);
    System.Console.WriteLine("Произведение введенных матриц равно:");
    PrintMatrix(matrix3);
}