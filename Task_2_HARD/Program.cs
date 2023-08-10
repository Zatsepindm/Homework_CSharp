// Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

Console.WriteLine("Введите целое или дробное число"); 
decimal num = Convert.ToDecimal( Console.ReadLine() );
int count1 = 0;
int count2 = -1;
int num1 = (int)num;
if ( num1 > 0)
{
    while (num1 % 10 > 0)
    {
        num1 = num1 / 10;
        count1 = count1 + 1;
    }
}
else
    count1 = 1;
if (num == 0)
    count2 = 0;
else
{
    while ( num % 10 > 0 )
    {
        num = num * 10;
        count2 = count2 + 1;
    }
}
Console.WriteLine($"Количество цифр введенного числа = {count1 + count2}");
