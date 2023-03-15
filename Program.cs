/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка                                */

int m = el("Введите количество строк: ");
int n = m + 1;
int[,] array = new int[m, n];
int el(string arr)
{
    Console.Write(arr);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
Console.WriteLine();
Console.WriteLine("Получился такой массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int minRowIndex = 0;
int minRowSum = int.MaxValue;
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minRowSum)
    {
        minRowIndex = i;
        minRowSum = rowSum;
    }
    Console.WriteLine($"Суммы элементов в каждой строке: {rowSum}");
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: " + (minRowIndex + 1));

