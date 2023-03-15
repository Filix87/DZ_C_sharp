/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18                        */
int[,] a = new int[2, 2];
int[,] b = new int[2, 2];
for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++)
        a[i, j] = new Random().Next(10);
for (int i = 0; i < b.GetLength(0); i++)
    for (int j = 0; j < b.GetLength(1); j++)
        b[i, j] = new Random().Next(10);

if (a.GetLength(1) != b.GetLength(0))
{
    Console.Write($"Матрицы нельзя умножить");
    return;
}
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < c.GetLength(0); i++)
    for (int j = 0; j < c.GetLength(1); j++)
        for (int k = 0; k < a.GetLength(1); k++)
            c[i, j] += a[i, k] * b[k, j];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
        Console.Write($"   {a[i, j]}");
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
        Console.Write($"   {b[i, j]}");
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
        Console.Write(String.Format(" {0,4}", c[i, j]));
    Console.WriteLine();
}