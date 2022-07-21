// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

int[,] CreateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// int Min(int[,] array)
// {
//     int min = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min) min = array[i, j];
//         }
//     }
//     return min;
// }

void Turn(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
}

int[,] array = CreateArray(3, 3, 1, 9);
Print(array);
Turn(array);
System.Console.WriteLine();
Print(array);