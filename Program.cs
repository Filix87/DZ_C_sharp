/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3                                              */

int number;
Console.Write("Укажите количество чисел, которые собираетесь ввести: ");
int.TryParse(Console.ReadLine()!, out number);

int[] N = new int[number];
for (int i = 0; i < number; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    N[i] = int.Parse(Console.ReadLine()!);
}
int count = 0;
foreach (int N2 in N)
{
    if (N2 > 0)
    {
        count++;
    }
}
Console.WriteLine($"{string.Join(", ", N)} -> {count}");