// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static Common.Helper;


Console.WriteLine();
int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");
Console.WriteLine();

int[,] newArray = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(newArray);
Console.WriteLine();
SortArrayNumbers(newArray);
Console.WriteLine();
Console.WriteLine("Массив отсортирован по убыванию: ");
Print2DArray(newArray);
Console.WriteLine();

void SortArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


