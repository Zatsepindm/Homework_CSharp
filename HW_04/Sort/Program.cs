// SORT Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами от -100 до 100, выводится на экран. Сортируется, и затем опять выводится на экран.

int[] MakeArray(int X)
{
    int[] array = new int[X];
    for (int i = 0; i < X; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}
void Printarray(int[] A, int Y)
{
    for (int i = 0; i < Y; i++)
    {
        System.Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}
void Sort(int[] B, int Y)
{
    for (int i = 0; i < Y - 1; i++)
    {
        int max = i;
        for (int j = i + 1; j < Y; j++)
        {
            if (B[j] > B[max])
                max = j;
        }
        int temp = B[i];
        B[i] = B[max];
        B[max] = temp;
    }
}

Console.WriteLine("Введите размерность N массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = MakeArray(N);
Printarray(arr, N);
Sort(arr, N);
Printarray(arr, N);
