/*Урок 1. Знакомство с языком программирования С#

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N;
Console.Write($"Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    for (int i = 2; i <= N; i += 2)
        Console.Write($"{i}, ");
}
else
    Console.Write("Неверный ввод");