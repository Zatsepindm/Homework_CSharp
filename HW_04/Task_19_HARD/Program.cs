// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

int FindSize(int X)
{
    int size = 0;
    while (X > 0)
    {
        X = X / 10;
        size++;
    }
    return size;
}
int[] MakeArrayRev(int Z, int Y)
{
    int[] array1 = new int[Y];
    for (int i = 0; i < Y; i++)
    {
        array1[i] = Z % 10;
        Z = Z / 10;
    }
    return array1;
}
int[] MakeArrayStr(int[] A, int Y)
{
    int[] array2 = new int[Y];
    for (int i = 0; i < Y; i++)
    {
        array2[i] = A[Y - 1 - i];
    }
    return array2;
}
void FindDiffer(int[] A, int[] B, int Y)
{
    int i = 0;
    int count = 0;
    while (i < Y)
    {
        if (A[i] == B[i])
        {
            count++;
        }
        i++;
    }
    if (count == Y)
        System.Console.WriteLine($"Число является палиндромом");
    else
        System.Console.WriteLine($"Число не является палиндромом");
}

Console.WriteLine("Введите целое число любой разрядности");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
    System.Console.WriteLine($"Число не является палиндромом");
else if (N >= 0 && N <= 9)
    System.Console.WriteLine($"Число является палиндромом");
else
{
    int FS = FindSize(N);
    int[] MAR = MakeArrayRev(N, FS);
    int[] MAS = MakeArrayStr(MAR, FS);
    FindDiffer(MAR, MAS, FS);
}
