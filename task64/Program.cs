﻿﻿/* 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void DecreasNuturalNum(int n)
{
    if (n >= 1)
    {
        System.Console.Write(n+", ");
        DecreasNuturalNum(n - 1);
    }
}
DecreasNuturalNum(8);