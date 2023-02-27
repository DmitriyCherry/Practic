
/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
элементов: 1 строка*/

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(0, 10);
            Console.Write(arg[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void LowerSumRows(int[,] arg)
{
    int sumRow = 0; int minSum = 0; int result = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sumRow += arg[i, j];
        }
        if (minSum < sumRow) minSum = sumRow;
        sumRow = 0;
    }
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sumRow += arg[i, j];
        }
        if (minSum > sumRow)
        {
            minSum = sumRow;
            result = minSum + i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов --> {result - minSum + 1}-ая строка.");
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] myArray = new int[rows, colomns];
PrintArray(myArray);
LowerSumRows(myArray);
