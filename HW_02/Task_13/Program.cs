// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число"); 
int num = Convert.ToInt32( Console.ReadLine() );
int n = 0;
int digit_3 = 0;
int num1 = num;
while (num1 % 10 > 0)
{
    num1 = num1 / 10;
    n = n + 1;
}
if (n >= 3)
{
    while (n > 3)
    {
        num = num / 10;
        n = n - 1;
    }
    digit_3 = num % 10;
    Console.WriteLine($"Третья цифра введенного числа = {digit_3}");
}
else
    Console.WriteLine("Третьй цифры нет. Введите число с количеством разрядов не менее трех");