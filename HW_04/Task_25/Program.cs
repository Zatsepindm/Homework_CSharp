// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Expo(int A, int B)
{
    int expo = 1;
    if (A == 0 && B == 0)
        System.Console.WriteLine($"Ошибка. Введите другие значения");
    else
    {
        for (int i = 1; i <= B; i++)
        {
            expo = expo * A;
        }
        System.Console.WriteLine(expo);
    }
}

System.Console.WriteLine("Введите основание степени");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите показатель степени");
int B = Convert.ToInt32(Console.ReadLine());
Expo(A, B);