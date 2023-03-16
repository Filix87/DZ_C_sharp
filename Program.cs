/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07                     */

int[,] array = new int[6, 8];

FillArraySquare(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(String.Format("{0,3}", array[i, j]));
    Console.WriteLine();
}

void FillArraySquare(int[,] arr)
{

    int size = arr.GetLength(0) * arr.GetLength(1);
    Move move = Move.right;

    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    int i = 0, j = 0;
    int ik = 0, jk = 1;

    for (int item = 1; item <= size; item++)
    {
        switch (move)
        {
            case Move.right:
                if (j + 1 < cols && arr[i, j + 1] == 0)
                    arr[i, j] = item;
                else
                {
                    array[i, j] = item;
                    move = Move.down;
                    ik = 1;
                    jk = 0;
                }
                break;
            case Move.down:
                if (i + 1 < rows && arr[i + 1, j] == 0)
                    arr[i, j] = item;
                else
                {
                    arr[i, j] = item;
                    move = Move.left;
                    ik = 0;
                    jk = -1;
                }
                break;
            case Move.left:
                if (j - 1 >= 0 && arr[i, j - 1] == 0)
                    arr[i, j] = item;
                else
                {
                    arr[i, j] = item;
                    move = Move.up;
                    ik = -1;
                    jk = 0;
                }
                break;
            case Move.up:
                if (i - 1 >= 0 && arr[i - 1, j] == 0)
                    arr[i, j] = item;
                else
                {
                    arr[i, j] = item;
                    move = Move.right;
                    ik = 0;
                    jk = 1;
                }
                break;
        }
        i += ik;
        j += jk;
    }
}

enum Move { down, left, right, up };


