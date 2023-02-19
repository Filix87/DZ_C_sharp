/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number;
Console.Write("Введите номер дня недели: ");
int.TryParse(Console.ReadLine()!, out number);

if (number <= 0 || number >= 8)
    Console.Write("Нет такого дня недели");
else if (number == 6 || number == 7)
    Console.Write("Выходной день");
else if (number >= 1 && number <= 5)
    Console.Write("Будни");