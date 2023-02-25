/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16                              */

double a = 1;
double b = 1;
double step = 0;

Console.Write($"Введите число ");
double.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите степень ");
double.TryParse(Console.ReadLine()!, out b);

if (a != 0 && b != 0)
    Console.Write($"{step = Math.Pow(a, b)}");
else Console.Write($"Неверный ввод");
