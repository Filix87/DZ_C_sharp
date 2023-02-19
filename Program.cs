/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N < 999 && N > 100)
        Console.Write($"{N} -> {N / 10 % 10}");
    else
        Console.Write("Введите трехзначное число");
}
else
    Console.Write("Неверный ввод");