﻿void FillMatrix(int[,] matrix)
{
    Random r = new();
    for(int i = 0; i < matrix.GetLength(0); ++i)
    {
        for(int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = r.Next(-20,20);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write("{0}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
float MatrixProblem1(int[,] matrix)
{
    float result = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j <= i; ++j)
        {
            result += matrix[i, j];
            count++;
        }
    }
    return result/count;
}
int MatrixProblem2(int[,] matrix)  //Matrix have Opposite diagonal if it is square matrix ( n == m)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(0) - i; ++j)
        {
            if (matrix[i, j] % 2 != 0)
                ++result;
        }
    }
    return result;
}

int n = 4;
int m = 4;
int[,] matrix = new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(MatrixProblem1(matrix));
Console.WriteLine(MatrixProblem2(matrix));