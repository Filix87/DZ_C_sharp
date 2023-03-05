/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0                                                    */

int[] array = FillArray(8, -9, 99);
Console.Write($"{String.Join(", ", array)}");
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.Write($" -> {sum}");
int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}