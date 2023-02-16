/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int number, number2;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out number2);

if (number > number2)
{
    Console.Write($"max: {number} ; min: {number2}");
}
else
{
    Console.Write($"max: {number2} ; min: {number}");
}