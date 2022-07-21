// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

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

int[] RowSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int perRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            perRow = perRow + array[i, j];
        }
        sum[i] = perRow;
        System.Console.WriteLine();
    }
    return sum;
}

int Small(int[] array)
{
    int ans = 0;
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[i] + 1)
        {
            min = array[i];
        }
    }
    return min;
}


int[,] array = CreateArray(4, 3, 1, 9);
Print(array);
System.Console.WriteLine();
System.Console.WriteLine(Small(RowSum(array)));

