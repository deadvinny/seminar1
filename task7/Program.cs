﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write($"Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number < 100 ) 
{
Console.WriteLine($"{number} - неверное число");
}
else
{
int ostatok = number % 10;
Console.WriteLine($"Последняя цифра числа: {ostatok}");
}