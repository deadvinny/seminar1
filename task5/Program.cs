﻿// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число число : ");
int N = int.Parse(Console.ReadLine());
int minusN = 0 - N;
if (N < minusN)
{
    for (int i = N; i <= minusN; i++)
    {
        Console.Write($"{i} ");
    }
}
else
{
    for (int i = minusN; i <= N; i++)
    {
        Console.Write($"{i} ");
    }
}