/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4         
17 -> такого числа в массиве нет                        */

int m = el("Введите количество строк: ");
int n = el("Введите количество столбцов: ");
int[,] array = new int[m, n];
int el(string arr)
{
    Console.Write(arr);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
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
Console.WriteLine("Теперь нужно выбрать элемент из массива");
Console.Write("Позиция элемента в строке: ");
int strok = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Позиция элемента в столбце: ");
int stolb = Convert.ToInt32(Console.ReadLine()) - 1;
if (strok < 0 || strok > array.GetLength(0) - 1 || stolb < 0 || stolb > array.GetLength(1) - 1)
{
    Console.WriteLine($"{strok + 1}{stolb + 1} -> такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[strok, stolb]}");
}