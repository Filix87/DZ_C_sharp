/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)                                            */

double[] b = new double[2];
double[] k = new double[2];
Console.Write($"Введите точки b1: ");
double.TryParse(Console.ReadLine()!, out b[0]);
Console.Write($"Введите точки b2: ");
double.TryParse(Console.ReadLine()!, out b[1]);
Console.Write($"Введите точки k1: ");
double.TryParse(Console.ReadLine()!, out k[0]);
Console.Write($"Введите точки k2: ");
double.TryParse(Console.ReadLine()!, out k[1]);
if (k[0] == k[1])
{
    if (b[0] == b[1])
    {
        Console.WriteLine("Накладываются");
    }
    else
    {
        Console.WriteLine("Параллельны");
    }
}
else
{
    double x = (b[1] - b[0]) / (k[0] - k[1]);
    double y = k[0] * x + b[0];
    Console.WriteLine($"b1 = {b[0]}, k1 = {k[0]}, b2 = {b[1]}, k2 = {k[1]} -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}