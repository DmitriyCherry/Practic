/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4    В итоге получается вот такой массив:
                         7 4 2 1
                         9 5 3 2
                         8 4 4 2*/

void PrintArray(int[,] arg)
{
    int height = arg.GetLength(0);
    int widht = arg.GetLength(1);

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < widht; j++)
        {
            arg[i, j] = new Random().Next(-4, 10);
            Console.Write(arg[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ReverseRows(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива: ");
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] myArray = new int[m, n];
PrintArray(myArray);
Console.WriteLine();
ReverseRows(myArray);
