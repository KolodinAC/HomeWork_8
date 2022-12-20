// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


// Создадим программу для спирального заполнения квадратного массива произвольного размера

using static Common.Helper;

Console.WriteLine();
int n = UserInput("Введите размер квадратного массива: ");
Console.WriteLine();
int[,] newArray = new int[n, n];
Console.WriteLine($"Создан массив размером {n} на {n}");
Console.WriteLine();
int[,] resArray = GetSpiralArray(newArray);
Console.WriteLine("Cпирально заполненный массив: ");
Print2DArray(resArray);

int[,] GetSpiralArray(int[,] spiraleMatrix)
{
    int[,] tempArr = new int[spiraleMatrix.GetLength(0), spiraleMatrix.GetLength(1)];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= tempArr.GetLength(0) * tempArr.GetLength(1))
    {
        tempArr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
    return tempArr;
}

