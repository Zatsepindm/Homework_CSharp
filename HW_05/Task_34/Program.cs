// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void FindHonest(int[] array)
{
    int NumHonest = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
            NumHonest++;
    }
    System.Console.WriteLine($"Количество четных чисел в массиве равно {NumHonest}");
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}


Console.WriteLine("Введите размерность одномерного массива");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
int[] array = new int[N];
FillArray(array);
PrintArray(array);
FindHonest(array);
}
else
System.Console.WriteLine("Введите значение размерности массива больше 0");