﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7, обозначающее день недели"); 
int day = Convert.ToInt32( Console.ReadLine() );
if ( day >= 1 && day <= 5 )
    Console.WriteLine("Введенное число не является выходным днем");
else if ( day == 6 || day == 7 ) 
    Console.WriteLine("Введенное число является выходным днем");
else
    Console.WriteLine("Введенное число не соответствует номеру дня недели. Введите другое число");
    