// Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
// Пример: для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]

int[] FibonachiArray(int k)
{
    int N = 2 * k + 1;
    int[] array = new int[N];
    array[array.Length / 2] = 0;
    array[array.Length / 2 + 1] = 1;
    array[array.Length / 2 - 1] = 1;
    for (int i = array.Length / 2 + 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    for (int i = array.Length / 2 - 2; i >= 0; i--)
    {
        array[i] = array[i + 2] - array[i + 1];
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
}

System.Console.WriteLine("Введите значение числа k для составления списка чисел Фибоначчи");
int k = Convert.ToInt32(Console.ReadLine());

int[] array = FibonachiArray(k);
PrintArray(array);
