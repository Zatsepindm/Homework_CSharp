// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число"); 
int num = Convert.ToInt32( Console.ReadLine() );
int n = 0;
int digit_2 = 0;
int num1 = num;
while (num1 % 10 > 0)
{
    num1 = num1 / 10;
    n = n + 1;
}
if (n == 3)
{
    num = num / 10;
    digit_2 = num % 10;
    Console.WriteLine($"Вторая цифра введенного числа = {digit_2}");
}
else
    Console.WriteLine("Введенное число не является трехзначным. Введите трехзначное число");