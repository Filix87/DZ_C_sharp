/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3     */

Console.WriteLine();
int m = el("Введите количество строк: ");
int n = el("Введите количество столбцов: ");
int[,] array = new int[m, n];
int el(string array)
{
    Console.Write(array);
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
double[] arr = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    arr[i] = result / array.GetLength(0);
}
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(arr);
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 1);
        Console.Write($"{array[i] + ";  "}");
    }
}