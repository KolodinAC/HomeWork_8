// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using static Common.Helper;


Console.WriteLine();
int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");
Console.WriteLine();

int[,] array = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(array);
Console.WriteLine();



int minSumLine = 0;
int sumLine = SumOfElementsInLine(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumOfElementsInLine(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa содержит наименьшую сумму ({sumLine}) элементов ");


int SumOfElementsInLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
