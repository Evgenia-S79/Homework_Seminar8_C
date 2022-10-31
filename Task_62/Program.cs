// Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] GetSpire(int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return arr;
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

int[,] array = new int[4, 4];
GetSpire(array);
PrintArray(array);
