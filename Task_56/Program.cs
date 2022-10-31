// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FillArrayRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumNumbRow(int[,] arr, int i)
{
    int sumRow = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sumRow += arr[i, j];
    }
    return sumRow;
}

int GetRowMinSum(int[,] arr)
{
    int minSumRow = 0;
    int sumRow = SumNumbRow(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumRow = SumNumbRow(arr, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = i;
        }
    }
    return minSumRow + 1;
}

int[,] array = new int[5, 4];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine($"Строка {GetRowMinSum(array)} - с наименьшей суммой элементов.");