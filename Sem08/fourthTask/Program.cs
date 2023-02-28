/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2:
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


int RandomValue(int[,,] array, int iNum, int jNum, int kNum)
{
    int value = new Random().Next(10, 100);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == iNum && j == jNum && k == kNum)
                {
                    if (array[i, j, k] == array[iNum, jNum, kNum]) array[iNum, jNum, kNum] = value;
                }
            }
        }
    }
    return value;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] CreateArray(int rank1, int rank2, int rank3)
{
    int[,,] array = new int[rank1, rank2, rank3]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {      
                array[i, j, k] = RandomValue(array, i, j, k);    
            }
        }
    }
    return array;
}

int[,,] myArray = CreateArray(2,2,2);
PrintArray(myArray);
