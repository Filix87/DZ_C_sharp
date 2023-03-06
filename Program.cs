/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3                                              */

int countMoreThan0 = 0;
int m_number = Input("Сколько чисел будем вводить? ");
int[] array_numbers = new int[m_number];

for (int i = 0; i < m_number; i++)
{
    int t_num = Input($"Введите число {i + 1}: ");
    array_numbers[i] = t_num;
    if (t_num > 0)
        countMoreThan0++;
}

Print("Чисел больше 0:", countMoreThan0);
Console.Write($"Проверьте сами: {String.Join(" , ", array_numbers)}");

void Print(string some_text, int result)
{
    Console.Write($"{some_text} {result}\n");
}

int Input(string some_text)
{
    int num;
    Console.Write($"{some_text}");
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}