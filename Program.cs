/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N > 100 && N < 999)
        Console.Write($"{N} -> {N / 1 % 10}");
    else if (N > 1000 && N < 9999)
        Console.Write($"{N} -> {N / 10 % 10}");
    else if (N > 10000 && N < 99999)
        Console.Write($"{N} -> {N / 100 % 10}");
    else if (N > 100000)
        Console.Write($"{N} Большое число");
    else Console.Write("Третьей цифры нет");
}
else
    Console.Write("Неверный ввод");