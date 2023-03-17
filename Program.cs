/*  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1                     */

#pragma warning disable
using System;
int m = 1;
int n = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"N = {n} -> ");

Console.WriteLine($"{PrintNumbers(m, n)}");

string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        return end.ToString();
    }
    string result = PrintNumbers(start + 1, end) + ", " + start.ToString();
    return result;
}