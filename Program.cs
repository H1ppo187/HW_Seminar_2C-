﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число ");
string number = Console.ReadLine()!;
if (number.Length == 3)
{
    Console.WriteLine($"{number} -> {number[1]}");
}
else
{
    Console.WriteLine("Введено неверное число");
}