// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int [,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
            for (int k = 0; k < firstMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] firstMatrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
FillMatrixRandom(firstMatrix);
FillMatrixRandom(secondMatrix);
Console.WriteLine($"\nПервая матрица: ");
PrintMatrix(firstMatrix);
Console.WriteLine($"\nВторая матрица: ");
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine($"Произведение первой и второй матриц: ");
int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
PrintMatrix(resultMatrix);