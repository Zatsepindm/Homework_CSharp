// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum(int n)
{
    int Sumdigits = 0;
    if (n < 0)
        n = n * -1;
    while (n > 0)
    {
        Sumdigits = Sumdigits + n % 10;
        n = n / 10;
    }
    System.Console.WriteLine($"Сумма цифр введенного числа = {Sumdigits}");
}

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Sum(N);