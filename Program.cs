/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли
оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да                                                                           */

int N = 0;
int N3 = 0;
Console.Write($"Введите 5-и значное число: ");
int.TryParse(Console.ReadLine()!, out N);
int i, N2 = N;
string num = " ";
do
{
    i = N2 % 10;
    num += i.ToString();
    N2 /= 10;
}
while (N2 > 0);
int.TryParse(num, out N3);
Console.Write($"{N}, {N3} - ");
if (N == N3)
    Console.Write($"Да");
else
    Console.Write($"Нет");
