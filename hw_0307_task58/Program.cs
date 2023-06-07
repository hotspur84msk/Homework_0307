// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNumber()
{
    int num = new Random().Next(2, 2);
    return num;
}
void CraeteArray(int[,] arr)
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MatrixProduct(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    int result = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            result = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = result;
        }
    }
}
int iA = InputNumber(), jA = InputNumber();
int iB = InputNumber(), jB = InputNumber();
int[,] matrixA = new int[iA, jA];
int[,] matrixB = new int[iB, jB];
int[,] newMatrixC = new int[iA, jB];
if (jA == iB)
{
Console.WriteLine("Матрица А:");
CraeteArray(matrixA);
PrintArray(matrixA);
Console.WriteLine("Матрица В:");
CraeteArray(matrixB);
PrintArray(matrixB);
MatrixProduct(matrixA, matrixB, newMatrixC);
    Console.WriteLine("Матрица C:");
    PrintArray(newMatrixC);
}