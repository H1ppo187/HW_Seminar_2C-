// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число ");
// string number = Console.ReadLine()!;
// if (number.Length == 3)
// {
//     Console.WriteLine($"{number} -> {number[1]}");
// }
// else
// {
//     Console.WriteLine("Введено неверное число");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число ");
// string number = Console.ReadLine()!;
// if (number.Length < 3)
// {
//     Console.WriteLine("третьей цифры нет ");
// }
// else
// {
//     Console.WriteLine($"{number} -> {number[2]}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} -> да ");
}
else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine($"{number} -> нет ");
}
else
{
    Console.WriteLine("Введено неверное число ");
}