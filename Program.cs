/* Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12                            */

int a = TakeInt();
Console.Write($"{a} -> {Sum(a)}");
int Sum(int _a)
{
    int sum = 0;
    for (int i = 3; i >= 0; i--)
    {
        sum += a / (int)Math.Pow(10, i);
        a = a % (int)Math.Pow(10, i);
    }
    return sum;
}
int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}