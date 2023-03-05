/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76                                              */
int[] array = FillArray(5, 1, 99);
Console.Write($"{String.Join(", ", array)}\n");
int min = array[0];
int max = array[0];
foreach (int arr in array)
{
    if (arr < min)
    {
        min = arr;
    }
    if (arr > max)
    {
        max = arr;
    }
}
int diff = max - min;
Console.Write($"{max}-{min}={max - min}");
int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}