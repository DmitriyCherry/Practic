/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintResultMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixProdact(int[,] array1, int[,] array2)
{
    int[,] resultMarix = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                resultMarix[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    resultMarix[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    PrintResultMatrix(resultMarix);
}

Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 1-й матрицы: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n]; int[,] matrix2 = new int[n, p];
PrintArray(matrix);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine("-------");
MatrixProdact(matrix, matrix2);