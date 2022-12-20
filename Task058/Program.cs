// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using static Common.Helper;


Console.WriteLine();
int m = UserInput("Введите желаемое количество строк первого массива: ");
int n = UserInput("Введите желаемое количество столбцов первого массива и строк второго: ");
int p = UserInput("Введите желаемое количество столбцов второго массива: ");
Console.WriteLine();

int[,] array1 = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный массив №1: ");
Print2DArray(array1);
Console.WriteLine();

int[,] array2 = CreateRandom2DArray(n, p);
Console.WriteLine("Сгенерированный массив №2: ");
Print2DArray(array2);
Console.WriteLine();

int[,] resultArray = new int[m, p];

MultiplyArrays(array1, array2, resultArray);
Console.WriteLine($"Произведение первого и второго массивов: ");
Print2DArray(resultArray);
Console.WriteLine();

void MultiplyArrays(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
