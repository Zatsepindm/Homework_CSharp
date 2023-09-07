// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-е число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    System.Console.WriteLine($"Количество чисел, больших 0, равно {count}");
}

System.Console.WriteLine("Какое количество чисел вы хотите ввести?");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
    System.Console.WriteLine("Введите любое число больше 0");
else
{
    int[] array = new int[n];
    FillArray(array);
    FindPositiveNumbers(array);
}