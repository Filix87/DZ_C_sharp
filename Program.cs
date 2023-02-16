/*Урок 1. Знакомство с языком программирования С#

Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int number, number2, number3;

Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out number2);
Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out number3);

if (number > number2 && number > number3)
    Console.Write($"max: {number}");

else if (number2 > number && number2 > number3)
    Console.Write($"max: {number2}");

else if (number3 > number && number3 > number2)
    Console.Write($"max: {number3}");
