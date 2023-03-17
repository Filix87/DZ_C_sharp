/*  Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30                     */

int m;
int n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"M = {m}; N = {n} -> {PrintNumbers(m, n)}");

int PrintNumbers(int m, int n)
{
    if (n == m)
        return n;
    return n + PrintNumbers(m, n - 1);
}